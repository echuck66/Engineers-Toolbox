using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views;

public partial class ConvertersPage : ContentPage
{
    ConvertersViewModel _viewModel;

    public ConvertersPage()
    {
        InitializeComponent();
        _viewModel = new ConvertersViewModel();
        BindingContext = _viewModel;
    }

    public ConvertersPage(ConvertersViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    private void OnOpenBase64ConverterBtnClicked(object sender, EventArgs e)
    {


    }

    private void OnOpenDistanceConverterBtnClicked(object sender, EventArgs e)
    {


    }
}