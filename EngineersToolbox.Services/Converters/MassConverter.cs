using EngineersToolbox.Models;
using EngineersToolbox.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Services.Converters
{
    public class MassConverter : IConverter
    {
        private ToolType _toolType;
        public ToolType ToolType { get { return _toolType; } }

        private ConverterType _convertType;
        public ConverterType ConverterType { get { return _convertType; } }

        public MassConverter()
        {
            _toolType = ToolType.Converter;
            _convertType = ConverterType.Mass;
        }

        public decimal GetGrams(decimal value, MassUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case MassUnits.Gram:
                    convertedValue = value;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value * ConversionConstants.KILOGRAM_TO_GRAM_FACTOR;
                    break;
                case MassUnits.MetricTon:
                    convertedValue = value * ConversionConstants.METRICTON_TO_GRAM_FACTOR;
                    break;
                case MassUnits.USTon:
                    convertedValue = value * ConversionConstants.USTON_TO_GRAM_FACTOR;
                    break;
                case MassUnits.UKTon:
                    convertedValue = value * ConversionConstants.UKTON_TO_GRAM_FACTOR;
                    break;
                case MassUnits.Pound:
                    convertedValue = value * ConversionConstants.POUND_TO_GRAM_FACTOR;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value * ConversionConstants.OUNCE_TO_GRAM_FACTOR;
                    break;
                
            }

            return convertedValue;
        }

        public decimal GetKilograms(decimal value, MassUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case MassUnits.Gram:
                    convertedValue = value * ConversionConstants.GRAM_TO_KILOGRAM_FACTOR;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value;
                    break;
                case MassUnits.MetricTon:
                    convertedValue = value * ConversionConstants.METRICTON_TO_KILOGRAM_FACTOR;
                    break;
                case MassUnits.USTon:
                    convertedValue = value * ConversionConstants.USTON_TO_KILOGRAM_FACTOR;
                    break;
                case MassUnits.UKTon:
                    convertedValue = value * ConversionConstants.UKTON_TO_KILOGRAM_FACTOR;
                    break;
                case MassUnits.Pound:
                    convertedValue = value * ConversionConstants.POUND_TO_KILOGRAM_FACTOR;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value * ConversionConstants.OUNCE_TO_KILOGRAM_FACTOR;
                    break;

            }

            return convertedValue;
        }

        public decimal GetMetricTons(decimal value, MassUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case MassUnits.Gram:
                    convertedValue = value * ConversionConstants.GRAM_TO_METRICTON_FACTOR;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value * ConversionConstants.KILOGRAM_TO_METRICTON_FACTOR;
                    break;
                case MassUnits.MetricTon:
                    convertedValue = value;
                    break;
                case MassUnits.USTon:
                    convertedValue = value * ConversionConstants.USTON_TO_METRICTON_FACTOR;
                    break;
                case MassUnits.UKTon:
                    convertedValue = value * ConversionConstants.UKTON_TO_METRICTON_FACTOR;
                    break;
                case MassUnits.Pound:
                    convertedValue = value * ConversionConstants.POUND_TO_METRICTON_FACTOR;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value * ConversionConstants.OUNCE_TO_METRICTON_FACTOR;
                    break;

            }

            return convertedValue;
        }

        public decimal GetUSTons(decimal value, MassUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case MassUnits.Gram:
                    convertedValue = value * ConversionConstants.GRAM_TO_USTON_FACTOR;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value * ConversionConstants.KILOGRAM_TO_USTON_FACTOR;
                    break;
                case MassUnits.MetricTon:
                    convertedValue = value * ConversionConstants.METRICTON_TO_USTON_FACTOR;
                    break;
                case MassUnits.USTon:
                    convertedValue = value;
                    break;
                case MassUnits.UKTon:
                    convertedValue = value * ConversionConstants.UKTON_TO_USTON_FACTOR;
                    break;
                case MassUnits.Pound:
                    convertedValue = value * ConversionConstants.POUND_TO_USTON_FACTOR;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value * ConversionConstants.OUNCE_TO_USTON_FACTOR;
                    break;

            }

            return convertedValue;
        }

        public decimal GetUKTons(decimal value, MassUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case MassUnits.Gram:
                    convertedValue = value * ConversionConstants.GRAM_TO_UKTON_FACTOR;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value * ConversionConstants.KILOGRAM_TO_UKTON_FACTOR;
                    break;
                case MassUnits.MetricTon:
                    convertedValue = value * ConversionConstants.METRICTON_TO_UKTON_FACTOR;
                    break;
                case MassUnits.USTon:
                    convertedValue = value * ConversionConstants.USTON_TO_UKTON_FACTOR;
                    break;
                case MassUnits.UKTon:
                    convertedValue = value;
                    break;
                case MassUnits.Pound:
                    convertedValue = value * ConversionConstants.POUND_TO_UKTON_FACTOR;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value * ConversionConstants.OUNCE_TO_UKTON_FACTOR;
                    break;

            }

            return convertedValue;
        }

        public decimal GetPounds(decimal value, MassUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case MassUnits.Gram:
                    convertedValue = value * ConversionConstants.GRAM_TO_POUND_FACTOR;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value * ConversionConstants.KILOGRAM_TO_POUND_FACTOR;
                    break;
                case MassUnits.MetricTon:
                    convertedValue = value * ConversionConstants.METRICTON_TO_POUND_FACTOR;
                    break;
                case MassUnits.USTon:
                    convertedValue = value * ConversionConstants.USTON_TO_POUND_FACTOR;
                    break;
                case MassUnits.UKTon:
                    convertedValue = value * ConversionConstants.UKTON_TO_POUND_FACTOR;
                    break;
                case MassUnits.Pound:
                    convertedValue = value;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value * ConversionConstants.OUNCE_TO_POUND_FACTOR;
                    break;

            }

            return convertedValue;
        }

        public decimal GetOunces(decimal value, MassUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case MassUnits.Gram:
                    convertedValue = value * ConversionConstants.GRAM_TO_OUNCE_FACTOR;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value * ConversionConstants.KILOGRAM_TO_OUNCE_FACTOR;
                    break;
                case MassUnits.MetricTon:
                    convertedValue = value * ConversionConstants.METRICTON_TO_OUNCE_FACTOR;
                    break;
                case MassUnits.USTon:
                    convertedValue = value * ConversionConstants.USTON_TO_OUNCE_FACTOR;
                    break;
                case MassUnits.UKTon:
                    convertedValue = value * ConversionConstants.UKTON_TO_OUNCE_FACTOR;
                    break;
                case MassUnits.Pound:
                    convertedValue = value * ConversionConstants.POUND_TO_OUNCE_FACTOR;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value;
                    break;

            }

            return convertedValue;
        }


    }
}
