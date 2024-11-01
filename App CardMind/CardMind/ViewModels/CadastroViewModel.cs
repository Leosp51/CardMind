﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CardMind.Models;
using CardMind.Services;
using CardMind.Services.ApiCardMind;

namespace CardMind.ViewModels
{
    public partial class CadastroViewModel : ObservableObject
    {
        [ObservableProperty]
        public Usuario usuario = new();
        [ObservableProperty]
        public string confirmarSenha = "";
        [ObservableProperty]
        public string message = "";
        [ObservableProperty]
        public string cor = "White";
        [ObservableProperty]
        public bool validado = false;

        private UsuarioService usuarioService;

        public CadastroViewModel(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }
        //[RelayCommand]
        public void Adicionar(Usuario user)
        {
            //Aplicação de serviço de bd
        }
        [RelayCommand]
        public void Validar()
        {/*
            bool valido = true;
            Message = string.Empty;
            if (Usuario.NomeUsuario == null || Usuario.Email == null || Usuario.Senha == null || ConfirmarSenha == null)
            {
                Message += "Preencha os campos!";
                valido = false;
            }
            else if (Usuario.Senha != ConfirmarSenha)
                {
                    Message += "Senhas diferentes!\n";
                    Cor = "Red";
                    valido = false;
                }
            else
                {
                    if (Usuario.Senha == null)
                    {
                        Message += "Insira a senha!";
                        valido = false;
                    }
                    if (ConfirmarSenha == null)
                    {
                        Message += "Confirme a senha";
                        valido = false;
                    }
                }
            
            if (valido)
            {
                var result = usuarioService.postUser(Usuario);
                //verificar se o post ocorreu como esperado
            }
            Validado = valido;
        */
        }
    }
}
