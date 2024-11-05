using CardMind.Models;
using CardMind.Popups;
using CardMind.Services.LocalServices;
using CardMind.Services.Navigation;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace CardMind.Views;
[QueryProperty(nameof(Nome),"nome")]
public partial class BaralhoView : ContentPage
{
	private  INavigationService _navigationService;
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

	private SistemaRecompensa sistemaRecompensa = new();

	public BaralhoView(INavigationService navigationService)
	{
		InitializeComponent();
		//aplicar servi�o do usu�rio
		cartas = new ObservableCollection<Carta>();
		CollectionCartas.ItemsSource = cartas;
		CollectionCartas.SelectionMode = SelectionMode.Single;
		CollectionCartas.SelectionChanged += CartaEscolhida;
		this._navigationService = navigationService;
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
			_navigationService.NavigateToAsync(route, new Dictionary<string, object>()
			{
				{ route, escolha }
			});
		}
	}
	
	protected override void OnAppearing()
	{
        header.Dinheiro = sistemaRecompensa.Dinheiro.ToString();
        header.Trofeus = sistemaRecompensa.Trofeus.ToString();
		
    }
	
}