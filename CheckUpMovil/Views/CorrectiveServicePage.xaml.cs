using CheckUpMovil.Utilities;
using CheckUpMovil.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckUpMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CorrectiveServicePage : ContentPage
    {
        private CorrectiveServicePageViewModels viewModel;
        
        public CorrectiveServicePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new CorrectiveServicePageViewModels();
            viewModel.Navigation = this.Navigation;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            IErrorHandler errorHandler = null;
            viewModel.CommandSave.ExecuteAsync().FireAndForgetSafeAsync(errorHandler);
        }
    }
}
