using EngineersToolbox.Models;
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
    }
}
