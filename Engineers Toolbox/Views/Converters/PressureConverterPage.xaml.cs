using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views.Converters;

public partial class PressureConverterPage : ContentPage
{
    PressureConverterViewModel _viewModel;

    public PressureConverterPage()
    {
        InitializeComponent();
        _viewModel = new PressureConverterViewModel();
        BindingContext = _viewModel;
    }

    public PressureConverterPage(PressureConverterViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}