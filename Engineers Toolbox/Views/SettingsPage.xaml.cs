using EngineersToolbox.ViewModels;

namespace EngineersToolbox.Views;

public partial class SettingsPage : ContentPage
{
    SettingsViewModel _viewModel;


    public SettingsPage()
    {
        InitializeComponent();
        _viewModel = new SettingsViewModel();
        BindingContext = _viewModel;
    }

    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

}