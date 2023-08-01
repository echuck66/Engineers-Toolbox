using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views.Calculators;

public partial class EstimationsPage : ContentPage
{
    private EstimationsViewModel _viewModel;

    public EstimationsPage()
    {
        InitializeComponent();
        _viewModel = new EstimationsViewModel();
        BindingContext = _viewModel;
    }

    public EstimationsPage(EstimationsViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}