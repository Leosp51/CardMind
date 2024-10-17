namespace CardMind.Views;

public partial class BaralhoView : ContentPage
{
	public BaralhoView()
	{
		InitializeComponent();
		Routing.RegisterRoute("baralho", typeof(BaralhoView));
	}
}