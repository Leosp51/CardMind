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
        collectionEstilos.SelectionChanged += ConfirmacaoCompra;
    }

    private async void ConfirmacaoCompra(Object sender, SelectionChangedEventArgs e)
    {
        EstiloBaralho estilo = (e.CurrentSelection.FirstOrDefault() as EstiloBaralho);
        var result = await this.ShowPopupAsync(new RealizarCompra(estilo.Valor,estilo.NomeEstilo));

        if (result != null)
            if (!result.Equals(false))
            {
                UpdateHeader();
            }
            else
            {
                this.ShowPopup(new CompraInvalida());
            }
    }

    protected override void OnAppearing()
    {
        UpdateHeader();
    }

    private void UpdateHeader()
    {
        header.Dinheiro = sistemaRecompensa.Dinheiro.ToString();
        header.Trofeus = sistemaRecompensa.Trofeus.ToString();
    }
}