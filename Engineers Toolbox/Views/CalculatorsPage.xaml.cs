using EngineersToolbox.ViewModels;
using Microsoft.Maui.Controls;

namespace EngineersToolbox.Views;

public partial class CalculatorsPage : ContentPage
{
	private CalculatorsViewModel _viewModel;

	public CalculatorsPage()
	{
		InitializeComponent();
		_viewModel = new CalculatorsViewModel();
		BindingContext = _viewModel;
	}

    public CalculatorsPage(CalculatorsViewModel viewModel)
    {
        InitializeComponent();
		_viewModel = viewModel;
        BindingContext = _viewModel;
    }


}