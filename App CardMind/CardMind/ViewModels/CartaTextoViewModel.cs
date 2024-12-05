using CardMind.Models;
using CardMind.Services.LocalServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMind.ViewModels
{
    public partial class CartaTextoViewModel:ObservableObject
    {
        private SistemaRecompensa sistemaRecompensa;

        [ObservableProperty]
        public CartaTexto cartaTexto = new();
        [ObservableProperty]
        public string dinheiroUsuario = "";
        [ObservableProperty]
        public string trofeusUsuario = "";

        public CartaTextoViewModel(SistemaRecompensa sistemaRecompensa)
        {
            this.sistemaRecompensa = sistemaRecompensa;
            Appearing();
        }
        [RelayCommand]
        public void Appearing()
        {
            DinheiroUsuario = sistemaRecompensa.Dinheiro.ToString();
            TrofeusUsuario = sistemaRecompensa.Trofeus.ToString();
        }
    }
}
