using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngineersToolbox.Models.Enums;
using EngineersToolbox.Models.Selectors;
using EngineersToolbox.Utility;
using EngineersToolbox.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace EngineersToolbox.ViewModels
{
    public partial class SettingsViewModel : ToolboxBaseViewModel
    {
        private SettingsUtility _settingsService;

        public SettingsViewModel()
        {
            _settingsService = new SettingsUtility();
            Title = "User Settings";
            Bind();
        }

        private Models.Enums.DistanceUnits defaultDistanceUnits;
        private Models.Enums.DistanceUnits defaultDistanceConversionUnits;
        private Models.Enums.AreaUnits defaultAreaUnits;
        private Models.Enums.AreaUnits defaultAreaConversionUnits;
        private Models.Enums.VolumeUnits defaultVolumeUnits;
        private Models.Enums.VolumeUnits defaultVolumeConversionUnits;
        private Models.Enums.MassUnits defaultMassUnits;
        private Models.Enums.MassUnits defaultMassConversionUnits;
        private Models.Enums.PressureUnits defaultPressureUnits;
        private Models.Enums.PressureUnits defaultPressureConversionUnits;
        private Models.Enums.AngleUnits defaultAngleUnits;
        private Models.Enums.AngleUnits defaultAngleConversionUnits;


        [ObservableProperty]
        private DistanceUnitsSelector defaultDistanceUnitsSelector;
        [ObservableProperty]
        private DistanceUnitsSelector defaultDistanceConversionUnitsSelector;
        [ObservableProperty]
        private AreaUnitsSelector defaultAreaUnitsSelector;
        [ObservableProperty]
        private AreaUnitsSelector defaultAreaConversionUnitsSelector;
        [ObservableProperty]
        private VolumeUnitsSelector defaultVolumeUnitsSelector;
        [ObservableProperty]
        private VolumeUnitsSelector defaultVolumeConversionUnitsSelector;
        [ObservableProperty]
        private MassUnitsSelector defaultMassUnitsSelector;
        [ObservableProperty]
        private MassUnitsSelector defaultMassConversionUnitsSelector;
        [ObservableProperty]
        private PressureUnitsSelector defaultPressureUnitsSelector;
        [ObservableProperty]
        private PressureUnitsSelector defaultPressureConversionUnitsSelector;
        [ObservableProperty]
        private AngleUnitsSelector defaultAngleUnitsSelector;
        [ObservableProperty]
        private AngleUnitsSelector defaultAngleConversionUnitsSelector;


        public ObservableCollection<DistanceUnitsSelector> DistanceUnitsOptions { get; set; }
        public ObservableCollection<DistanceUnitsSelector> DistanceConversionUnitsOptions { get; set; }
        public ObservableCollection<AreaUnitsSelector> AreaUnitsOptions { get; set; }
        public ObservableCollection<AreaUnitsSelector> AreaConversionUnitsOptions { get; set; }
        public ObservableCollection<VolumeUnitsSelector> VolumeUnitsOptions { get; set; }
        public ObservableCollection<VolumeUnitsSelector> VolumeConversionUnitsOptions { get; set; }
        public ObservableCollection<MassUnitsSelector> MassUnitsOptions { get; set; }
        public ObservableCollection<MassUnitsSelector> MassConversionUnitsOptions { get; set; }
        public ObservableCollection<PressureUnitsSelector> PressureUnitsOptions { get; set; }
        public ObservableCollection<PressureUnitsSelector> PressureConversionUnitsOptions { get; set; }
        public ObservableCollection<AngleUnitsSelector> AngleUnitsOptions { get; set; }
        public ObservableCollection<AngleUnitsSelector> AngleConversionUnitsOptions { get; set; }


        [RelayCommand]
        private async Task CloseTool()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                await Shell.Current.GoToAsync(nameof(ToolboxPage));
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

        private void SetDefaultDistanceUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultDistanceUnits(DefaultDistanceUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }


        private void SetDefaultDistanceConversionUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultDistanceConversionUnits(DefaultDistanceConversionUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void SetDefaultAreaUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultAreaUnits(DefaultAreaUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void SetDefaultAreaConversionUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultAreaConversionUnits(DefaultAreaConversionUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void SetDefaultVolumeUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultVolumeUnits(DefaultVolumeUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void SetDefaultVolumeConversionUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultVolumeConversionUnits(DefaultVolumeConversionUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void SetDefaultMassUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultMassUnits(DefaultMassUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void SetDefaultMassConversionUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultMassConversionUnits(DefaultMassConversionUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void SetDefaultPressureUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultPressureUnits(DefaultPressureUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void SetDefaultPressureConversionUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultPressureConversionUnits(DefaultPressureConversionUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void SetDefaultAngleUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultAngleUnits (DefaultAngleUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void SetDefaultAngleConversionUnits()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                _settingsService.SetDefaultAngleConversionUnits(DefaultAngleConversionUnitsSelector.Units);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
                //await AppShell.Alert(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void Bind()
        {
            DistanceUnitsOptions = new ObservableCollection<DistanceUnitsSelector>()
            {
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Inch, UnitsName = "in" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Foot, UnitsName = "ft" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Yard, UnitsName = "yd" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Mile, UnitsName = "mi" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Millimeter, UnitsName = "mm" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Centimeter, UnitsName = "cm" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Meter, UnitsName = "m" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Kilometer, UnitsName = "km" }
            };
            DistanceConversionUnitsOptions = new ObservableCollection<DistanceUnitsSelector>()
            {
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Inch, UnitsName = "in" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Foot, UnitsName = "ft" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Yard, UnitsName = "yd" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Mile, UnitsName = "mi" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Millimeter, UnitsName = "mm" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Centimeter, UnitsName = "cm" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Meter, UnitsName = "m" },
                new DistanceUnitsSelector() { Units = Models.Enums.DistanceUnits.Kilometer, UnitsName = "km" }
            };
            AreaUnitsOptions = new ObservableCollection<AreaUnitsSelector>()
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
            AreaConversionUnitsOptions = new ObservableCollection<AreaUnitsSelector>()
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
            VolumeUnitsOptions = new ObservableCollection<VolumeUnitsSelector>()
            {
                new VolumeUnitsSelector() { Units = VolumeUnits.CubicCentimeter, UnitsName = "cubic cm" },
                new VolumeUnitsSelector() { Units = VolumeUnits.CubicFoot, UnitsName = "cubic ft" },
                new VolumeUnitsSelector() { Units = VolumeUnits.CubicInch, UnitsName = "cubic in" },
                new VolumeUnitsSelector() { Units = VolumeUnits.CubicMeter, UnitsName = "cubic m" },
                new VolumeUnitsSelector() { Units = VolumeUnits.CubicYard, UnitsName = "cubic yd" },
                new VolumeUnitsSelector() { Units = VolumeUnits.Gallon, UnitsName = "gl" },
                new VolumeUnitsSelector() { Units = VolumeUnits.Liter, UnitsName = "l" },
                new VolumeUnitsSelector() { Units = VolumeUnits.Milliliter, UnitsName = "ml" },
                new VolumeUnitsSelector() { Units = VolumeUnits.Pint, UnitsName = "pt" },
                new VolumeUnitsSelector() { Units = VolumeUnits.Quart, UnitsName = "qt" }

            }; 
            VolumeConversionUnitsOptions = new ObservableCollection<VolumeUnitsSelector>()
            {
                new VolumeUnitsSelector() { Units = VolumeUnits.CubicCentimeter, UnitsName = "cubic cm" },
                new VolumeUnitsSelector() { Units = VolumeUnits.CubicFoot, UnitsName = "cubic ft" },
                new VolumeUnitsSelector() { Units = VolumeUnits.CubicInch, UnitsName = "cubic in" },
                new VolumeUnitsSelector() { Units = VolumeUnits.CubicMeter, UnitsName = "cubic m" },
                new VolumeUnitsSelector() { Units = VolumeUnits.CubicYard, UnitsName = "cubic yd" },
                new VolumeUnitsSelector() { Units = VolumeUnits.Gallon, UnitsName = "gl" },
                new VolumeUnitsSelector() { Units = VolumeUnits.Liter, UnitsName = "l" },
                new VolumeUnitsSelector() { Units = VolumeUnits.Milliliter, UnitsName = "ml" },
                new VolumeUnitsSelector() { Units = VolumeUnits.Pint, UnitsName = "pt" },
                new VolumeUnitsSelector() { Units = VolumeUnits.Quart, UnitsName = "qt" }

            };
            MassUnitsOptions = new ObservableCollection<MassUnitsSelector>()
            {
                new MassUnitsSelector() { Units = MassUnits.Milligram, UnitsName = "mg" },
                new MassUnitsSelector() { Units = MassUnits.Gram, UnitsName = "g" },
                new MassUnitsSelector() { Units = MassUnits.Kilogram, UnitsName = "kg" },
                new MassUnitsSelector() { Units = MassUnits.Pound, UnitsName = "lb" },
                new MassUnitsSelector() { Units = MassUnits.MetricTon, UnitsName = "ton (metric)" },
                new MassUnitsSelector() { Units = MassUnits.USTon, UnitsName = "ton (US)" },
                new MassUnitsSelector() { Units = MassUnits.UKTon, UnitsName = "ton (UK)" }

            };
            MassConversionUnitsOptions = new ObservableCollection<MassUnitsSelector>()
            {
                new MassUnitsSelector() { Units = MassUnits.Milligram, UnitsName = "mg" },
                new MassUnitsSelector() { Units = MassUnits.Gram, UnitsName = "g" },
                new MassUnitsSelector() { Units = MassUnits.Kilogram, UnitsName = "kg" },
                new MassUnitsSelector() { Units = MassUnits.Pound, UnitsName = "lb" },
                new MassUnitsSelector() { Units = MassUnits.MetricTon, UnitsName = "ton (metric)" },
                new MassUnitsSelector() { Units = MassUnits.USTon, UnitsName = "ton (US)" },
                new MassUnitsSelector() { Units = MassUnits.UKTon, UnitsName = "ton (UK)" }

            };
            PressureUnitsOptions = new ObservableCollection<PressureUnitsSelector>()
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
            PressureConversionUnitsOptions = new ObservableCollection<PressureUnitsSelector>()
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
            AngleUnitsOptions = new ObservableCollection<AngleUnitsSelector>()
            {
                new AngleUnitsSelector() { Units = AngleUnits.Degrees, UnitsName = "degrees" },
                new AngleUnitsSelector() { Units =AngleUnits.Radians, UnitsName = "radians" }
            };
            AngleConversionUnitsOptions = new ObservableCollection<AngleUnitsSelector>()
            {
                new AngleUnitsSelector() { Units = AngleUnits.Degrees, UnitsName = "degrees" },
                new AngleUnitsSelector() { Units =AngleUnits.Radians, UnitsName = "radians" }
            };
            try
            {
                defaultDistanceUnits = _settingsService.GetDefaultDistanceUnits();
                defaultDistanceConversionUnits = _settingsService.GetDefaultDistanceConversionUnits();
                defaultAreaUnits = _settingsService.GetDefaultAreaUnits();
                defaultAreaConversionUnits = _settingsService.GetDefaultAreaConversionUnits();
                defaultVolumeUnits = _settingsService.GetDefaultVolumeUnits();
                defaultVolumeConversionUnits = _settingsService.GetDefaultVolumeConversionUnits();
                defaultMassUnits = _settingsService.GetDefaultMassUnits();
                defaultMassConversionUnits = _settingsService.GetDefaultMassConversionUnits();
                defaultPressureUnits = _settingsService.GetDefaultPressureUnits();
                defaultPressureConversionUnits = _settingsService.GetDefaultPressureConversionUnits();
                defaultAngleUnits = _settingsService.GetDefaultAngleUnits();
                defaultAngleConversionUnits = _settingsService.GetDefaultAngleConversionUnits();

                DefaultDistanceUnitsSelector = DistanceUnitsOptions.FirstOrDefault(s => s.Units == defaultDistanceUnits);
                DefaultDistanceConversionUnitsSelector = DistanceConversionUnitsOptions.FirstOrDefault(s => s.Units == defaultDistanceConversionUnits);
                DefaultAreaUnitsSelector = AreaUnitsOptions.FirstOrDefault(s => s.Units == defaultAreaUnits);
                DefaultAreaConversionUnitsSelector = AreaConversionUnitsOptions.FirstOrDefault(s => s.Units == defaultAreaConversionUnits);
                DefaultVolumeUnitsSelector = VolumeUnitsOptions.FirstOrDefault(s => s.Units == defaultVolumeUnits);
                DefaultVolumeConversionUnitsSelector = VolumeConversionUnitsOptions.FirstOrDefault(s => s.Units == defaultVolumeConversionUnits);
                DefaultMassUnitsSelector = MassUnitsOptions.FirstOrDefault(s => s.Units == defaultMassUnits);
                DefaultMassConversionUnitsSelector = MassConversionUnitsOptions.FirstOrDefault(s => s.Units == defaultMassConversionUnits);
                DefaultPressureUnitsSelector = PressureUnitsOptions.FirstOrDefault(s => s.Units == defaultPressureUnits);
                DefaultPressureConversionUnitsSelector = PressureConversionUnitsOptions.FirstOrDefault(s => s.Units == defaultPressureConversionUnits);
                DefaultAngleUnitsSelector = AngleUnitsOptions.FirstOrDefault(s => s.Units == defaultAngleUnits);
                DefaultAngleConversionUnitsSelector = AngleConversionUnitsOptions.First(s => s.Units == defaultAngleConversionUnits);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"  {ex.Message}");
            }
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {

            switch (e.PropertyName)
            {
                case nameof(DefaultDistanceUnitsSelector):
                    SetDefaultDistanceUnits();
                    break;
                case nameof(DefaultDistanceConversionUnitsSelector):
                    SetDefaultDistanceConversionUnits();
                    break;
                case nameof(DefaultAreaUnitsSelector):
                    SetDefaultAreaUnits();
                    break;
                case nameof(DefaultAreaConversionUnitsSelector):
                    SetDefaultAreaConversionUnits();
                    break;
                case nameof(DefaultVolumeUnitsSelector):
                    SetDefaultVolumeUnits();
                    break;
                case nameof(DefaultVolumeConversionUnitsSelector):
                    SetDefaultVolumeConversionUnits();
                    break;
                case nameof(DefaultMassUnitsSelector):
                    SetDefaultMassUnits();
                    break;
                case nameof(DefaultMassConversionUnitsSelector):
                    SetDefaultMassConversionUnits();
                    break;
                case nameof(DefaultPressureUnitsSelector):
                    SetDefaultPressureUnits();
                    break;
                case nameof(DefaultPressureConversionUnitsSelector):
                    SetDefaultPressureConversionUnits();
                    break;
                case nameof(DefaultAngleUnitsSelector):
                    SetDefaultAngleUnits();
                    break;
                case nameof(DefaultAngleConversionUnitsSelector):
                    SetDefaultAngleConversionUnits();
                    break;

            }
            base.OnPropertyChanged(e);
        }
    }
}
