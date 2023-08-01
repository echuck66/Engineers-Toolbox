using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views.Converters;

public partial class AreaConverterPage : ContentPage
{
    AreaConverterViewModel _viewModel;

    public AreaConverterPage()
    {
        InitializeComponent();
        _viewModel = new AreaConverterViewModel();
        BindingContext = _viewModel;
    }

    public AreaConverterPage(AreaConverterViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}