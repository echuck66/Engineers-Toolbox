using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views.Converters;

public partial class NumberBaseConverterPage : ContentPage
{
	NumberBaseConverterViewModel _viewModel;

	public NumberBaseConverterPage()
	{
		InitializeComponent();
		_viewModel = new NumberBaseConverterViewModel();
		BindingContext = _viewModel;
	}

    public NumberBaseConverterPage(NumberBaseConverterViewModel viewModel)
    {
        InitializeComponent();
		_viewModel = viewModel;
        BindingContext = _viewModel;
    }
}