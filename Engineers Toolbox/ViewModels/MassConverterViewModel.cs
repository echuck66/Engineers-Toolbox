using EngineersToolbox.Services.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.ViewModels
{
    public partial class MassConverterViewModel : ToolboxBaseViewModel
    {
        private MassConverter _converter;

        public MassConverterViewModel()
        {
            _converter = new MassConverter();
            Title = "Mass Conversion";
            Bind();
        }

        public void Bind()
        {

        }
    }
}
