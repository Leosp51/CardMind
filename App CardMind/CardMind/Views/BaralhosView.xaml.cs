using CardMind.Models;
using CardMind.Popups;
using CardMind.Services.ApiCardMind;
using CardMind.Services.LocalServices;
using CardMind.ViewModels;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace CardMind.Views;

public partial class BaralhosView : ContentPage
{
	private SistemaRecompensa sistemaRecompensa = new();
	public BaralhosView(BaralhosViewModel baralhosViewModel)
	{
		InitializeComponent();
		BindingContext = baralhosViewModel;

		header.Dinheiro = sistemaRecompensa.Dinheiro.ToString();
		header.Trofeus = sistemaRecompensa.Trofeus.ToString();
	}
	protected override void OnAppearing()
	{
		header.Dinheiro = sistemaRecompensa.Dinheiro.ToString();
		header.Trofeus = sistemaRecompensa.Trofeus.ToString();
	}
}