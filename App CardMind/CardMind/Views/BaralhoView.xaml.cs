using CardMind.Models;
using CardMind.Popups;
using CardMind.Services.LocalServices;
using CardMind.Services.Navigation;
using CardMind.ViewModels;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace CardMind.Views;
public partial class BaralhoView : ContentPage
{

	public BaralhoView( BaralhoViewModel baralhoViewModel)
	{
		InitializeComponent();
		BindingContext = baralhoViewModel;
	}


	
}