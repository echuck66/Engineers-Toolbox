using EngineersToolbox.Models;
using EngineersToolbox.Models.Enums;
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
                    millimeters = value * ConversionConstants.CENTIMETER_TO_MILLIMETER_FACTOR;
                    break;
                case DistanceUnits.Meter:
                    millimeters = value * ConversionConstants.METER_TO_MILLIMETER_FACTOR;
                    break;
                case DistanceUnits.Kilometer:
                    millimeters = value * ConversionConstants.KILOMETER_TO_MILLIMETER_FACTOR;
                    break;
                case DistanceUnits.Inch:
                    millimeters = value * ConversionConstants.INCH_TO_MILLIMETER_FACTOR;
                    break;
                case DistanceUnits.Foot:
                    millimeters = value * ConversionConstants.FOOT_TO_MILLIMETER_FACTOR;
                    break;
                case DistanceUnits.Yard:
                    millimeters = value * ConversionConstants.YARD_TO_MILLIMETER_FACTOR;
                    break;
                case DistanceUnits.Mile:
                    millimeters = value * ConversionConstants.MILE_TO_MILLIMETER_FACTOR;
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
                    centimeters = value * ConversionConstants.MILLIMETER_TO_CENTIMETER_FACTOR;
                    break;
                case DistanceUnits.Centimeter:
                    centimeters = value;
                    break;
                case DistanceUnits.Meter:
                    centimeters = value * ConversionConstants.METER_TO_CENTIMETER_FACTOR;
                    break;
                case DistanceUnits.Kilometer:
                    centimeters = value * ConversionConstants.KILOMETER_TO_CENTIMETER_FACTOR;
                    break;
                case DistanceUnits.Inch:
                    centimeters = value * ConversionConstants.INCH_TO_CENTIMETER_FACTOR;
                    break;
                case DistanceUnits.Foot:
                    centimeters = value * ConversionConstants.FOOT_TO_CENTIMETER_FACTOR;
                    break;
                case DistanceUnits.Yard:
                    centimeters = value * ConversionConstants.YARD_TO_CENTIMETER_FACTOR;
                    break;
                case DistanceUnits.Mile:
                    centimeters = value * ConversionConstants.MILE_TO_CENTIMETER_FACTOR;
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
                    meters = value * ConversionConstants.MILLIMETER_TO_METER_FACTOR;
                    break;
                case DistanceUnits.Centimeter:
                    meters = value * ConversionConstants.CENTIMETER_TO_METER_FACTOR;
                    break;
                case DistanceUnits.Meter:
                    meters = value;
                    break;
                case DistanceUnits.Kilometer:
                    meters = value * ConversionConstants.KILOMETER_TO_METER_FACTOR;
                    break;
                case DistanceUnits.Inch:
                    meters = value * ConversionConstants.INCH_TO_METER_FACTOR;
                    break;
                case DistanceUnits.Foot:
                    meters = value * ConversionConstants.FOOT_TO_METER_FACTOR;
                    break;
                case DistanceUnits.Yard:
                    meters = value * ConversionConstants.YARD_TO_METER_FACTOR;
                    break;
                case DistanceUnits.Mile:
                    meters = value * ConversionConstants.MILE_TO_METER_FACTOR;
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
                    kilometers = value * ConversionConstants.MILLIMETER_TO_KILOMETER_FACTOR;
                    break;
                case DistanceUnits.Centimeter:
                    kilometers = value * ConversionConstants.CENTIMETER_TO_KILOMETER_FACTOR;
                    break;
                case DistanceUnits.Meter:
                    kilometers = value * ConversionConstants.METER_TO_KILOMETER_FACTOR;
                    break;
                case DistanceUnits.Kilometer:
                    kilometers = value;
                    break;
                case DistanceUnits.Inch:
                    kilometers = value * ConversionConstants.INCH_TO_KILOMETER_FACTOR;
                    break;
                case DistanceUnits.Foot:
                    kilometers = value * ConversionConstants.FOOT_TO_KILOMETER_FACTOR;
                    break;
                case DistanceUnits.Yard:
                    kilometers = value * ConversionConstants.YARD_TO_KILOMETER_FACTOR;
                    break;
                case DistanceUnits.Mile:
                    kilometers = value * ConversionConstants.MILE_TO_KILOMETER_FACTOR;
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
                    inches = value * ConversionConstants.MILLIMETER_TO_INCH_FACTOR;
                    break;
                case DistanceUnits.Centimeter:
                    inches = value * ConversionConstants.CENTIMETER_TO_INCH_FACTOR;
                    break;
                case DistanceUnits.Meter:
                    inches = value * ConversionConstants.METER_TO_INCH_FACTOR;
                    break;
                case DistanceUnits.Kilometer:
                    inches = value * ConversionConstants.KILOMETER_TO_INCH_FACTOR;
                    break;
                case DistanceUnits.Inch:
                    inches = value;
                    break;
                case DistanceUnits.Foot:
                    inches = value * ConversionConstants.FOOT_TO_INCH_FACTOR;
                    break;
                case DistanceUnits.Yard:
                    inches = value * ConversionConstants.YARD_TO_INCH_FACTOR;
                    break;
                case DistanceUnits.Mile:
                    inches = value * ConversionConstants.MILE_TO_INCH_FACTOR;
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
                    feet = value * ConversionConstants.MILLIMETER_TO_FOOT_FACTOR;
                    break;
                case DistanceUnits.Centimeter:
                    feet = value * ConversionConstants.CENTIMETER_TO_FOOT_FACTOR;
                    break;
                case DistanceUnits.Meter:
                    feet = value * ConversionConstants.METER_TO_FOOT_FACTOR;
                    break;
                case DistanceUnits.Kilometer:
                    feet = value * ConversionConstants.KILOMETER_TO_FOOT_FACTOR;
                    break;
                case DistanceUnits.Inch:
                    feet = value * ConversionConstants.INCH_TO_FOOT_FACTOR;
                    break;
                case DistanceUnits.Foot:
                    feet = value;
                    break;
                case DistanceUnits.Yard:
                    feet = value * ConversionConstants.YARD_TO_FOOT_FACTOR;
                    break;
                case DistanceUnits.Mile:
                    feet = value * ConversionConstants.MILE_TO_FOOT_FACTOR;
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
                    yards = value * ConversionConstants.MILLIMETER_TO_YARD_FACTOR;
                    break;
                case DistanceUnits.Centimeter:
                    yards = value * ConversionConstants.CENTIMETER_TO_YARD_FACTOR;
                    break;
                case DistanceUnits.Meter:
                    yards = value * ConversionConstants.METER_TO_YARD_FACTOR;
                    break;
                case DistanceUnits.Kilometer:
                    yards = value * ConversionConstants.KILOMETER_TO_YARD_FACTOR;
                    break;
                case DistanceUnits.Inch:
                    yards = value * ConversionConstants.INCH_TO_YARD_FACTOR;
                    break;
                case DistanceUnits.Foot:
                    yards = value * ConversionConstants.FOOT_TO_YARD_FACTOR;
                    break;
                case DistanceUnits.Yard:
                    yards = value;
                    break;
                case DistanceUnits.Mile:
                    yards = value * ConversionConstants.MILE_TO_YARD_FACTOR;
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
                    miles = value * ConversionConstants.MILLIMETER_TO_MILE_FACTOR;
                    break;
                case DistanceUnits.Centimeter:
                    miles = value * ConversionConstants.CENTIMETER_TO_MILE_FACTOR;
                    break;
                case DistanceUnits.Meter:
                    miles = value * ConversionConstants.METER_TO_MILE_FACTOR;
                    break;
                case DistanceUnits.Kilometer:
                    miles = value * ConversionConstants.KILOMETER_TO_MILE_FACTOR;
                    break;
                case DistanceUnits.Inch:
                    miles = value * ConversionConstants.INCH_TO_MILE_FACTOR;
                    break;
                case DistanceUnits.Foot:
                    miles = value * ConversionConstants.FOOT_TO_MILE_FACTOR;
                    break;
                case DistanceUnits.Yard:
                    miles = value * ConversionConstants.YARD_TO_MILE_FACTOR;
                    break;
                case DistanceUnits.Mile:
                    miles = value;
                    break;
            }
            return miles;
        }

    }
}
