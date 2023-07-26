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
    public partial class VolumeConverterViewModel : ToolboxBaseViewModel
    {
        private VolumeConverter _converter;

        public VolumeConverterViewModel()
        {
            _converter = new VolumeConverter();
            Title = "Volume Conversion";
            Bind();
        }

        [ObservableProperty]
        private decimal value;

        [ObservableProperty]
        private VolumeUnits valueUnits;

        [ObservableProperty]
        private decimal convertedValue;

        [ObservableProperty]
        private VolumeUnits convertedValueUnits;

        [ObservableProperty]
        private VolumeUnitsSelector valueUnitsSelector;

        [ObservableProperty]
        private VolumeUnitsSelector convertedValueUnitsSelector;

        public ObservableCollection<VolumeUnitsSelector> ValueUnitsOptions { get; set; }
        public ObservableCollection<VolumeUnitsSelector> ConversionUnitsOptions { get; set; }

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
                    case VolumeUnits.Pint:
                        ConvertedValue = _converter.GetPints(Value, ValueUnits);
                        break;
                    case VolumeUnits.Milliliter:
                        ConvertedValue = _converter.GetMilliliters(Value, ValueUnits);
                        break;
                    case VolumeUnits.Liter:
                        ConvertedValue = _converter.GetLiters(Value, ValueUnits);
                        break;
                    case VolumeUnits.Gallon:
                        ConvertedValue = _converter.GetGallons(Value, ValueUnits);
                        break;
                    case VolumeUnits.CubicFoot:
                        ConvertedValue = _converter.GetCubicFeet(Value, ValueUnits);
                        break;
                    case VolumeUnits.CubicCentimeter:
                        ConvertedValue = _converter.GetCubicCentimeters(Value, ValueUnits);
                        break;
                    case VolumeUnits.CubicInch:
                        ConvertedValue = _converter.GetCubicInches(Value, ValueUnits);
                        break;
                    case VolumeUnits.CubicMeter:
                        ConvertedValue = _converter.GetCubicMeters(Value, ValueUnits);
                        break;
                    case VolumeUnits.Quart:
                        ConvertedValue = _converter.GetQuarts(Value, ValueUnits);
                        break;
                    case VolumeUnits.CubicYard:
                        ConvertedValue = _converter.GetCubicYards(Value, ValueUnits);
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
