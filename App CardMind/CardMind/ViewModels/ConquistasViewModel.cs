using CommunityToolkit.Mvvm.ComponentModel;
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
    public partial class ConquistasViewModel:ObservableObject
    {
        private ConquistasService conquistasService;

        [ObservableProperty]
        public ObservableCollection<Conquista> conquistas = new();

        public ConquistasViewModel()
        {
            PegarConquistas();
        }

        public void PegarConquistas()
        {
        }
        public void HandleGetError()
        {
            //coisas
        }

    }
}
