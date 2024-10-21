using CardMind.ViewModels;

namespace CardMind.Views;

public partial class ConquistasView : ContentPage
{
	private ConquistasViewModel viewModel;
	public ConquistasView(ConquistasViewModel conquistasViewModel)
	{
		viewModel = conquistasViewModel;
		BindingContext = viewModel;
		InitializeComponent();
	}
}