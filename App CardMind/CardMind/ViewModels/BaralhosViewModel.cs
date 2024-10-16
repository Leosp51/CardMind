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

namespace CardMind.ViewModels
{
    public partial class BaralhosViewModel:ObservableObject
    {
        private readonly IPopupService popupService;
        private BaralhosService baralhosService;
        public BaralhosViewModel(IPopupService popupService, BaralhosService baralhosService) 
        { 
            this.popupService = popupService;
            this.baralhosService = baralhosService;
        }
        [RelayCommand]
        public void DisplayPopup() 
        {
         //   return this.popupService.ShowPopup<CriarBaralho>(onPresenting:viewModel => viewModel.PerformUpdates(10),null);
        }
    }
}
