using CardMind.Services.Navigation;
using CardMind.Views;

namespace CardMind
{
    public partial class AppShell : Shell
    {
        private INavigationService _navigationService;
        public AppShell(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Routing.RegisterRoute("Baralho", typeof(BaralhoView));
            InitializeComponent();
        }
    }
}
