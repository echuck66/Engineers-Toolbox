using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views.Converters;

public partial class MassConverterPage : ContentPage
{
    MassConverterViewModel _viewModel;

    public MassConverterPage()
    {
        InitializeComponent();
        _viewModel = new MassConverterViewModel();
        BindingContext = _viewModel;
    }

    public MassConverterPage(MassConverterViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

}