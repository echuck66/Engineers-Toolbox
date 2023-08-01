using EngineersToolbox.Models.Enums;
using EngineersToolbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Services.Converters
{
    public class VolumeConverter : IConverter
    {
        private ToolType _toolType;
        public ToolType ToolType { get { return _toolType; } }

        private ConverterType _convertType;
        public ConverterType ConverterType { get { return _convertType; } }
        public VolumeConverter()
        {
            _toolType = ToolType.Converter;
            _convertType = ConverterType.Volume;
        }

        public decimal GetPints(decimal value, VolumeUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case VolumeUnits.Pint:
                    convertedValue = value;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value * ConversionConstants.QUART_TO_PINT_FACTOR;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value * ConversionConstants.GALLON_TO_PINT_FACTOR;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value * ConversionConstants.CUBICINCH_TO_PINT_FACTOR;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value * ConversionConstants.CUBICFOOT_TO_PINT_FACTOR;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value * ConversionConstants.CUBICYARD_TO_PINT_FACTOR;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value * ConversionConstants.MILLILITER_TO_PINT_FACTOR;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value * ConversionConstants.LITER_TO_PINT_FACTOR;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value * ConversionConstants.CUBICCENTIMETER_TO_PINT_FACTOR;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value * ConversionConstants.CUBICMETER_TO_PINT_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetQuarts(decimal value, VolumeUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case VolumeUnits.Pint:
                    convertedValue = value * ConversionConstants.PINT_TO_QUART_FACTOR;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value * ConversionConstants.GALLON_TO_QUART_FACTOR;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value * ConversionConstants.CUBICINCH_TO_QUART_FACTOR;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value * ConversionConstants.CUBICFOOT_TO_QUART_FACTOR;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value * ConversionConstants.CUBICYARD_TO_QUART_FACTOR;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value * ConversionConstants.MILLILITER_TO_QUART_FACTOR;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value * ConversionConstants.LITER_TO_QUART_FACTOR;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value * ConversionConstants.CUBICCENTIMETER_TO_QUART_FACTOR;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value * ConversionConstants.CUBICMETER_TO_QUART_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetGallons(decimal value, VolumeUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case VolumeUnits.Pint:
                    convertedValue = value * ConversionConstants.PINT_TO_GALLON_FACTOR;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value * ConversionConstants.QUART_TO_GALLON_FACTOR;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value * ConversionConstants.CUBICINCH_TO_GALLON_FACTOR;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value * ConversionConstants.CUBICFOOT_TO_GALLON_FACTOR;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value * ConversionConstants.CUBICYARD_TO_GALLON_FACTOR;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value * ConversionConstants.MILLILITER_TO_GALLON_FACTOR;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value * ConversionConstants.LITER_TO_GALLON_FACTOR;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value * ConversionConstants.CUBICCENTIMETER_TO_GALLON_FACTOR;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value * ConversionConstants.CUBICMETER_TO_GALLON_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetCubicInches(decimal value, VolumeUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case VolumeUnits.Pint:
                    convertedValue = value * ConversionConstants.PINT_TO_CUBICINCH_FACTOR;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value * ConversionConstants.QUART_TO_CUBICINCH_FACTOR;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value * ConversionConstants.GALLON_TO_CUBICINCH_FACTOR;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value * ConversionConstants.CUBICFOOT_TO_CUBICINCH_FACTOR;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value * ConversionConstants.CUBICYARD_TO_CUBICINCH_FACTOR;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value * ConversionConstants.MILLILITER_TO_CUBICINCH_FACTOR;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value * ConversionConstants.LITER_TO_CUBICINCH_FACTOR;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value * ConversionConstants.CUBICCENTIMETER_TO_CUBICINCH_FACTOR;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value * ConversionConstants.CUBICMETER_TO_CUBICINCH_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetCubicFeet(decimal value, VolumeUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case VolumeUnits.Pint:
                    convertedValue = value * ConversionConstants.PINT_TO_CUBICFOOT_FACTOR;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value * ConversionConstants.QUART_TO_CUBICFOOT_FACTOR;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value * ConversionConstants.GALLON_TO_CUBICFOOT_FACTOR;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value * ConversionConstants.CUBICINCH_TO_CUBICFOOT_FACTOR;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value * ConversionConstants.CUBICYARD_TO_CUBICFOOT_FACTOR;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value * ConversionConstants.MILLILITER_TO_CUBICFOOT_FACTOR;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value * ConversionConstants.LITER_TO_CUBICFOOT_FACTOR;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value * ConversionConstants.CUBICCENTIMETER_TO_CUBICFOOT_FACTOR;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value * ConversionConstants.CUBICMETER_TO_CUBICFOOT_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetCubicYards(decimal value, VolumeUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case VolumeUnits.Pint:
                    convertedValue = value * ConversionConstants.PINT_TO_CUBICYARD_FACTOR;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value * ConversionConstants.QUART_TO_CUBICYARD_FACTOR;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value * ConversionConstants.GALLON_TO_CUBICYARD_FACTOR;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value * ConversionConstants.CUBICINCH_TO_CUBICYARD_FACTOR;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value * ConversionConstants.CUBICFOOT_TO_CUBICYARD_FACTOR;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value * ConversionConstants.MILLILITER_TO_CUBICYARD_FACTOR;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value * ConversionConstants.LITER_TO_CUBICYARD_FACTOR;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value * ConversionConstants.CUBICCENTIMETER_TO_CUBICYARD_FACTOR;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value * ConversionConstants.CUBICMETER_TO_CUBICYARD_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetMilliliters(decimal value, VolumeUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case VolumeUnits.Pint:
                    convertedValue = value * ConversionConstants.PINT_TO_MILLILITER_FACTOR;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value * ConversionConstants.QUART_TO_MILLILITER_FACTOR;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value * ConversionConstants.GALLON_TO_MILLILITER_FACTOR;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value * ConversionConstants.CUBICINCH_TO_MILLILITER_FACTOR;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value * ConversionConstants.CUBICFOOT_TO_MILLILITER_FACTOR;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value * ConversionConstants.CUBICYARD_TO_MILLILITER_FACTOR;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value * ConversionConstants.LITER_TO_MILLILITER_FACTOR;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value * ConversionConstants.CUBICCENTIMETER_TO_LITER_FACTOR;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value * ConversionConstants.CUBICMETER_TO_LITER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetLiters(decimal value, VolumeUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case VolumeUnits.Pint:
                    convertedValue = value * ConversionConstants.PINT_TO_LITER_FACTOR;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value * ConversionConstants.QUART_TO_LITER_FACTOR;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value * ConversionConstants.GALLON_TO_LITER_FACTOR;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value * ConversionConstants.CUBICINCH_TO_LITER_FACTOR;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value * ConversionConstants.CUBICFOOT_TO_LITER_FACTOR;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value * ConversionConstants.CUBICYARD_TO_LITER_FACTOR;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value * ConversionConstants.MILLILITER_TO_LITER_FACTOR;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value * ConversionConstants.CUBICCENTIMETER_TO_LITER_FACTOR;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value * ConversionConstants.CUBICMETER_TO_LITER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetCubicCentimeters(decimal value, VolumeUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case VolumeUnits.Pint:
                    convertedValue = value * ConversionConstants.PINT_TO_CUBICCENTIMETER_FACTOR;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value * ConversionConstants.QUART_TO_CUBICCENTIMETER_FACTOR;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value * ConversionConstants.GALLON_TO_CUBICCENTIMETER_FACTOR;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value * ConversionConstants.CUBICINCH_TO_CUBICCENTIMETER_FACTOR;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value * ConversionConstants.CUBICFOOT_TO_CUBICCENTIMETER_FACTOR;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value * ConversionConstants.CUBICYARD_TO_CUBICCENTIMETER_FACTOR;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value * ConversionConstants.MILLILITER_TO_CUBICCENTIMETER_FACTOR;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value * ConversionConstants.LITER_TO_CUBICCENTIMETER_FACTOR;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value * ConversionConstants.CUBICMETER_TO_CUBICCENTIMETER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetCubicMeters(decimal value, VolumeUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case VolumeUnits.Pint:
                    convertedValue = value * ConversionConstants.PINT_TO_CUBICMETER_FACTOR;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value * ConversionConstants.QUART_TO_CUBICMETER_FACTOR;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value * ConversionConstants.GALLON_TO_CUBICMETER_FACTOR;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value * ConversionConstants.CUBICINCH_TO_CUBICMETER_FACTOR;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value * ConversionConstants.CUBICFOOT_TO_CUBICMETER_FACTOR;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value * ConversionConstants.CUBICYARD_TO_CUBICMETER_FACTOR;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value * ConversionConstants.MILLILITER_TO_CUBICMETER_FACTOR;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value * ConversionConstants.LITER_TO_CUBICMETER_FACTOR;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value * ConversionConstants.CUBICCENTIMETER_TO_CUBICMETER_FACTOR;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
                    break;
            }

            return convertedValue;
        }


    }
}
