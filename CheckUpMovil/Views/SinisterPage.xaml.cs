using CheckUpMovil.Utilities;
using CheckUpMovil.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckUpMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SinisterPage : ContentPage
    {
        private SinisterPageViewModels viewModel;

        public SinisterPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new SinisterPageViewModels();
            viewModel.Navigation = this.Navigation;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            IErrorHandler errorHandler = null;
            viewModel.CommandSave.ExecuteAsync().FireAndForgetSafeAsync(errorHandler);
        }

        void Handle_Clicked_Call(object sender, System.EventArgs e)
        {
            IErrorHandler errorHandler = null;
            viewModel.CommandCall.ExecuteAsync().FireAndForgetSafeAsync(errorHandler);
        }
    }
}
