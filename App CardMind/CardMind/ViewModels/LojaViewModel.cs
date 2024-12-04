using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CardMind.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardMind.Services.ApiCardMind;
using CardMind.Services.LocalServices;
using CommunityToolkit.Maui.Views;
using CardMind.Popups;

namespace CardMind.ViewModels
{
    public partial class LojaViewModel: ObservableObject
    {
        private EstilosServico estilosServico;
        private SistemaRecompensa sistemaRecompensa = new();

        [ObservableProperty]
        public ObservableCollection<EstiloBaralho> estilos;
        [ObservableProperty]
        public string dinheiroUsuario;
        [ObservableProperty]
        public string trofeusUsuario;

        public LojaViewModel(SistemaRecompensa sistemaRecompensa)
        {
            this.sistemaRecompensa = sistemaRecompensa;
            Estilos = new();
            DinheiroUsuario = "0"; 
            TrofeusUsuario = "0";
            PegarEstilos();
            Estilos.Add(new EstiloBaralho
            {
                CodEstilo = 1,
                NomeEstilo = "Estrela",
                Valor = 10,
                Img = "estilo_estrela.png"
            });
            Estilos.Add(new EstiloBaralho
            {
                CodEstilo = 2,
                NomeEstilo = "Rosas",
                Valor = 20,
                Img = "estilo_rosas.png"
            });
            Estilos.Add(new EstiloBaralho
            {
                CodEstilo = 3,
                NomeEstilo = "Gato",
                Valor = 10,
                Img = "estilo_gato.png"

            });
            Estilos.Add(new EstiloBaralho
            {
                CodEstilo = 4,
                NomeEstilo = "Bege",
                Valor = 20,
                Img = "moeda.png"
            });
        }

        public void PegarEstilos()
        {
        }
        public void HandleGetEstilosError()
        {
            //
        }

        [RelayCommand]
        public async Task ComprarEstilo(EstiloBaralho estilo)
        {
            var popup = new RealizarCompra(estilo.Valor, estilo.NomeEstilo);
            var result = await Shell.Current.CurrentPage.ShowPopupAsync(popup);
            if (result != null)
            {
                if (!result.Equals(false))
                    Appearing();
                else
                    Shell.Current.CurrentPage.ShowPopup(new CompraInvalida());
            }
        }
        [RelayCommand]
        public void Appearing()
        {
            DinheiroUsuario = sistemaRecompensa.Dinheiro.ToString();
            TrofeusUsuario = sistemaRecompensa.Trofeus.ToString();
        }
    }
}
