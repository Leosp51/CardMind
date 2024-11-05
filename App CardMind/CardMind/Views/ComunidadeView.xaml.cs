using CardMind.Services.LocalServices;

namespace CardMind.Views;

public partial class ComunidadeView : ContentPage
{
	private SistemaRecompensa sistema = new();
	public ComunidadeView()
	{
		InitializeComponent();
		header.Dinheiro = sistema.Dinheiro.ToString();
		header.Trofeus = sistema.Trofeus.ToString();
	}
    protected override void OnAppearing()
    {
        header.Dinheiro = sistema.Dinheiro.ToString();
        header.Trofeus = sistema.Trofeus.ToString();
    }
}