using CardMind.ViewModels;

namespace CardMind.Views;

public partial class CadastroView : ContentPage
{
	public CadastroView(CadastroViewModel cadastroViewModel)
	{
		BindingContext = cadastroViewModel;
	}

	private async void Entrar(object sender, EventArgs e)
	{

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		
    }
}