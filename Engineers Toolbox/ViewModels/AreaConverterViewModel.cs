using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngineersToolbox.Models.Enums;
using EngineersToolbox.Models.Selectors;
using EngineersToolbox.Services.Converters;
using EngineersToolbox.Utility;
using EngineersToolbox.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace EngineersToolbox.ViewModels
{
    public partial class AreaConverterViewModel : ToolboxBaseViewModel
    {
        private AreaConverter _converter;
        private SettingsUtility _settingsService;

        public AreaConverterViewModel()
        {
            _converter = new AreaConverter();
            _settingsService = new SettingsUtility();
            Title = "Area Conversion";
            Bind();
        }

        [ObservableProperty]
        private decimal value;

        [ObservableProperty]
        private AreaUnits valueUnits;

        [ObservableProperty]
        private decimal convertedValue;

        [ObservableProperty]
        private AreaUnits convertedValueUnits;

        [ObservableProperty]
        private AreaUnitsSelector valueUnitsSelector;

        [ObservableProperty]
        private AreaUnitsSelector convertedValueUnitsSelector;

        public ObservableCollection<AreaUnitsSelector> ValueUnitsOptions { get; set; }
        public ObservableCollection<AreaUnitsSelector> ConversionUnitsOptions { get; set; }

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
                    case AreaUnits.SquareInch:
                        ConvertedValue = _converter.GetSquareInches(Value, ValueUnits);
                        break;
                    case AreaUnits.SquareFoot:
                        ConvertedValue = _converter.GetSquareFeet(Value, ValueUnits);
                        break;
                    case AreaUnits.SquareYard:
                        ConvertedValue = _converter.GetSquareYards(Value, ValueUnits);
                        break;
                    case AreaUnits.SquareMile:
                        ConvertedValue = _converter.GetSquareMiles(Value, ValueUnits);
                        break;
                    case AreaUnits.SquareMillimeter:
                        ConvertedValue = _converter.GetSquareMillimeters(Value, ValueUnits);
                        break;
                    case AreaUnits.SquareCentimeter:
                        ConvertedValue = _converter.GetSquareCentimeters(Value, ValueUnits);
                        break;
                    case AreaUnits.SquareKilometer:
                        ConvertedValue = _converter.GetSquareKilometers(Value, ValueUnits);
                        break;
                    case AreaUnits.SquareMeter:
                        ConvertedValue = _converter.GetSquareMeters(Value, ValueUnits);
                        break;
                    case AreaUnits.Acre:
                        ConvertedValue = _converter.GetAcres(Value, ValueUnits);
                        break;
                    case AreaUnits.Hectare:
                        ConvertedValue = _converter.GetHectare(Value, ValueUnits);
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
            ValueUnitsOptions = new ObservableCollection<AreaUnitsSelector>()
            {
                new AreaUnitsSelector() { Units = AreaUnits.Acre, UnitsName = "ac" },
                new AreaUnitsSelector() { Units = AreaUnits.Hectare, UnitsName = "ha" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareCentimeter, UnitsName = "sq cm" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareFoot, UnitsName = "sq ft" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareInch, UnitsName = "sq in" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareKilometer, UnitsName = "sq km" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareMeter, UnitsName = "sq m" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareMile, UnitsName = "sq mi" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareMillimeter, UnitsName = "sq mm" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareYard, UnitsName = "sq yd" }
            };
            ConversionUnitsOptions = new ObservableCollection<AreaUnitsSelector>()
            {
                new AreaUnitsSelector() { Units = AreaUnits.Acre, UnitsName = "ac" },
                new AreaUnitsSelector() { Units = AreaUnits.Hectare, UnitsName = "ha" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareCentimeter, UnitsName = "sq cm" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareFoot, UnitsName = "sq ft" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareInch, UnitsName = "sq in" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareKilometer, UnitsName = "sq km" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareMeter, UnitsName = "sq m" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareMile, UnitsName = "sq mi" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareMillimeter, UnitsName = "sq mm" },
                new AreaUnitsSelector() { Units = AreaUnits.SquareYard, UnitsName = "sq yd" }
            };

            var defaultUnits = _settingsService.GetDefaultAreaUnits();
            var defaultConversionUnits = _settingsService.GetDefaultAreaConversionUnits();

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
