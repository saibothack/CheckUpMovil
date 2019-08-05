using System;
using System.Threading.Tasks;
using CheckUpMovil.Utilities;
using CheckUpMovil.Views;
using Xamarin.Forms;

namespace CheckUpMovil.ViewModels
{
    public class IntroPageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }

        public IntroPageViewModels()
        {
            GoToTutorial();
        }

        private bool CanExecuteSubmit()
        {
            return !IsBusy;
        }

        public async void GoToTutorial()
        {
            await Task.Delay(5000);
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

    }

}
