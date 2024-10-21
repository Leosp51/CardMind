using CardMind.ViewModels;

namespace CardMind.Views;

public partial class LojaView : ContentPage
{
	private LojaViewModel _viewModel;
	public LojaView(LojaViewModel lojaViewModel)
	{
		_viewModel = lojaViewModel;
		BindingContext = lojaViewModel;
		InitializeComponent();
	}
}