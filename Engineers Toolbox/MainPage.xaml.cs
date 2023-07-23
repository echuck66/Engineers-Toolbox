using EngineersToolbox.ViewModels;

namespace EngineersToolbox;

public partial class MainPage : ContentPage
{
	MainPageViewModel _viewModel;

	public MainPage()
	{
		InitializeComponent();
		_viewModel = new MainPageViewModel();
		BindingContext = _viewModel;
	}

	private void OnOpenToolboxClicked(object sender, EventArgs e)
	{
		

	}
}

