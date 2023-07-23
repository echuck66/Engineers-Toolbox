using EngineersToolbox.ViewModels;
using Microsoft.Maui.Controls;

namespace EngineersToolbox.Views.Calculators;

public partial class PaymentCalculatorPage : ContentPage
{
	PaymentCalculatorViewModel _viewModel;

	public PaymentCalculatorPage()
	{
        InitializeComponent();
		_viewModel = new PaymentCalculatorViewModel();
		BindingContext = _viewModel;
	}

    public PaymentCalculatorPage(PaymentCalculatorViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}