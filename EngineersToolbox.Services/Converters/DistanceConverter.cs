using EngineersToolbox.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Services.Converters
{
    public class DistanceConverter : IConverter
    {
        private ToolType _toolType;
        public ToolType ToolType { get { return _toolType; } }

        private ConverterType _convertType;
        public ConverterType ConverterType { get { return _convertType; } }

        public DistanceConverter()
        {
            _toolType = ToolType.Converter;
            _convertType = ConverterType.Distance;
        }

        public decimal GetMillimeters(decimal value, DistanceUnits units)
        {
            decimal millimeters = 0;
            switch(units)
            {
                case DistanceUnits.Millimeter:
                    millimeters = value;
                    break;
                case DistanceUnits.Centimeter:
                    millimeters = value * 10M;
                    break;
                case DistanceUnits.Meter:
                    millimeters = value * 1000M;
                    break;
                case DistanceUnits.Kilometer:
                    millimeters = value * 1000000M;
                    break;
                case DistanceUnits.Inch:
                    millimeters = value * 25.4M;
                    break;
                case DistanceUnits.Foot:
                    millimeters = value * 304.8M;
                    break;
                case DistanceUnits.Yard:
                    millimeters = value * 914.4M;
                    break;
                case DistanceUnits.Mile:
                    millimeters = value * 1609344M;
                    break;
            }
            return millimeters;
        }

        public decimal GetCentimeters(decimal value, DistanceUnits units)
        {
            decimal centimeters = 0;
            switch (units)
            {
                case DistanceUnits.Millimeter:
                    centimeters = value / 10M;
                    break;
                case DistanceUnits.Centimeter:
                    centimeters = value;
                    break;
                case DistanceUnits.Meter:
                    centimeters = value * 100M;
                    break;
                case DistanceUnits.Kilometer:
                    var meters = value * 1000M;
                    centimeters = meters * 100M;
                    break;
                case DistanceUnits.Inch:
                    centimeters = value * 2.54M;
                    break;
                case DistanceUnits.Foot:
                    centimeters = value * 30.48M;
                    break;
                case DistanceUnits.Yard:
                    centimeters = value * 91.44M;
                    break;
                case DistanceUnits.Mile:
                    centimeters = value * 160934.4M;
                    break;
            }
            return centimeters;
        }

        public decimal GetMeters(decimal value, DistanceUnits units)
        {
            decimal meters = 0;
            switch (units)
            {
                case DistanceUnits.Millimeter:
                    meters = value / 1000M;
                    break;
                case DistanceUnits.Centimeter:
                    meters = value / 100M;
                    break;
                case DistanceUnits.Meter:
                    meters = value;
                    break;
                case DistanceUnits.Kilometer:
                    meters = value * 1000M;
                    break;
                case DistanceUnits.Inch:
                    meters = value * 0.0254M;
                    break;
                case DistanceUnits.Foot:
                    meters = value * 0.3048M;
                    break;
                case DistanceUnits.Yard:
                    meters = value * 0.9144M;
                    break;
                case DistanceUnits.Mile:
                    meters = value * 1609.344M;
                    break;
            }
            return meters;
        }

        public decimal GetKilometers(decimal value, DistanceUnits units)
        {
            decimal kilometers = 0;
            switch (units)
            {
                case DistanceUnits.Millimeter:
                    kilometers = value / 1000000M;
                    break;
                case DistanceUnits.Centimeter:
                    kilometers = value / 100000M;
                    break;
                case DistanceUnits.Meter:
                    kilometers = value / 1000M;
                    break;
                case DistanceUnits.Kilometer:
                    kilometers = value;
                    break;
                case DistanceUnits.Inch:
                    kilometers = value * 0.0000254M;
                    break;
                case DistanceUnits.Foot:
                    kilometers = value * 0.0003048M;
                    break;
                case DistanceUnits.Yard:
                    kilometers = value * 0.0009144M;
                    break;
                case DistanceUnits.Mile:
                    kilometers = value * 1.609344M;
                    break;
            }
            return kilometers;
        }

        public decimal GetInches(decimal value, DistanceUnits units)
        {
            decimal inches = 0;
            switch (units)
            {
                case DistanceUnits.Millimeter:
                    inches = value * 0.03937008M;
                    break;
                case DistanceUnits.Centimeter:
                    inches = value * 0.39370079M;
                    break;
                case DistanceUnits.Meter:
                    inches = value * 39.3700787M;
                    break;
                case DistanceUnits.Kilometer:
                    inches = value * 39370.0787M;
                    break;
                case DistanceUnits.Inch:
                    inches = value;
                    break;
                case DistanceUnits.Foot:
                    inches = value * 12M;
                    break;
                case DistanceUnits.Yard:
                    inches = value * 36M;
                    break;
                case DistanceUnits.Mile:
                    inches = value * 12M * 5280M;
                    break;
            }
            return inches;
        }

        public decimal GetFeet(decimal value, DistanceUnits units)
        {
            decimal feet = 0;
            switch (units)
            {
                case DistanceUnits.Millimeter:
                    feet = value * 0.00328084M;
                    break;
                case DistanceUnits.Centimeter:
                    feet = value * 0.0328084M;
                    break;
                case DistanceUnits.Meter:
                    feet = value * 3.2808399M;
                    break;
                case DistanceUnits.Kilometer:
                    feet = value * 3280.8399M;
                    break;
                case DistanceUnits.Inch:
                    feet = value / 12M;
                    break;
                case DistanceUnits.Foot:
                    feet = value;
                    break;
                case DistanceUnits.Yard:
                    feet = value * 3M;
                    break;
                case DistanceUnits.Mile:
                    feet = value * 5280M;
                    break;
            }
            return feet;
        }

        public decimal GetYards(decimal value, DistanceUnits units)
        {
            decimal yards = 0;
            switch (units)
            {
                case DistanceUnits.Millimeter:
                    yards = value * 0.00109361M;
                    break;
                case DistanceUnits.Centimeter:
                    yards = value * 0.01093613M;
                    break;
                case DistanceUnits.Meter:
                    yards = value * 1.0936133M;
                    break;
                case DistanceUnits.Kilometer:
                    yards = value * 1093.6133M;
                    break;
                case DistanceUnits.Inch:
                    yards = value / 36M;
                    break;
                case DistanceUnits.Foot:
                    yards = value / 3M;
                    break;
                case DistanceUnits.Yard:
                    yards = value;
                    break;
                case DistanceUnits.Mile:
                    yards = value * 1760M;
                    break;
            }
            return yards;
        }

        public decimal GetMiles(decimal value, DistanceUnits units)
        {
            decimal miles = 0;
            switch (units)
            {
                case DistanceUnits.Millimeter:
                    miles = value * 0.00000062137M;
                    break;
                case DistanceUnits.Centimeter:
                    miles = value * 0.00000621M;
                    break;
                case DistanceUnits.Meter:
                    miles = value * 0.00062137M;
                    break;
                case DistanceUnits.Kilometer:
                    miles = value * 0.62137119M;
                    break;
                case DistanceUnits.Inch:
                    miles = value / 12M / 5280M;
                    break;
                case DistanceUnits.Foot:
                    miles = value / 5280M;
                    break;
                case DistanceUnits.Yard:
                    miles = value / 3M / 5280M;
                    break;
                case DistanceUnits.Mile:
                    miles = value;
                    break;
            }
            return miles;
        }

    }
}
