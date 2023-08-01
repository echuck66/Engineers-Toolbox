using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Models.Displays
{
    public class DistanceValueDisplay
    {
        public decimal Value { get; set; }

        public string ValueText { get; set; }

        public Enums.DistanceUnits ValueUnits { get; set; }

        public string ValueUnitsText { get; set; }
    }
}
