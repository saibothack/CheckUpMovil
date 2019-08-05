using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckUpMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageMaster : ContentPage
    {
        public ListView ListView;

        public HomePageMaster()
        {
            InitializeComponent();

            BindingContext = new HomePageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class HomePageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomePageMenuItem> MenuItems { get; set; }

            public HomePageMasterViewModel()
            {
                MenuItems = new ObservableCollection<HomePageMenuItem>(new[]
                {
                    new HomePageMenuItem { Id = 0, Title = "Inicio", TargetType = typeof(HomePageDetail) },
                    new HomePageMenuItem { Id = 1, Title = "Cambio de Usuario", TargetType = typeof(ChangeUserPage) },
                    new HomePageMenuItem { Id = 2, Title = "Servicio Correctivo", TargetType = typeof(CorrectiveServicePage) },
                    new HomePageMenuItem { Id = 3, Title = "Servicio Preventivo", TargetType = typeof(PreventiveServicePage) },
                    new HomePageMenuItem { Id = 4, Title = "Consulta Estado", TargetType = typeof(QueryPage) },
                    new HomePageMenuItem { Id = 5, Title = "Reportar Siniestro", TargetType = typeof(SinisterPage) },
                    new HomePageMenuItem { Id = 5, Title = "Salir" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
