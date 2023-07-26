﻿using EngineersToolbox.Services.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.ViewModels
{
    public partial class PressureConverterViewModel : ToolboxBaseViewModel
    {
        private PressureConverter _converter;

        public PressureConverterViewModel()
        {
            _converter = new PressureConverter();
            Title = "Pressure Conversion";
            Bind();
        }

        public void Bind()
        {

        }
    }
}
