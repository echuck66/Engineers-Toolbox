using EngineersToolbox.Models;
using EngineersToolbox.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Services.Converters
{
    public class PressureConverter : IConverter
    {
        private ToolType _toolType;
        public ToolType ToolType { get { return _toolType; } }

        private ConverterType _convertType;
        public ConverterType ConverterType { get { return _convertType; } }
        public PressureConverter()
        {
            _toolType = ToolType.Converter;
            _convertType = ConverterType.Pressure;
        }

        public decimal GetPascals(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_PASCAL_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_PASCAL_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_PASCAL_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_PASCAL_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_PASCAL_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_PASCAL_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_PASCAL_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_PASCAL_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_PASCAL_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_PASCAL_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_PASCAL_FACTOR;
                    break;
            }
            return convertedValue;

        }

        public decimal GetKiloPascals(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_KILOPASCAL_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_KILOPASCAL_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_KILOPASCAL_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_KILOPASCAL_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_KILOPASCAL_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_KILOPASCAL_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_KILOPASCAL_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_KILOPASCAL_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_KILOPASCAL_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_KILOPASCAL_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetPsi(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_PSI_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_PSI_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_PSI_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_PSI_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_PSI_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_PSI_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_PSI_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_PSI_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_PSI_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value * ConversionConstants.PASCAL_TO_PSI_FACTOR;
                    break;
                case PressureUnits.psi:
                    convertedValue = value;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_PSI_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetKsi(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_KSI_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_KSI_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_KSI_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_KSI_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_KSI_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_KSI_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_KSI_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_KSI_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value * ConversionConstants.PASCAL_TO_KSI_FACTOR;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_KSI_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_KSI_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetAtm(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_ATM_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_ATM_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_ATM_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_ATM_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_ATM_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_ATM_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_ATM_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_ATM_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_ATM_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value * ConversionConstants.PASCAL_TO_ATM_FACTOR;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_ATM_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value;
                    break;
            }

            return convertedValue;
        }

        public decimal GetNewtonMeters(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_NEWTONMETER_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_NEWTONMETER_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_NEWTONMETER_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_NEWTONMETER_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_NEWTONMETER_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_NEWTONMETER_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_NEWTONMETER_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_NEWTONMETER_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value * ConversionConstants.PASCAL_TO_NEWTONMETER_FACTOR;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_NEWTONMETER_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_NEWTONMETER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetNewtonCentiMeters(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_NEWTONCENTIMETER_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_NEWTONCENTIMETER_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_NEWTONCENTIMETER_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_NEWTONCENTIMETER_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_NEWTONCENTIMETER_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_NEWTONCENTIMETER_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_NEWTONCENTIMETER_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_NEWTONCENTIMETER_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value * ConversionConstants.PASCAL_TO_NEWTONCENTIMETER_FACTOR;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_NEWTONCENTIMETER_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_NEWTONCENTIMETER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetNewtonMilliMeters(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_NEWTONMILLIMETER_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_NEWTONMILLIMETER_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_NEWTONMILLIMETER_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_NEWTONMILLIMETER_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_NEWTONMILLIMETER_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_NEWTONMILLIMETER_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_NEWTONMILLIMETER_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_NEWTONMILLIMETER_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value * ConversionConstants.PASCAL_TO_NEWTONMILLIMETER_FACTOR;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_NEWTONMILLIMETER_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_NEWTONMILLIMETER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetKiloNewtonMeters(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_KILONEWTONMETER_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_KILONEWTONMETER_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_KILONEWTONMETER_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_KILONEWTONMETER_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_KILONEWTONMETER_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_KILONEWTONMETER_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_KILONEWTONMETER_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_KILONEWTONMETER_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value * ConversionConstants.PASCAL_TO_KILONEWTONMETER_FACTOR;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_KILONEWTONMETER_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_KILONEWTONMETER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetMicroBars(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_MICROBAR_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_MICROBAR_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_MICROBAR_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_MICROBAR_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_MICROBAR_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_MICROBAR_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_MICROBAR_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_MICROBAR_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value * ConversionConstants.PASCAL_TO_MICROBAR_FACTOR;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_MICROBAR_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_MICROBAR_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetMilliBars(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value * ConversionConstants.BAR_TO_MILLIBAR_FACTOR;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_MILLIBAR_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_MILLIBAR_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_MILLIBAR_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_MILLIBAR_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_MILLIBAR_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_MILLIBAR_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_MILLIBAR_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value * ConversionConstants.PASCAL_TO_MILLIBAR_FACTOR;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_MILLIBAR_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_MILLIBAR_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetBars(decimal value, PressureUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case PressureUnits.Bar:
                    convertedValue = value;
                    break;
                case PressureUnits.KiloNewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.KILONEWTONMETER_TO_BAR_FACTOR;
                    break;
                case PressureUnits.KiloPascal:
                    convertedValue = value * ConversionConstants.KILOPASCAL_TO_BAR_FACTOR;
                    break;
                case PressureUnits.ksi:
                    convertedValue = value * ConversionConstants.KSI_TO_BAR_FACTOR;
                    break;
                case PressureUnits.Microbar:
                    convertedValue = value * ConversionConstants.MICROBAR_TO_BAR_FACTOR;
                    break;
                case PressureUnits.Millibar:
                    convertedValue = value * ConversionConstants.MILLIBAR_TO_BAR_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareCentimeter:
                    convertedValue = value * ConversionConstants.NEWTONCENTIMETER_TO_BAR_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMeter:
                    convertedValue = value * ConversionConstants.NEWTONMETER_TO_BAR_FACTOR;
                    break;
                case PressureUnits.NewtonPerSquareMillimeter:
                    convertedValue = value * ConversionConstants.NEWTONMILLIMETER_TO_BAR_FACTOR;
                    break;
                case PressureUnits.Pascal:
                    convertedValue = value * ConversionConstants.PASCAL_TO_BAR_FACTOR;
                    break;
                case PressureUnits.psi:
                    convertedValue = value * ConversionConstants.PSI_TO_BAR_FACTOR;
                    break;
                case PressureUnits.StandardAtmosphere:
                    convertedValue = value * ConversionConstants.ATM_TO_BAR_FACTOR;
                    break;
            }

            return convertedValue;
        }

    }

}

