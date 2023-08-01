using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngineersToolbox.Models.Selectors;
using EngineersToolbox.Services.Converters;
using EngineersToolbox.Utility;
using EngineersToolbox.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using DistanceUnits = EngineersToolbox.Models.Enums.DistanceUnits;

namespace EngineersToolbox.ViewModels
{
    public partial class DistanceConverterViewModel : ToolboxBaseViewModel
    {
        private DistanceConverter _converter;
        private SettingsUtility _settingsService;
        public DistanceConverterViewModel()
        {
            _converter = new DistanceConverter();
            _settingsService = new SettingsUtility();
            Title = "Distance Conversion";
            Bind();
        }

        [ObservableProperty]
        private decimal value;

        [ObservableProperty]
        private DistanceUnits valueUnits;

        [ObservableProperty]
        private decimal convertedValue;

        [ObservableProperty]
        private DistanceUnits convertedValueUnits;

        [ObservableProperty]
        private DistanceUnitsSelector valueUnitsSelector;

        [ObservableProperty]
        private DistanceUnitsSelector convertedValueUnitsSelector;

        public ObservableCollection<DistanceUnitsSelector> ValueUnitsOptions { get; set; } 
        public ObservableCollection<DistanceUnitsSelector> ConversionUnitsOptions { get; set; }

        [RelayCommand]
        public async Task ConvertValue()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                ValueUnits = ValueUnitsSelector.Units;
                ConvertedValueUnits = ConvertedValueUnitsSelector.Units;

                switch (ConvertedValueUnits)
                {
                    case DistanceUnits.Millimeter:
                        ConvertedValue = _converter.GetMillimeters(Value, ValueUnits);
                        break;
                    case DistanceUnits.Centimeter:
                        ConvertedValue = _converter.GetCentimeters(Value, ValueUnits);
                        break;
                    case DistanceUnits.Meter:
                        ConvertedValue = _converter.GetMeters(Value, ValueUnits);
                        break;
                    case DistanceUnits.Kilometer:
                        ConvertedValue = _converter.GetKilometers(Value, ValueUnits);
                        break;
                    case DistanceUnits.Inch:
                        ConvertedValue = _converter.GetInches(Value, ValueUnits);
                        break;
                    case DistanceUnits.Foot:
                        ConvertedValue = _converter.GetFeet(Value, ValueUnits);
                        break;
                    case DistanceUnits.Yard:
                        ConvertedValue = _converter.GetYards(Value, ValueUnits);
                        break;
                    case DistanceUnits.Mile:
                        ConvertedValue = _converter.GetMiles(Value, ValueUnits);
                        break;

                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }


        [RelayCommand]
        private async Task CloseTool()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync(nameof(ConvertersPage));
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void Bind()
        {

            ValueUnitsOptions = new ObservableCollection<DistanceUnitsSelector>()
            {
                new DistanceUnitsSelector() { Units = DistanceUnits.Inch, UnitsName = "in" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Foot, UnitsName = "ft" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Yard, UnitsName = "yd" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Mile, UnitsName = "mi" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Millimeter, UnitsName = "mm" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Centimeter, UnitsName = "cm" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Meter, UnitsName = "m" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Kilometer, UnitsName = "km" }
            };
            ConversionUnitsOptions = new ObservableCollection<DistanceUnitsSelector>()
            {
                new DistanceUnitsSelector() { Units = DistanceUnits.Inch, UnitsName = "in" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Foot, UnitsName = "ft" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Yard, UnitsName = "yd" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Mile, UnitsName = "mi" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Millimeter, UnitsName = "mm" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Centimeter, UnitsName = "cm" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Meter, UnitsName = "m" },
                new DistanceUnitsSelector() { Units = DistanceUnits.Kilometer, UnitsName = "km" }
            };

            var defaultUnits = _settingsService.GetDefaultDistanceUnits();
            var defaultConversionUnits = _settingsService.GetDefaultDistanceConversionUnits();

            if (ValueUnitsSelector == null)
            {
                ValueUnitsSelector = ValueUnitsOptions.FirstOrDefault(o => o.Units == defaultUnits);
            }

            if (ConvertedValueUnitsSelector == null)
            {
                ConvertedValueUnitsSelector = ConversionUnitsOptions.FirstOrDefault(o => o.Units == defaultConversionUnits);
            }
        }
    }
}
