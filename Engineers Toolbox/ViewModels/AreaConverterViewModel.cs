using EngineersToolbox.Services.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.ViewModels
{
    public partial class AreaConverterViewModel : ToolboxBaseViewModel
    {
        private AreaConverter _converter;

        public AreaConverterViewModel()
        {
            _converter = new AreaConverter();
            Title = "Area Conversion";
            Bind();
        }

        public void Bind()
        {

        }
    }
}
