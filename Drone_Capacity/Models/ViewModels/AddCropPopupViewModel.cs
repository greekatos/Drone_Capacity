using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Maui.Views;  // for Popup
using Microsoft.Maui.Controls;     // for Command

namespace Drone_Capacity.Models.ViewModels
{
    public class AddCropPopupViewModel : INotifyPropertyChanged
    {
        bool _isConfirmVisible;
        public bool IsConfirmVisible
        {
            get => _isConfirmVisible;
            set { _isConfirmVisible = value; OnPropertyChanged(); }
        }

        public ICommand ConfirmCommand { get; }

        public AddCropPopupViewModel()
        {
            // Using MAUI's Command instead of RelayCommand
            ConfirmCommand = new Command<object>(async param =>
            {
                var popup = param as Popup;
                IsConfirmVisible = true;
                await Task.Delay(3000);
                popup?.Close();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}