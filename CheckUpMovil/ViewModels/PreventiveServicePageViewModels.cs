using System;
using System.Threading.Tasks;
using CheckUpMovil.Utilities;
using Xamarin.Forms;

namespace CheckUpMovil.ViewModels
{
    public class PreventiveServicePageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }
        public AsyncCommand CommandSave { get; set; }

        public Color loadBackColor { get; set; }

        public PreventiveServicePageViewModels()
        {
            CommandSave = new AsyncCommand(SaveAsync, CanExecuteSubmit);
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

        private bool CanExecuteSubmit()
        {
            return !IsBusy;
        }
    }
}
