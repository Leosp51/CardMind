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
	private ObservableCollection<Baralho> baralhos;
	private SistemaRecompensa sistemaRecompensa = new();
	public BaralhosView(BaralhosViewModel baralhosViewModel)
	{

		baralhos = new ObservableCollection<Baralho>();
		InitializeComponent();
		BindingContext = baralhosViewModel;
		CollectionBaralhos.SelectionMode = SelectionMode.Single;
		CollectionBaralhos.SelectionChanged += BaralhoSelecionado;

	}
	public void PegarBaralhos()
	{
		//executar serviço
		CollectionBaralhos.ItemsSource = baralhos;
	}
	private async void ImageButton_Clicked(object sender, EventArgs e)
	{
		var popup = new CriarBaralho();
		var result = await this.ShowPopupAsync(popup, CancellationToken.None);
		if (result != null)
		{
			var baralho = (Baralho)result;
			baralhos.Add(baralho);
			CollectionBaralhos.ItemsSource = baralhos;
		}
	}
	private async void BaralhoSelecionado(Object sender, SelectionChangedEventArgs e)
	{
		string nomeBaralho = (e.CurrentSelection.First() as Baralho).NomeBaralho;
		string route = "Baralho?nome=" + nomeBaralho;
		await Shell.Current.GoToAsync(route);
	}


    protected override void OnAppearing()
    {
        header.Dinheiro = sistemaRecompensa.Dinheiro.ToString();
        header.Trofeus = sistemaRecompensa.Trofeus.ToString();
    }
}