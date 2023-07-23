using EngineersToolbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Services.Converters
{
    public class Base64Converter: IConverter
    {
        private ToolType _toolType;
        public ToolType ToolType { get { return _toolType; } }

        private ConverterType _convertType;
        public ConverterType ConverterType {  get { return _convertType; } }

        public Base64Converter()
        {
            _toolType = ToolType.Converter;
            _convertType = ConverterType.Base64;
        }

        public Base64Object HashValue(string? value)
        {
            Base64Object hashObj = new Base64Object()
            {
                Value = value
            };

            if (!string.IsNullOrEmpty(value))
            {
                var valueBytes = System.Text.Encoding.UTF8.GetBytes(value);
                hashObj.HashedValue = System.Convert.ToBase64String(valueBytes);
            }

            return hashObj;
        }

        public Base64Object GetValue(string? hashedValue)
        {
            Base64Object hashObj = new Base64Object()
            {
                HashedValue = hashedValue
            };

            if (!string.IsNullOrEmpty(hashedValue))
            {
                var hashedBytes = System.Convert.FromBase64String(hashedValue);
                hashObj.Value = System.Text.Encoding.UTF8.GetString(hashedBytes);
            }

            return hashObj;
        }
    }
}
