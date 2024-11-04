using CardMind.Models;
using CardMind.Popups;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace CardMind.Views;
[QueryProperty(nameof(Nome),"nome")]
public partial class BaralhoView : ContentPage
{
	string nome;
	public string Nome
	{
		get => nome;
		set
		{
			nome = value;
			UpdateUI();
		}
	}
	private ObservableCollection<Carta> cartas;
	public BaralhoView()
	{
		InitializeComponent();
		//aplicar serviço do usuário
		cartas = new ObservableCollection<Carta>();
		CollectionCartas.ItemsSource = cartas;
		CollectionCartas.SelectionMode = SelectionMode.Single;
		CollectionCartas.SelectionChanged += CartaEscolhida;
	}

	void UpdateUI()
	{
		Name.Text = Nome;
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		var popup = new CriarCarta();
		var result = await this.ShowPopupAsync(popup);
		if (result != null) { 
			var carta = (Carta) result;
			cartas.Add(carta);
			CollectionCartas.ItemsSource = cartas;
		}
    }
	private void CartaEscolhida(Object sender, SelectionChangedEventArgs e)
	{
		var escolha = e.CurrentSelection.FirstOrDefault() as Carta;
		if (escolha != null) {
			string route = escolha.Tipo == "Pergunta"? "CartaPergunta": "CartaTexto";
			Shell.Current.GoToAsync(route);
		}
	}
}