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
    public partial class AngleConverterViewModel : ToolboxBaseViewModel
    {
        private AngleConverter _converter;
        private SettingsUtility _settingsService;

        public AngleConverterViewModel()
        {
            _converter = new AngleConverter();
            _settingsService = new SettingsUtility();
            Title = "Angle Conversion";
            Bind();
        }

        [ObservableProperty]
        private decimal value;

        [ObservableProperty]
        private AngleUnits valueUnits;

        [ObservableProperty]
        private decimal convertedValue;

        [ObservableProperty]
        private AngleUnits convertedValueUnits;

        [ObservableProperty]
        private AngleUnitsSelector valueUnitsSelector;

        [ObservableProperty]
        private AngleUnitsSelector convertedValueUnitsSelector;

        public ObservableCollection<AngleUnitsSelector> ValueUnitsOptions { get; set; }

        [RelayCommand]
        public async Task ConvertValue()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                ValueUnits = ValueUnitsSelector.Units;

                switch (ValueUnits)
                {
                    case AngleUnits.Degrees:
                        ConvertedValue = _converter.GetRadians(Value);
                        ConvertedValueUnits = AngleUnits.Radians;
                        ConvertedValueUnitsSelector = new AngleUnitsSelector() { Units = ConvertedValueUnits, UnitsName = "radians" };
                        break;
                    case AngleUnits.Radians:
                        ConvertedValue = _converter.GetDegrees(Value);
                        ConvertedValueUnits = AngleUnits.Degrees;
                        ConvertedValueUnitsSelector = new AngleUnitsSelector() { Units = ConvertedValueUnits, UnitsName = "degrees" };
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
            ValueUnitsOptions = new ObservableCollection<AngleUnitsSelector>()
            {
                new AngleUnitsSelector() { Units = AngleUnits.Degrees, UnitsName = "degrees" },
                new AngleUnitsSelector() { Units =AngleUnits.Radians, UnitsName = "radians" }
            };

            var defaultUnits = _settingsService.GetDefaultAngleUnits();

            if (ValueUnitsSelector == null)
            {
                ValueUnitsSelector = ValueUnitsOptions.FirstOrDefault(o => o.Units == defaultUnits);
            }
        }
    }
}
