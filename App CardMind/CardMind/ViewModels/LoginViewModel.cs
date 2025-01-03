﻿using CardMind.Services.ApiCardMind;
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
        private AutenticationService autenticationService;

        [ObservableProperty]
        public string email;
        [ObservableProperty]
        public string password;
        [ObservableProperty]
        public string erro = "";

        [RelayCommand]
        public async Task SignIn()
        {
            if (Email == "lucas@gmail.com" && Password == "123"){
                Preferences.Set("statusUsuario", "cadastro");
                await navigationService.NavigateToAsync("//Menu/Home");
            }
            else
                Erro = "Email ou senha incorretos";
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
