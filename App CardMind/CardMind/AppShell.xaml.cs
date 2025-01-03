﻿using CardMind.Services.Navigation;
using CardMind.Views;

namespace CardMind
{
    public partial class AppShell : Shell
    {
        private INavigationService _navigationService;
        public AppShell(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Routing.RegisterRoute("Baralho", typeof(BaralhoView));
            Routing.RegisterRoute("CartaTexto", typeof(CartaTextoView));
            Routing.RegisterRoute("CartaResposta", typeof(CartaResposta));
            InitializeComponent();
        }
        protected override async void OnParentSet()
        {
            base.OnParentSet();
            if (Parent is not null)
            {

                Routing.RegisterRoute("CartaPergunta", typeof(CartaPerguntaView));
                await _navigationService.InitializeAsync();
            }
        }
    }
}
