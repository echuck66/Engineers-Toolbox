using EngineersToolbox.ViewModels;
using Microsoft.Maui.Controls;

namespace EngineersToolbox.Views.Converters;

public partial class Base64ConverterPage : ContentPage
{
	Base64ConverterViewModel _viewModel;

    public Base64ConverterPage()
    {
        InitializeComponent();
        _viewModel = new Base64ConverterViewModel();
        BindingContext = _viewModel;
    }

    public Base64ConverterPage(Base64ConverterViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}