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
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case VolumeUnits.Quart:
                    convertedValue = value;
                    break;
                case VolumeUnits.Gallon:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicInch:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicFoot:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicYard:
                    convertedValue = value;
                    break;
                case VolumeUnits.Milliliter:
                    convertedValue = value;
                    break;
                case VolumeUnits.Liter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicCentimeter:
                    convertedValue = value;
                    break;
                case VolumeUnits.CubicMeter:
                    convertedValue = value;
                    break;
            }

            return convertedValue;
        }


    }
}
