using CardMind.Models;
using CardMind.Popups;
using CardMind.Services.Navigation;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMind.ViewModels
{
    public partial class PerfilViewModel:ObservableObject
    {
        [ObservableProperty]
        public string nomeBaralho = "Nome do Baralho";
        [ObservableProperty]
        public ObservableCollection<string> nomes = new ObservableCollection<string>();
        
        private INavigationService navigationService;

        [RelayCommand]
        public async void ShowPopup()
        {
            var popup = new CriarBaralho();
            var result = await Shell.Current.CurrentPage.ShowPopupAsync(popup);
            if (result != null) {
                var baralho = (Baralho)result;
                NomeBaralho = baralho.NomeBaralho;
            }
        }
        public PerfilViewModel(INavigationService navigationService)
        {
            Nomes.Add(NomeBaralho);
            this.navigationService = navigationService;

        }

        private async Task BaralhoSelecionado(string nome)
        {
            await navigationService.NavigateToAsync("Baralho",
                new Dictionary<string, object>
                {
                    {"nome", nome},
                });
        }
    }
}
