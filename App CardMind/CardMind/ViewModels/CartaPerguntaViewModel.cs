using CardMind.Models;
using CardMind.Services.LocalServices;
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
    public partial class CartaPerguntaViewModel: ObservableObject
    {
        private INavigationService navigationService;
        private SistemaRecompensa sistemaRecompensa;

        [ObservableProperty]
        public CartaPergunta cartaPergunta;
        [ObservableProperty]
        public string dinheiroUsuario;
        [ObservableProperty]
        public string trofeusUsuario;

        public CartaPerguntaViewModel(INavigationService navigationService, SistemaRecompensa sistemaRecompensa)
        {
            this.navigationService = navigationService;
            this.sistemaRecompensa = sistemaRecompensa;
            Appearing();
        }
        [RelayCommand]
        public void VerResposta()
        {

            navigationService.NavigateToAsync("CartaResposta", new Dictionary<string, object>
        {
            {
                "CartaPergunta", CartaPergunta
            }
        });
        }
        [RelayCommand]
        public void Appearing()
        {
            DinheiroUsuario = sistemaRecompensa.Dinheiro.ToString();
            TrofeusUsuario = sistemaRecompensa.Trofeus.ToString();
        }

    }
}
