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
                    convertedValue = value;
                    break;
                case MassUnits.Ton:
                    convertedValue = value;
                    break;
                case MassUnits.Pound:
                    convertedValue = value;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value;
                    break;
                case MassUnits.Ton:
                    convertedValue = value;
                    break;
                case MassUnits.Pound:
                    convertedValue = value;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value;
                    break;

            }

            return convertedValue;
        }

        public decimal GetTons(decimal value, MassUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case MassUnits.Gram:
                    convertedValue = value;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value;
                    break;
                case MassUnits.Ton:
                    convertedValue = value;
                    break;
                case MassUnits.Pound:
                    convertedValue = value;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value;
                    break;
                case MassUnits.Ton:
                    convertedValue = value;
                    break;
                case MassUnits.Pound:
                    convertedValue = value;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value;
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
                    convertedValue = value;
                    break;
                case MassUnits.Kilogram:
                    convertedValue = value;
                    break;
                case MassUnits.Ton:
                    convertedValue = value;
                    break;
                case MassUnits.Pound:
                    convertedValue = value;
                    break;
                case MassUnits.Ounce:
                    convertedValue = value;
                    break;

            }

            return convertedValue;
        }


    }
}
