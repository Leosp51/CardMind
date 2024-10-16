using CardMind.Services.ApiCardMind;
using CardMind.Services.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMind.ViewModels
{
    public partial class LoginViewModel:ObservableObject
    {
        private readonly INavigationService navigationService;
        private UsuarioService usuarioService;

        [ObservableProperty]
        public string email;
        [ObservableProperty]
        public string password;

        [RelayCommand]
        public async Task SignIn()
        {
            //await usuarioService.Autenticar("email", "senha");
            await navigationService.NavigateToAsync("//Menu/Home");
        }
        public LoginViewModel(INavigationService navigationService, UsuarioService usuarioService)
        {
            this.navigationService = navigationService;
            this.usuarioService = usuarioService;

            Email = string.Empty;
            Password = string.Empty;
        }
    }
}
