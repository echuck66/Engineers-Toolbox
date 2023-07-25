using EngineersToolbox.Models;
using EngineersToolbox.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Services.Converters
{
    public class NumberBaseConverter : IConverter
    {

        private ToolType _toolType;
        public ToolType ToolType { get { return _toolType; } }

        private ConverterType _convertType;
        public ConverterType ConverterType { get { return _convertType; } }


        public NumberBaseConverter()
        {
            _toolType = ToolType.Converter;
            _convertType = ConverterType.NumberBase;
        }

    }
}
