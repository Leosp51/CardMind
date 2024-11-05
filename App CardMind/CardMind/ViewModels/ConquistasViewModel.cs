using CommunityToolkit.Mvvm.ComponentModel;
using CardMind.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardMind.Services.ApiCardMind;
using System.Windows.Input;

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

            Conquistas.Add(new Conquista
            {
                CodConquista = 1,
                NomeConquista = "Novato",
                Objetivo = "Entre no app pela primeira vez",
                Recompensa = 2,
                IsFinish = true,
                Cor = "Red"
            });
            Conquistas.Add(new Conquista
            {
                CodConquista = 2,
                NomeConquista = "Comprometimento",
                Objetivo = "Entre no app 5 vezes em um único dia",
                Recompensa = 5,
                IsFinish = false,
                Cor = "Gray"
            });
            Conquistas.Add(new Conquista
            {
                CodConquista = 3,
                NomeConquista = "Viciado",
                Objetivo = "Entre no app 10 vezes em um único dia",
                Recompensa = 10,
                IsFinish = false,
                Cor = "Gray"
            });
            Conquistas.Add(new Conquista
            {
                CodConquista = 4,
                NomeConquista = "Mestre da Criação",
                Objetivo = "Crie 20 baralhos",
                Recompensa = 2,
                IsFinish = false,
                Cor = "Red"
            });
        }
        public void HandleGetError()
        {
            
        }

        public ICommand AumentarCommand;


    }
}
