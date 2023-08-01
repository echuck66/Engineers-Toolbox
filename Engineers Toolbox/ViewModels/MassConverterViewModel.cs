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
    public partial class MassConverterViewModel : ToolboxBaseViewModel
    {
        private MassConverter _converter;
        private SettingsUtility _settingsService;

        public MassConverterViewModel()
        {
            _converter = new MassConverter();
            _settingsService = new SettingsUtility();
            Title = "Mass Conversion";
            Bind();
        }

        [ObservableProperty]
        private decimal value;

        [ObservableProperty]
        private MassUnits valueUnits;

        [ObservableProperty]
        private decimal convertedValue;

        [ObservableProperty]
        private MassUnits convertedValueUnits;

        [ObservableProperty]
        private MassUnitsSelector valueUnitsSelector;

        [ObservableProperty]
        private MassUnitsSelector convertedValueUnitsSelector;

        public ObservableCollection<MassUnitsSelector> ValueUnitsOptions { get; set; }
        public ObservableCollection<MassUnitsSelector> ConversionUnitsOptions { get; set; }

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
                    case MassUnits.Gram:
                        ConvertedValue = _converter.GetGrams(Value, ValueUnits);
                        break;
                    case MassUnits.Kilogram:
                        ConvertedValue = _converter.GetKilograms(Value, ValueUnits);
                        break;
                    case MassUnits.Ounce:
                        ConvertedValue = _converter.GetOunces(Value, ValueUnits);
                        break;
                    case MassUnits.Pound:
                        ConvertedValue = _converter.GetPounds(Value, ValueUnits);
                        break;
                    case MassUnits.MetricTon:
                        ConvertedValue = _converter.GetMetricTons(Value, ValueUnits);
                        break;
                    case MassUnits.USTon:
                        ConvertedValue = _converter.GetUSTons(Value, ValueUnits);
                        break;
                    case MassUnits.UKTon:
                        ConvertedValue = _converter.GetUKTons(Value, ValueUnits);
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
            ValueUnitsOptions = new ObservableCollection<MassUnitsSelector>()
            {
                new MassUnitsSelector() { Units = MassUnits.Milligram, UnitsName = "mg" },
                new MassUnitsSelector() { Units = MassUnits.Gram, UnitsName = "g" },
                new MassUnitsSelector() { Units = MassUnits.Kilogram, UnitsName = "kg" },
                new MassUnitsSelector() { Units = MassUnits.Pound, UnitsName = "lb" },
                new MassUnitsSelector() { Units = MassUnits.MetricTon, UnitsName = "ton (metric)" },
                new MassUnitsSelector() { Units = MassUnits.USTon, UnitsName = "ton (US)" },
                new MassUnitsSelector() { Units = MassUnits.UKTon, UnitsName = "ton (UK)" }

            };
            ConversionUnitsOptions = new ObservableCollection<MassUnitsSelector>()
            {
                new MassUnitsSelector() { Units = MassUnits.Milligram, UnitsName = "mg" },
                new MassUnitsSelector() { Units = MassUnits.Gram, UnitsName = "g" },
                new MassUnitsSelector() { Units = MassUnits.Kilogram, UnitsName = "kg" },
                new MassUnitsSelector() { Units = MassUnits.Pound, UnitsName = "lb" },
                new MassUnitsSelector() { Units = MassUnits.MetricTon, UnitsName = "ton (metric)" },
                new MassUnitsSelector() { Units = MassUnits.USTon, UnitsName = "ton (US)" },
                new MassUnitsSelector() { Units = MassUnits.UKTon, UnitsName = "ton (UK)" }
            };

            var defaultUnits = _settingsService.GetDefaultMassUnits();
            var defaultConversionUnits = _settingsService.GetDefaultMassConversionUnits();

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
