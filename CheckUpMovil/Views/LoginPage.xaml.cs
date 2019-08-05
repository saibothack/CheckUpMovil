using CheckUpMovil.Utilities;
using CheckUpMovil.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckUpMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private LoginPageViewModels viewModel;

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new LoginPageViewModels();
            viewModel.Navigation = this.Navigation;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            IErrorHandler errorHandler = null;
            viewModel.CommandLogin.ExecuteAsync().FireAndForgetSafeAsync(errorHandler);
        }

    }
}
