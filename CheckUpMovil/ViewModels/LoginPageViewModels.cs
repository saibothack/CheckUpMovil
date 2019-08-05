using System.Threading.Tasks;
using CheckUpMovil.Helpers;
using CheckUpMovil.Utilities;
using CheckUpMovil.Views;
using Xamarin.Forms;

namespace CheckUpMovil.ViewModels
{
    public class LoginPageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }
        public AsyncCommand CommandLogin { get; set; }
        public Command ReturnCommandEntry { get; set; }

        public Color loadBackColor { get; set; }

        #region "Properties"

        private string _sEmail;
        public string sEmail
        {
            get { return _sEmail; }
            set
            {
                SetProperty(ref _sEmail, value);
            }
        }

        private string _sEmailError;
        public string sEmailError
        {
            get { return _sEmailError; }
            set
            {
                SetProperty(ref _sEmailError, value);
            }
        }

        private bool _bEmailError;
        public bool bEmailError
        {
            get { return _bEmailError; }
            set
            {
                SetProperty(ref _bEmailError, value);
            }
        }

        private string _sPassword;
        public string sPassword
        {
            get { return _sPassword; }
            set
            {
                SetProperty(ref _sPassword, value);
            }
        }

        private string _sPasswordError;
        public string sPasswordError
        {
            get { return _sPasswordError; }
            set
            {
                SetProperty(ref _sPasswordError, value);
            }
        }

        private bool _bPasswordError;
        public bool bPasswordError
        {
            get { return _bPasswordError; }
            set
            {
                SetProperty(ref _bPasswordError, value);
            }
        }

        #endregion


        public LoginPageViewModels()
        {
            CommandLogin = new AsyncCommand(LoginAsync, CanExecuteSubmit);
            loadBackColor = Color.FromHsla(0, 0, 0, 0.1);

            ReturnCommandEntry = new Command<View>((view) =>
            {
                view?.Focus();
            });
        }

        private async Task LoginAsync()
        {
            try
            {
                if (validate())
                {
                    IsBusy = true;
                    Settings.isLogin = true;
                    Application.Current.MainPage = new NavigationPage(new HomePage());

                    /*ServicesUser servicesUser = new ServicesUser();
                    await servicesUser.LoginAsync(sEmail, sPassword, isNeedPop);*/
                }
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

        private bool validate()
        {
            bool success = true;

            sEmailError = "Ingrese su usuario";
            sPasswordError = "Ingrese su contraseña";

            if (string.IsNullOrEmpty(sEmail))
            {
                success = false;
                bEmailError = true;
            }
            else
            {
                bEmailError = false;
            }

            if (string.IsNullOrEmpty(sPassword))
            {
                success = false;
                bPasswordError = true;
            }
            else
            {
                bPasswordError = false;
            }

            return success;
        }
    }
}
