using CardMind.Models;
using System.Collections.ObjectModel;

namespace CardMind.Views;

public partial class Testes : ContentPage
{
	private ObservableCollection<Baralho> baralhos = new ObservableCollection<Baralho>();
	public Testes()
	{
		InitializeComponent();
		baralhos.Add(new Baralho
		{
			NomeBaralho = "Trabalho"
			
		});
		CollectionBaralho.ItemsSource = baralhos;
		CollectionBaralho.SelectionMode = SelectionMode.Single;
		CollectionBaralho.SelectionChanged += ItemSelected;
	}
	private void ItemSelected(object sender, SelectionChangedEventArgs e)
	{
		string nome = (e.CurrentSelection.FirstOrDefault() as Baralho).NomeBaralho;
		Name.Text = nome;
		string rote = "Baralho?nome=" + nome;
		Shell.Current.GoToAsync(rote);
	}
}