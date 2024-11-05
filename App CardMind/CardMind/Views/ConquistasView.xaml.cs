using CardMind.Services.LocalServices;
using CardMind.ViewModels;

namespace CardMind.Views;

public partial class ConquistasView : ContentPage
{
	private ConquistasViewModel viewModel;


    private SistemaRecompensa sistemaRecompensa = new();
    public ConquistasView(ConquistasViewModel conquistasViewModel)
	{
		viewModel = conquistasViewModel;
		BindingContext = viewModel;
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
    protected override void OnAppearing()
    {
        header.Dinheiro = sistemaRecompensa.Dinheiro.ToString();
        header.Trofeus = sistemaRecompensa.Trofeus.ToString();
    }
}