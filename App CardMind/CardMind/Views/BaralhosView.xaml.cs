using CardMind.Models;
using CardMind.Popups;
using CardMind.Services.ApiCardMind;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace CardMind.Views;

public partial class BaralhosView : ContentPage
{
	private ObservableCollection<Baralho> baralhos;
	public BaralhosView()
	{
		baralhos = new ObservableCollection<Baralho>();
		InitializeComponent();
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
}