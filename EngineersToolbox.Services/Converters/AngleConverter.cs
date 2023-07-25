using EngineersToolbox.Models;
using EngineersToolbox.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Services.Converters
{
    public class AngleConverter : IConverter
    {
        private ToolType _toolType;
        public ToolType ToolType { get { return _toolType; } }

        private ConverterType _convertType;
        public ConverterType ConverterType { get { return _convertType; } }
        public AngleConverter()
        {
            _toolType = ToolType.Converter;
            _convertType = ConverterType.Angle;
        }

        public decimal GetDegrees(decimal radians)
        {
            double dblRadians = Convert.ToDouble(radians);
            double degrees = (180 / Math.PI) * dblRadians;

            return Convert.ToDecimal(degrees);
        }

        public decimal GetRadians(decimal degrees)
        {
            double dblDegrees = Convert.ToDouble(degrees);
            double radians = (Math.PI / 180) * dblDegrees;

            return Convert.ToDecimal(radians);
        }
    }
}
