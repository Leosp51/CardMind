using CardMind.Models;
using CardMind.Popups;
using CardMind.Services.LocalServices;
using CardMind.ViewModels;
using CommunityToolkit.Maui.Views;

namespace CardMind.Views;

public partial class LojaView : ContentPage
{
	private LojaViewModel _viewModel;

    private SistemaRecompensa sistemaRecompensa = new();
    public LojaView(LojaViewModel lojaViewModel)
	{
		_viewModel = lojaViewModel;
		BindingContext = lojaViewModel;
		InitializeComponent();
	}

    private void ConfirmacaoCompra(Object sender, SelectionChangedEventArgs e)
    {
        int valorEstilo = (e.CurrentSelection.FirstOrDefault() as EstiloBaralho).Valor;
        bool compraValida = sistemaRecompensa.ComprarEstilo(valorEstilo);
        if (!compraValida) {
            var popup = new CompraInvalida();
            this.ShowPopup(popup);
        }
    }

    protected override void OnAppearing()
    {
        header.Dinheiro = sistemaRecompensa.Dinheiro.ToString();
        header.Trofeus = sistemaRecompensa.Trofeus.ToString();
    }
}