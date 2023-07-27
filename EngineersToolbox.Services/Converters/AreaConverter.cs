using EngineersToolbox.Models;
using EngineersToolbox.Models.Enums;
using System.Runtime.InteropServices;

namespace EngineersToolbox.Services.Converters
{
    public class AreaConverter : IConverter
    {
        private ToolType _toolType;
        public ToolType ToolType { get { return _toolType; } }
        private ConverterType _convertType;
        public ConverterType ConverterType { get { return _convertType; } }
        public AreaConverter()
        {
            _toolType = ToolType.Converter;
            _convertType = ConverterType.Area;
        }

        public decimal GetSquareInches(decimal value, AreaUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case AreaUnits.SquareInch:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * ConversionConstants.SQUAREMILE_TO_SQUAREINCH_FACTOR;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * ConversionConstants.SQUAREYARD_TO_SQUAREINCH_FACTOR;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value * ConversionConstants.SQUAREFOOT_TO_SQUAREINCH_FACTOR;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * ConversionConstants.SQUAREMILLIMETER_TO_SQUAREINCH_FACTOR;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * ConversionConstants.SQUARECENTIMETER_TO_SQUAREINCH_FACTOR;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * ConversionConstants.SQUAREMETER_TO_SQUAREINCH_FACTOR;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * ConversionConstants.SQUAREKILOMETER_TO_SQUAREINCH_FACTOR;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * ConversionConstants.HECTARE_TO_SQUAREINCH_FACTOR;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * ConversionConstants.ACRE_TO_SQUAREINCH_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetSquareFeet(decimal value, AreaUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case AreaUnits.SquareInch:
                    convertedValue = value * ConversionConstants.SQUAREINCH_TO_SQUAREFOOT_FACTOR;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * ConversionConstants.SQUAREMILE_TO_SQUAREFOOT_FACTOR;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * ConversionConstants.SQUAREYARD_TO_SQUAREFOOT_FACTOR;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * ConversionConstants.SQUAREMILLIMETER_TO_SQUAREFOOT_FACTOR;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * ConversionConstants.SQUARECENTIMETER_TO_SQUAREFOOT_FACTOR;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * ConversionConstants.SQUAREMETER_TO_SQUAREFOOT_FACTOR;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * ConversionConstants.SQUAREKILOMETER_TO_SQUAREFOOT_FACTOR;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * ConversionConstants.HECTARE_TO_SQUAREFOOT_FACTOR;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * ConversionConstants.ACRE_TO_SQUAREFOOT_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetSquareYards(decimal value, AreaUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case AreaUnits.SquareInch:
                    convertedValue = value * ConversionConstants.SQUAREINCH_TO_SQUAREYARD_FACTOR;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * ConversionConstants.SQUAREMILE_TO_SQUAREYARD_FACTOR;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value * ConversionConstants.SQUAREFOOT_TO_SQUAREYARD_FACTOR;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * ConversionConstants.SQUAREMILLIMETER_TO_SQUAREYARD_FACTOR;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * ConversionConstants.SQUARECENTIMETER_TO_SQUAREYARD_FACTOR;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * ConversionConstants.SQUAREMETER_TO_SQUAREYARD_FACTOR;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * ConversionConstants.SQUAREKILOMETER_TO_SQUAREYARD_FACTOR;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * ConversionConstants.HECTARE_TO_SQUAREYARD_FACTOR;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * ConversionConstants.ACRE_TO_SQUAREYARD_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetSquareMiles(decimal value, AreaUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case AreaUnits.SquareInch:
                    convertedValue = value * ConversionConstants.SQUAREINCH_TO_SQUAREMILE_FACTOR;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * ConversionConstants.SQUAREYARD_TO_SQUAREMILE_FACTOR;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value * ConversionConstants.SQUAREFOOT_TO_SQUAREMILE_FACTOR;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * ConversionConstants.SQUAREMILLIMETER_TO_SQUAREMILE_FACTOR;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * ConversionConstants.SQUARECENTIMETER_TO_SQUAREMILE_FACTOR;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * ConversionConstants.SQUAREMETER_TO_SQUAREMILE_FACTOR;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * ConversionConstants.SQUAREKILOMETER_TO_SQUAREMILE_FACTOR;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * ConversionConstants.HECTARE_TO_SQUAREMILE_FACTOR;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * ConversionConstants.ACRE_TO_SQUAREMILE_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetSquareMillimeters(decimal value, AreaUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case AreaUnits.SquareInch:
                    convertedValue = value * ConversionConstants.SQUAREINCH_TO_SQUAREMILLIMETER_FACTOR;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * ConversionConstants.SQUAREMILE_TO_SQUAREMILLIMETER_FACTOR;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * ConversionConstants.SQUAREYARD_TO_SQUAREMILLIMETER_FACTOR;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value * ConversionConstants.SQUAREFOOT_TO_SQUAREMILLIMETER_FACTOR;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * ConversionConstants.SQUARECENTIMETER_TO_SQUAREMILLIMETER_FACTOR;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * ConversionConstants.SQUAREMETER_TO_SQUAREMILLIMETER_FACTOR;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * ConversionConstants.SQUAREKILOMETER_TO_SQUAREMILLIMETER_FACTOR;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * ConversionConstants.HECTARE_TO_SQUAREMILLIMETER_FACTOR;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * ConversionConstants.ACRE_TO_SQUAREMILLIMETER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetSquareCentimeters(decimal value, AreaUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case AreaUnits.SquareInch:
                    convertedValue = value * ConversionConstants.SQUAREINCH_TO_SQUARECENTIMETER_FACTOR;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * ConversionConstants.SQUAREMILE_TO_SQUARECENTIMETER_FACTOR;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * ConversionConstants.SQUAREYARD_TO_SQUARECENTIMETER_FACTOR;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value * ConversionConstants.SQUAREFOOT_TO_SQUARECENTIMETER_FACTOR;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * ConversionConstants.SQUAREMILLIMETER_TO_SQUARECENTIMETER_FACTOR;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * ConversionConstants.SQUAREMETER_TO_SQUARECENTIMETER_FACTOR;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * ConversionConstants.SQUAREKILOMETER_TO_SQUARECENTIMETER_FACTOR;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * ConversionConstants.HECTARE_TO_SQUARECENTIMETER_FACTOR;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * ConversionConstants.ACRE_TO_SQUARECENTIMETER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetSquareMeters(decimal value, AreaUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case AreaUnits.SquareInch:
                    convertedValue = value * ConversionConstants.SQUAREINCH_TO_SQUAREMETER_FACTOR;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * ConversionConstants.SQUAREMILE_TO_SQUAREMETER_FACTOR;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * ConversionConstants.SQUAREYARD_TO_SQUAREMETER_FACTOR;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value * ConversionConstants.SQUAREFOOT_TO_SQUAREMETER_FACTOR;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * ConversionConstants.SQUAREMILLIMETER_TO_SQUAREMETER_FACTOR;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * ConversionConstants.SQUARECENTIMETER_TO_SQUAREMETER_FACTOR;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * ConversionConstants.SQUAREKILOMETER_TO_SQUAREMETER_FACTOR;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * ConversionConstants.HECTARE_TO_SQUAREMETER_FACTOR;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * ConversionConstants.ACRE_TO_SQUAREMETER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetSquareKilometers(decimal value, AreaUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case AreaUnits.SquareInch:
                    convertedValue = value * ConversionConstants.SQUAREINCH_TO_SQUAREKILOMETER_FACTOR;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * ConversionConstants.SQUAREMILE_TO_SQUAREKILOMETER_FACTOR;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * ConversionConstants.SQUAREYARD_TO_SQUAREKILOMETER_FACTOR;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value * ConversionConstants.SQUAREFOOT_TO_SQUAREKILOMETER_FACTOR;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * ConversionConstants.SQUAREFOOT_TO_SQUAREMILLIMETER_FACTOR;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * ConversionConstants.SQUARECENTIMETER_TO_SQUAREKILOMETER_FACTOR;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * ConversionConstants.SQUAREMETER_TO_SQUAREMILLIMETER_FACTOR;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value ;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * ConversionConstants.HECTARE_TO_SQUAREKILOMETER_FACTOR;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * ConversionConstants.ACRE_TO_SQUAREKILOMETER_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetHectare(decimal value, AreaUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case AreaUnits.SquareInch:
                    convertedValue = value * ConversionConstants.SQUAREINCH_TO_HECTARE_FACTOR;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * ConversionConstants.SQUAREMILE_TO_HECTARE_FACTOR;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * ConversionConstants.SQUAREYARD_TO_HECTARE_FACTOR;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value * ConversionConstants.SQUAREFOOT_TO_HECTARE_FACTOR;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * ConversionConstants.SQUAREMILLIMETER_TO_HECTARE_FACTOR;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * ConversionConstants.SQUARECENTIMETER_TO_HECTARE_FACTOR;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * ConversionConstants.SQUAREMETER_TO_HECTARE_FACTOR;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * ConversionConstants.SQUAREKILOMETER_TO_HECTARE_FACTOR;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * ConversionConstants.ACRE_TO_HECTARE_FACTOR;
                    break;
            }

            return convertedValue;
        }

        public decimal GetAcres(decimal value, AreaUnits units)
        {
            decimal convertedValue = 0;
            switch (units)
            {
                case AreaUnits.SquareInch:
                    convertedValue = value * ConversionConstants.SQUAREINCH_TO_ACRE_FACTOR;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * ConversionConstants.SQUAREMILE_TO_ACRE_FACTOR;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * ConversionConstants.SQUAREYARD_TO_ACRE_FACTOR;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value * ConversionConstants.SQUAREFOOT_TO_ACRE_FACTOR;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * ConversionConstants.SQUAREMILLIMETER_TO_ACRE_FACTOR;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * ConversionConstants.SQUARECENTIMETER_TO_ACRE_FACTOR;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * ConversionConstants.SQUAREMETER_TO_ACRE_FACTOR;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * ConversionConstants.SQUAREKILOMETER_TO_ACRE_FACTOR;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value = ConversionConstants.HECTARE_TO_ACRE_FACTOR;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value;
                    break;
            }

            return convertedValue;
        }

    }
}
