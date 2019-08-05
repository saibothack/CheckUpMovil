using System;
using System.Threading.Tasks;
using CheckUpMovil.Utilities;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CheckUpMovil.ViewModels
{
    public class SinisterPageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }
        public AsyncCommand CommandSave { get; set; }
        public AsyncCommand CommandCall { get; set; }

        public Color loadBackColor { get; set; }

        public SinisterPageViewModels()
        {
            CommandSave = new AsyncCommand(SaveAsync, CanExecuteSubmit);
            CommandCall = new AsyncCommand(CallAsync, CanExecuteSubmit);
            loadBackColor = Color.FromHsla(0, 0, 0, 0.1);
        }

        private async Task SaveAsync()
        {
            try
            {
                IsBusy = true;
                await Task.Delay(3000);
                await Application.Current.MainPage.DisplayAlert("Error", "No fue posible completar su solicitud", "Aceptar");
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task CallAsync()
        {
            try
            {
                IsBusy = true;

                try
                {
                    PhoneDialer.Open("+5215573348266");
                }
                catch (ArgumentNullException anEx)
                {
                    // Number was null or white space
                }
                catch (FeatureNotSupportedException ex)
                {
                    // Phone Dialer is not supported on this device.
                }
                catch (Exception ex)
                {
                    // Other error has occurred.
                }

                await Application.Current.MainPage.DisplayAlert("Error", "No fue posible completar su solicitud", "Aceptar");
            }
            finally
            {
                IsBusy = false;
            }
        }

        private bool CanExecuteSubmit()
        {
            return !IsBusy;
        }
    }
}
