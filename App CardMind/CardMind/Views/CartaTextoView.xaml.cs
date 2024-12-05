using CardMind.Models;
using CardMind.Services.LocalServices;
using CardMind.ViewModels;

namespace CardMind.Views;

[QueryProperty(nameof(Carta),"CartaTexto")]
public partial class CartaTextoView : ContentPage
{
	private CartaTextoViewModel cartaTextoViewModel;

	private CartaTexto cartaTexto;
	public CartaTexto Carta
	{
		get => cartaTexto;
		set
		{
			cartaTexto = value;
			cartaTextoViewModel.CartaTexto = cartaTexto;
			BindingContext = cartaTextoViewModel;
		}
	}

    private SistemaRecompensa sistemaRecompensa = new();

    public CartaTextoView(CartaTextoViewModel cartaTextoViewModel)
	{
		InitializeComponent();
		this.cartaTextoViewModel = cartaTextoViewModel;
		BindingContext = cartaTextoViewModel;

	}
}