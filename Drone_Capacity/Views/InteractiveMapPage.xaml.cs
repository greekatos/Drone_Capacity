using System.IO;
using Microsoft.Maui.Controls;

using Mapsui.Layers;
using Mapsui.Styles;
using Mapsui.UI.Maui;
using Mapsui.UI;
using static Mapsui.Tiling.OpenStreetMap;
using Mapsui;
using Mapsui.Projections;       // for SphericalMercator
using Mapsui.Nts;
using Mapsui.Nts.Extensions;

using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Linq;
using Drone_Capacity.Models.ViewModels;

namespace Drone_Capacity.Views
{
    public partial class InteractiveMapPage : ContentPage
    {
        // Longitude, Latitude
        const double HomeLon = 21.812561, HomeLat = 38.279632;

        // Field corner coordinates (replace with your actual corners)
        List<Coordinate> _coordinates= [
            new Coordinate(21.855, 38.380),
            new Coordinate(21.895, 38.380),
            new Coordinate(21.895, 38.295),
            new Coordinate(21.855, 38.295),
        ];


        // Desired map “resolution” (lower → more zoom)
        const double HomeResolution = 100;

        // Animation parameters
        const long AnimationDuration = 100;

        // Projected center point in WebMercator
        static readonly MPoint centerPoint = SphericalMercator
            // use the tuple overload and then wrap into MPoint:
            .FromLonLat(HomeLon, HomeLat) is (double x, double y)
                ? new MPoint(x, y)
                : new MPoint(0, 0);

        public InteractiveMapPage()
        {
            InitializeComponent();

            // Set the VindingContext to the VM
            BindingContext = new InteractiveMapPageViewModel();

            // Show the Map
            ShowMap();
        }

        void ShowMap()
        {
            // 1) Add OSM tile Layer
            MapView.Map?.Layers.Add(CreateTileLayer());

            // 1a) Project your four corners, then close the ring by adding the first point again
            var wmCoords = _coordinates.Select(v => SphericalMercator.FromLonLat(v.X, v.Y).ToCoordinate()).ToList();

            // append the first point so the rectangle will close
            wmCoords.Add(wmCoords[0]);

            // 2) Create linestring with the *closed* coordinates
            LineString lineString = new(wmCoords.ToArray());




            ICollection<IStyle> styles = [
                new VectorStyle
                {
                    Line = new Pen
                    {
                        Color = Mapsui.Styles.Color.Red,
                        PenStrokeCap = PenStrokeCap.Round,
                        StrokeJoin = StrokeJoin.Round,
                        Width = 15
                    },
                }];

            ILayer lineLayer = new MemoryLayer
            {
                Features = [
                    new GeometryFeature {
                        Geometry = lineString,
                        Styles = styles
                    }],
                Name = "Line Layer"
            };

            // Add layer to map
            MapView.Map?.Layers.Add(lineLayer);
            ;
            // 2) Defer centering & zooming until the map is ready
            MapView.Map.Home = navigator =>
            {
                // navigator is an IMapNavigator; call CenterOnAndZoomTo
                navigator.CenterOnAndZoomTo(
                    centerPoint,
                    HomeResolution,
                    AnimationDuration);
            };
        }


    }
}
