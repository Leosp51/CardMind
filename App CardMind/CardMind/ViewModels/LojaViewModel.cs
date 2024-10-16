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

namespace CardMind.ViewModels
{
    public partial class LojaViewModel: ObservableObject
    {
        private EstilosServico estilosServico;
        
        [ObservableProperty]
        public ObservableCollection<EstiloBaralho> estilos;
        [ObservableProperty]
        public int dinheiroUsuario;

        public LojaViewModel()
        {
            Estilos = new();
            DinheiroUsuario = 0; 
            PegarEstilos();
        }

        public void PegarEstilos()
        {
        }
        public void HandleGetEstilosError()
        {
            //
        }

        [RelayCommand]
        public void comprarEstilo()
        {
            
        }
    }
}
