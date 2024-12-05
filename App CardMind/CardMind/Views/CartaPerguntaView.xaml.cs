using CardMind.Models;
using CardMind.Services.LocalServices;
using CardMind.Services.Navigation;
using CardMind.ViewModels;

namespace CardMind.Views;
[QueryProperty(nameof(Carta), "CartaPergunta")]
public partial class CartaPerguntaView : ContentPage
{
	private CartaPerguntaViewModel _cartaPerguntaViewModel;
	private CartaPergunta cartaPergunta;
	public CartaPergunta Carta
	{
		get => cartaPergunta;
		set
		{
			cartaPergunta = value;
			_cartaPerguntaViewModel.CartaPergunta = cartaPergunta;
			BindingContext = _cartaPerguntaViewModel;
		}
	}

	private SistemaRecompensa sistemaRecompensa = new();
	private INavigationService navigationService;

	public CartaPerguntaView(CartaPerguntaViewModel cartaPerguntaViewModel)
	{
		_cartaPerguntaViewModel = cartaPerguntaViewModel;
		BindingContext = cartaPerguntaViewModel;
		InitializeComponent();
	}
	

    
}