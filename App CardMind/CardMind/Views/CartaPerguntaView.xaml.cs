using CardMind.Models;
using CardMind.Services.LocalServices;

namespace CardMind.Views;
[QueryProperty(nameof(Carta), "CartaPergunta")]
public partial class CartaPerguntaView : ContentPage
{
	private CartaPergunta cartaPergunta;
	public CartaPergunta Carta
	{
		get => cartaPergunta;
		set
		{
			cartaPergunta = value;
			UpdateUI();
		}
	}

	private SistemaRecompensa sistemaRecompensa = new();

	public CartaPerguntaView()
	{
		InitializeComponent();
	}
	void UpdateUI()
	{
		lbNomeCarta.Text = cartaPergunta.NomeCarta;
		lbPergunta.Text = cartaPergunta.Pergunta;
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