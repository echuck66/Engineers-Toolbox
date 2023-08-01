using EngineersToolbox.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Models.Entities
{
    public class ConverterDefaultUnits
    {

        public DistanceUnits DefaultDistanceUnits { get; set; }

        public DistanceUnits DefaultDistanceConversionUnits { get; set; }

        public AreaUnits DefaultAreaUnits { get; set; }

        public AreaUnits DefaultAreaConversionUnits { get; set; }

        public VolumeUnits DefaultVolumeUnits { get; set; }

        public VolumeUnits DefaultVolumeConversionUnits { get; set; }

        public MassUnits DefaultMassUnits { get; set; }

        public MassUnits DefaultMassConversionUnits { get; set; }

        public PressureUnits DefaultPressureUnits { get; set; }

        public PressureUnits DefaultPressureConversionUnits { get; set; }

        public AngleUnits DefaultAngleUnits { get; set; }

        public AngleUnits DefaultAngleConversionUnits { get; set; }
    }
}
