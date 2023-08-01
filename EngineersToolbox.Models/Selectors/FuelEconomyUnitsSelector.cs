using EngineersToolbox.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Models.Selectors
{
    public class FuelEconomyUnitsSelector
    {
        public FuelUnits FuelUnitsComponent { get; set; }

        public DistanceUnits DistanceUnitsComponent { get; set; }

        public string UnitsName { get; set; }

        
    }
}
