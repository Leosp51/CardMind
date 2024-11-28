using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMind.Services.Navigation
{
    public class MauiNavigationService : INavigationService
    {
        public Task InitializeAsync()
        {
            bool primeiraVez = Preferences.Default.Get<bool>("primeiraVez", true);
            if (primeiraVez) {
                Preferences.Set("primeiraVez",false);
                NavigateToAsync("//Cadastro");
            }
            return NavigateToAsync(
                    primeiraVez? "//Login":"//Menu/Home"
                );
        }

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            return routeParameters != null
                ? Shell.Current.GoToAsync(route, routeParameters)
                : Shell.Current.GoToAsync(route);
        }

        public Task PopAsync()
        {
            throw new NotImplementedException();
        }
    }
}
