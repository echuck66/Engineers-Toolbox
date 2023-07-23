using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views;

public partial class ToolboxPage : ContentPage
{
	ToolboxViewModel _viewModel;


    public ToolboxPage()
    {
        InitializeComponent();
        _viewModel = new ToolboxViewModel();
        BindingContext = _viewModel;
    }

    public ToolboxPage(ToolboxViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}

    private void OnOpenConvertersBtnClicked(object sender, EventArgs e)
    {


    }
}