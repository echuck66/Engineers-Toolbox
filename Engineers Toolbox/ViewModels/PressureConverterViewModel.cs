using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngineersToolbox.Models.Enums;
using EngineersToolbox.Models.Selectors;
using EngineersToolbox.Services.Converters;
using EngineersToolbox.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace EngineersToolbox.ViewModels
{
    public partial class PressureConverterViewModel : ToolboxBaseViewModel
    {
        private PressureConverter _converter;

        public PressureConverterViewModel()
        {
            _converter = new PressureConverter();
            Title = "Pressure Conversion";
            Bind();
        }

        [ObservableProperty]
        private decimal value;

        [ObservableProperty]
        private PressureUnits valueUnits;

        [ObservableProperty]
        private decimal convertedValue;

        [ObservableProperty]
        private PressureUnits convertedValueUnits;

        [ObservableProperty]
        private PressureUnitsSelector valueUnitsSelector;

        [ObservableProperty]
        private PressureUnitsSelector convertedValueUnitsSelector;

        public ObservableCollection<PressureUnitsSelector> ValueUnitsOptions { get; set; }
        public ObservableCollection<PressureUnitsSelector> ConversionUnitsOptions { get; set; }

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
                    case PressureUnits.Bar:
                        ConvertedValue = _converter.GetBars(Value, ValueUnits);
                        break;
                    case PressureUnits.KiloPascal:
                        ConvertedValue = _converter.GetKiloPascals(Value, ValueUnits);
                        break;
                    case PressureUnits.psi:
                        ConvertedValue = _converter.GetPsi(Value, ValueUnits);
                        break;
                    case PressureUnits.ksi:
                        ConvertedValue = _converter.GetKsi(Value, ValueUnits);
                        break;
                    case PressureUnits.KiloNewtonPerSquareMeter:
                        ConvertedValue = _converter.GetKiloNewtonMeters(Value, ValueUnits);
                        break;
                    case PressureUnits.Microbar:
                        ConvertedValue = _converter.GetMicroBars(Value, ValueUnits);
                        break;
                    case PressureUnits.Millibar:
                        ConvertedValue = _converter.GetMilliBars(Value, ValueUnits);
                        break;
                    case PressureUnits.NewtonPerSquareMillimeter:
                        ConvertedValue = _converter.GetNewtonMilliMeters(Value, ValueUnits);
                        break;
                    case PressureUnits.NewtonPerSquareCentimeter:
                        ConvertedValue = _converter.GetNewtonCentiMeters(Value, ValueUnits);
                        break;
                    case PressureUnits.NewtonPerSquareMeter:
                        ConvertedValue = _converter.GetNewtonMeters(Value, ValueUnits);
                        break;
                    case PressureUnits.Pascal:
                        ConvertedValue = _converter.GetPascals(Value, ValueUnits);
                        break;
                    case PressureUnits.StandardAtmosphere:
                        ConvertedValue = _converter.GetAtm(Value, ValueUnits);
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
            ValueUnitsOptions = new ObservableCollection<PressureUnitsSelector>()
            {
                new PressureUnitsSelector() { Units = PressureUnits.Pascal, UnitsName = "Pa" },
                new PressureUnitsSelector() { Units = PressureUnits.KiloPascal, UnitsName = "kPa" },
                new PressureUnitsSelector() { Units = PressureUnits.Bar, UnitsName = "bar" },
                new PressureUnitsSelector() { Units = PressureUnits.psi, UnitsName = "psi" },
                new PressureUnitsSelector() { Units = PressureUnits.ksi, UnitsName = "ksi" },
                new PressureUnitsSelector() { Units = PressureUnits.StandardAtmosphere, UnitsName = "atm" },
                new PressureUnitsSelector() { Units = PressureUnits.NewtonPerSquareMeter, UnitsName = "newton/sq m" },
                new PressureUnitsSelector() { Units = PressureUnits.NewtonPerSquareCentimeter, UnitsName = "newton/sq cm" },
                new PressureUnitsSelector() { Units = PressureUnits.NewtonPerSquareMillimeter, UnitsName = "newton/sq mm" },
                new PressureUnitsSelector() { Units = PressureUnits.Millibar, UnitsName = "mbar" },
                new PressureUnitsSelector() { Units = PressureUnits.Microbar, UnitsName = "ubar" }

            };
            ConversionUnitsOptions = new ObservableCollection<PressureUnitsSelector>()
            {
                new PressureUnitsSelector() { Units = PressureUnits.Pascal, UnitsName = "Pa" },
                new PressureUnitsSelector() { Units = PressureUnits.KiloPascal, UnitsName = "kPa" },
                new PressureUnitsSelector() { Units = PressureUnits.Bar, UnitsName = "bar" },
                new PressureUnitsSelector() { Units = PressureUnits.psi, UnitsName = "psi" },
                new PressureUnitsSelector() { Units = PressureUnits.ksi, UnitsName = "ksi" },
                new PressureUnitsSelector() { Units = PressureUnits.StandardAtmosphere, UnitsName = "atm" },
                new PressureUnitsSelector() { Units = PressureUnits.NewtonPerSquareMeter, UnitsName = "newton/sq m" },
                new PressureUnitsSelector() { Units = PressureUnits.NewtonPerSquareCentimeter, UnitsName = "newton/sq cm" },
                new PressureUnitsSelector() { Units = PressureUnits.NewtonPerSquareMillimeter, UnitsName = "newton/sq mm" },
                new PressureUnitsSelector() { Units = PressureUnits.Millibar, UnitsName = "mbar" },
                new PressureUnitsSelector() { Units = PressureUnits.Microbar, UnitsName = "ubar" }
            };

            if (ValueUnitsSelector == null)
            {
                ValueUnitsSelector = ValueUnitsOptions.FirstOrDefault(o => o.Units == PressureUnits.psi);
            }

            if (ConvertedValueUnitsSelector == null)
            {
                ConvertedValueUnitsSelector = ConversionUnitsOptions.FirstOrDefault(o => o.Units == PressureUnits.Bar);
            }
        }
    }
}
