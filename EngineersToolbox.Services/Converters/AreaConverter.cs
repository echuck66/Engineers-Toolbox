using EngineersToolbox.Models;
using EngineersToolbox.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    convertedValue = value * 10M;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * 1000M;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value * 1000000M;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * 25.4M;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * 304.8M;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * 914.4M;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * 1609344M;
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
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * 10M;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value * 1000M;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * 25.4M;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * 304.8M;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * 914.4M;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * 1609344M;
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
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value * 10M;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * 25.4M;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * 304.8M;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * 914.4M;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * 1609344M;
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
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value * 25.4M;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * 304.8M;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * 914.4M;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * 1609344M;
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
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value * 304.8M;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * 914.4M;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * 1609344M;
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
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value * 914.4M;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * 1609344M;
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
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * 1609344M;
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
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value * 1609344M;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * 1609344M;
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
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value * 1609344M;
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
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMile:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareYard:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareFoot:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMillimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareCentimeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareMeter:
                    convertedValue = value;
                    break;
                case AreaUnits.SquareKilometer:
                    convertedValue = value;
                    break;
                case AreaUnits.Hectare:
                    convertedValue = value;
                    break;
                case AreaUnits.Acre:
                    convertedValue = value;
                    break;
            }

            return convertedValue;
        }

    }
}
