using CardMind.Services.LocalServices;
using CardMind.ViewModels;

namespace CardMind.Views;

public partial class ComunidadeView : ContentPage
{

	public ComunidadeView(ComunidadeViewModel comunidadeViewModel)
	{
		InitializeComponent();
		BindingContext = comunidadeViewModel;
	}
}