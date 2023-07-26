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
    public partial class MassConverterViewModel : ToolboxBaseViewModel
    {
        private MassConverter _converter;

        public MassConverterViewModel()
        {
            _converter = new MassConverter();
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
                    case MassUnits.Ton:
                        ConvertedValue = _converter.GetTons(Value, ValueUnits);
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
