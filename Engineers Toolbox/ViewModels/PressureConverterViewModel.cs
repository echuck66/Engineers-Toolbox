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
                        //ConvertedValue = _converter.GetBars(Value, ValueUnits);
                        break;
                    case PressureUnits.KiloNewtonPerSquareMeter:
                        //ConvertedValue = _converter.GetKilograms(Value, ValueUnits);
                        break;
                    case PressureUnits.KiloPascal:
                        //ConvertedValue = _converter.GetOunces(Value, ValueUnits);
                        break;
                    case PressureUnits.Microbar:
                        //ConvertedValue = _converter.GetPounds(Value, ValueUnits);
                        break;
                    case PressureUnits.Millibar:
                        //ConvertedValue = _converter.GetTons(Value, ValueUnits);
                        break;
                    case PressureUnits.NewtonPerSquareCentimeter:
                        //ConvertedValue = _converter.GetTons(Value, ValueUnits);
                        break;
                    case PressureUnits.NewtonPerSquareMeter:
                        //ConvertedValue = _converter.GetTons(Value, ValueUnits);
                        break;
                    case PressureUnits.NewtonPerSquareMillimeter:
                        //ConvertedValue = _converter.GetTons(Value, ValueUnits);
                        break;
                    case PressureUnits.Pascal:
                        //ConvertedValue = _converter.GetTons(Value, ValueUnits);
                        break;
                    case PressureUnits.psi:
                        //ConvertedValue = _converter.GetTons(Value, ValueUnits);
                        break;
                    case PressureUnits.StandardAtmosphere:
                        //ConvertedValue = _converter.GetTons(Value, ValueUnits);
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

        }
    }
}
