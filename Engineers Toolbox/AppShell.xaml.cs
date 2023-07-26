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
        Routing.RegisterRoute(nameof(CalculatorsPage), typeof(CalculatorsPage));
        Routing.RegisterRoute(nameof(Base64ConverterPage), typeof(Base64ConverterPage));
        Routing.RegisterRoute(nameof(DistanceConverterPage), typeof(DistanceConverterPage));
        Routing.RegisterRoute(nameof(AngleConverterPage), typeof(AngleConverterPage));  
        Routing.RegisterRoute(nameof(PaymentCalculatorPage), typeof(PaymentCalculatorPage));
        Routing.RegisterRoute(nameof(InterestCalculatorPage), typeof(InterestCalculatorPage));
        Routing.RegisterRoute(nameof(FuelEconomyCalculator), typeof(FuelEconomyCalculator));
        Routing.RegisterRoute(nameof(AreaConverterPage), typeof(AreaConverterPage));
        Routing.RegisterRoute(nameof(PressureConverterPage), typeof(PressureConverterPage));
        Routing.RegisterRoute(nameof(NumberBaseConverterPage), typeof(NumberBaseConverterPage));
        Routing.RegisterRoute(nameof(EstimationsPage), typeof(EstimationsPage));
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        Routing.RegisterRoute(nameof(MassConverterPage), typeof(MassConverterPage));
	}

    public static async Task Alert(string message, string title = "Error")
    {
        await Shell.Current.DisplayAlert(title, message, "OK");
    }
}
