using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views.Converters;

public partial class AngleConverterPage : ContentPage
{
    AngleConverterViewModel _viewModel;

    public AngleConverterPage()
    {
        InitializeComponent();
        _viewModel = new AngleConverterViewModel();
        BindingContext = _viewModel;
    }

    public AngleConverterPage(AngleConverterViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}