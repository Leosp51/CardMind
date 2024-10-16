using CardMind.Services.Navigation;

namespace CardMind
{
    public partial class AppShell : Shell
    {
        private INavigationService _navigationService;
        public AppShell(INavigationService navigationService)
        {
            _navigationService = navigationService;
            InitializeComponent();
        }
    }
}
