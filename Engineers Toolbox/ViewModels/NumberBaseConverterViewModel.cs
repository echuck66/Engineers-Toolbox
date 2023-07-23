using EngineersToolbox.Models.Selectors;
using EngineersToolbox.Services.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.ViewModels
{
    public partial class NumberBaseConverterViewModel : ToolboxBaseViewModel
    {
        private NumberBaseConverter _converter;

        public NumberBaseConverterViewModel()
        {
            _converter = new NumberBaseConverter();
            Title = "Number Base Converter";
            Bind();
        }


        public void Bind()
        {
            
        }
    }
}
