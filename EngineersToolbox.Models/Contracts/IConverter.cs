﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineersToolbox.Models.Enums;

namespace EngineersToolbox.Models
{
    public interface IConverter : ITool
    {
        public ConverterType ConverterType { get; }
    }
}
