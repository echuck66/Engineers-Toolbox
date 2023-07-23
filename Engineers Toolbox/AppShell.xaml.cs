using EngineersToolbox.ViewModels;
using EngineersToolbox.Views;
using EngineersToolbox.Views.Calculators;
using EngineersToolbox.Views.Converters;

namespace EngineersToolbox;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        BindingContext = new AppShellViewModel();

        Routing.RegisterRoute(nameof(ToolboxPage), typeof(ToolboxPage));
        Routing.RegisterRoute(nameof(ConvertersPage), typeof(ConvertersPage));
        Routing.RegisterRoute(nameof(Base64ConverterPage), typeof(Base64ConverterPage));
        Routing.RegisterRoute(nameof(DistanceConverterPage), typeof(DistanceConverterPage));
        Routing.RegisterRoute(nameof(CalculatorsPage), typeof(CalculatorsPage));
        Routing.RegisterRoute(nameof(PaymentCalculatorPage), typeof(PaymentCalculatorPage));
	}

    public static async Task Alert(string message, string title = "Error")
    {
        await Shell.Current.DisplayAlert(title, message, "OK");
    }
}
