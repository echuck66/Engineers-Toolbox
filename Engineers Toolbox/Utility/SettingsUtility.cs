
using Preferences = Microsoft.Maui.Storage.Preferences;

namespace EngineersToolbox.Utility
{
    internal class SettingsUtility
    {

        public Models.Enums.DistanceUnits GetDefaultDistanceUnits()
        {
            string prefKey = "DEFAULT_DISTANCE_UNITS";
            Models.Enums.DistanceUnits defaultUnits = Models.Enums.DistanceUnits.Foot;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;

        }
        public Models.Enums.DistanceUnits GetDefaultDistanceConversionUnits()
        {
            string prefKey = "DEFAULT_DISTANCE_CONVERSION_UNITS";
            Models.Enums.DistanceUnits defaultUnits = Models.Enums.DistanceUnits.Meter;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;
        }
        public Models.Enums.AreaUnits GetDefaultAreaUnits()
        {
            string prefKey = "DEFAULT_AREA_UNITS";
            Models.Enums.AreaUnits defaultUnits = Models.Enums.AreaUnits.SquareFoot;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;

        }
        public Models.Enums.AreaUnits GetDefaultAreaConversionUnits()
        {
            string prefKey = "DEFAULT_AREA_CONVERSION_UNITS";
            Models.Enums.AreaUnits defaultUnits = Models.Enums.AreaUnits.SquareMeter;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;
        }
        public Models.Enums.VolumeUnits GetDefaultVolumeUnits()
        {
            string prefKey = "DEFAULT_VOLUME_UNITS";
            Models.Enums.VolumeUnits defaultUnits = Models.Enums.VolumeUnits.CubicFoot;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;
        }
        public Models.Enums.VolumeUnits GetDefaultVolumeConversionUnits()
        {
            string prefKey = "DEFAULT_VOLUME_CONVERSION_UNITS";
            Models.Enums.VolumeUnits defaultUnits = Models.Enums.VolumeUnits.CubicMeter;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;
        }
        public Models.Enums.PressureUnits GetDefaultPressureUnits()
        {
            string prefKey = "DEFAULT_PRESSURE_UNITS";
            Models.Enums.PressureUnits defaultUnits = Models.Enums.PressureUnits.psi;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;
        }
        public Models.Enums.PressureUnits GetDefaultPressureConversionUnits()
        {
            string prefKey = "DEFAULT_PRESSURE_CONVERSION_UNITS";
            Models.Enums.PressureUnits defaultUnits = Models.Enums.PressureUnits.Pascal;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;
        }
        public Models.Enums.MassUnits GetDefaultMassUnits()
        {
            string prefKey = "DEFAULT_MASS_UNITS";
            Models.Enums.MassUnits defaultUnits = Models.Enums.MassUnits.Pound;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;
        }
        public Models.Enums.MassUnits GetDefaultMassConversionUnits()
        {
            string prefKey = "DEFAULT_MASS_CONVERSION_UNITS";
            Models.Enums.MassUnits defaultUnits = Models.Enums.MassUnits.Kilogram;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;
        }
        public Models.Enums.AngleUnits GetDefaultAngleUnits()
        {
            string prefKey = "DEFAULT_ANGLE_UNITS";
            Models.Enums.AngleUnits defaultUnits = Models.Enums.AngleUnits.Degrees;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;
        }
        public Models.Enums.AngleUnits GetDefaultAngleConversionUnits()
        {
            string prefKey = "DEFAULT_ANGLE_CONVERSION_UNITS";
            Models.Enums.AngleUnits defaultUnits = Models.Enums.AngleUnits.Radians;
            var unitsStr = Preferences.Get(prefKey, defaultUnits.ToString());

            Enum.TryParse(unitsStr, false, out defaultUnits);

            return defaultUnits;
        }

        public void SetDefaultDistanceUnits(Models.Enums.DistanceUnits units)
        {
            string prefKey = "DEFAULT_DISTANCE_UNITS";
            Models.Enums.DistanceUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultDistanceConversionUnits(Models.Enums.DistanceUnits units)
        {
            string prefKey = "DEFAULT_DISTANCE_CONVERSION_UNITS";
            Models.Enums.DistanceUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultAreaUnits(Models.Enums.AreaUnits units)
        {
            string prefKey = "DEFAULT_AREA_UNITS";
            Models.Enums.AreaUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultAreaConversionUnits(Models.Enums.AreaUnits units)
        {
            string prefKey = "DEFAULT_AREA_CONVERSION_UNITS";
            Models.Enums.AreaUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultVolumeUnits(Models.Enums.VolumeUnits units)
        {
            string prefKey = "DEFAULT_VOLUME_UNITS";
            Models.Enums.VolumeUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultVolumeConversionUnits(Models.Enums.VolumeUnits units)
        {
            string prefKey = "DEFAULT_VOLUME_CONVERSION_UNITS";
            Models.Enums.VolumeUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultPressureUnits(Models.Enums.PressureUnits units)
        {
            string prefKey = "DEFAULT_PRESSURE_UNITS";
            Models.Enums.PressureUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultPressureConversionUnits(Models.Enums.PressureUnits units)
        {
            string prefKey = "DEFAULT_PRESSURE_CONVERSION_UNITS";
            Models.Enums.PressureUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultMassUnits(Models.Enums.MassUnits units)
        {
            string prefKey = "DEFAULT_MASS_UNITS";
            Models.Enums.MassUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultMassConversionUnits(Models.Enums.MassUnits units)
        {
            string prefKey = "DEFAULT_MASS_CONVERSION_UNITS";
            Models.Enums.MassUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultAngleUnits(Models.Enums.AngleUnits units)
        {
            string prefKey = "DEFAULT_ANGLE_UNITS";
            Models.Enums.AngleUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
        public void SetDefaultAngleConversionUnits(Models.Enums.AngleUnits units)
        {
            string prefKey = "DEFAULT_ANGLE_CONVERSION_UNITS";
            Models.Enums.AngleUnits defaultUnits = units;
            Preferences.Set(prefKey, defaultUnits.ToString());
        }
    }
}
