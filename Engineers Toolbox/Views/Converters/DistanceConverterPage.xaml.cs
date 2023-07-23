using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views.Converters;

public partial class DistanceConverterPage : ContentPage
{
	DistanceConverterViewModel _viewModel;

    public DistanceConverterPage()
    {
        InitializeComponent();
        _viewModel = new DistanceConverterViewModel();
        BindingContext = _viewModel;
    }

    public DistanceConverterPage(DistanceConverterViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}