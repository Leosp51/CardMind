using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
//using CardMind.Popups;
using CardMind.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardMind.Services.ApiCardMind;
using System.Collections.ObjectModel;
using CardMind.Models;
using CardMind.Services.LocalServices;
using CardMind.Popups;
using CommunityToolkit.Maui.Views;
using CardMind.Services.Navigation;

namespace CardMind.ViewModels
{
    public partial class BaralhosViewModel:ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Baralho> baralhos;
        [ObservableProperty]
        public Baralho item = new();

        private readonly IPopupService popupService;
        private BaralhosService baralhosService;
        private SistemaRecompensa sistemaRecompensa = new();
        private INavigationService navigationService;

        [RelayCommand]
        public async Task ShowPopup()
        {
            var popup = new CriarBaralho();
            var result = await Shell.Current.CurrentPage.ShowPopupAsync(popup);
            if (result != null)
            {
                var baralho = (Baralho)result;
                Baralhos.Add(baralho);
            }
        }
        [RelayCommand]
        public async Task BaralhoSelecionado(Baralho baralho)
        {
            Item = new();
            await navigationService.NavigateToAsync("Baralho",
                new Dictionary<string, object>
                {
                    {"nome", baralho.NomeBaralho}
                });
        }
        public BaralhosViewModel(IPopupService popupService,
                                 BaralhosService baralhosService,
                                 INavigationService navigationService) 
        {
            baralhos = new ObservableCollection<Baralho>();
            this.navigationService = navigationService;
            this.popupService = popupService;
            this.baralhosService = baralhosService;
        }
    }
}
