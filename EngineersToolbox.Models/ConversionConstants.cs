using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Models
{
    public static class ConversionConstants
    {
        public const decimal METER_TO_FOOT_FACTOR = 3.280839895M;
        public const decimal KILOMETER_TO_FOOT_FACTOR = 3280.839895M;
        public const decimal CENTIMETER_TO_FOOT_FACTOR = 0.032808399M;
        public const decimal MILLIMETER_TO_FOOT_FACTOR = 0.0032808399M;
        public const decimal MICROMETER_TO_FOOT_FACTOR = 0.0000032808M;
        public const decimal NANOMETER_TO_FOOT_FACTOR = 3.280839895E-9M;
        public const decimal MILE_TO_FOOT_FACTOR = 5280M;
        public const decimal YARD_TO_FOOT_FACTOR = 3M;
        public const decimal INCH_TO_FOOT_FACTOR = 0.0833333333M;

        public const decimal KILOMETER_TO_METER_FACTOR = 1000M;
        public const decimal CENTIMETER_TO_METER_FACTOR = 0.01M;
        public const decimal MILLIMETER_TO_METER_FACTOR = 0.001M;
        public const decimal MICROMETER_TO_METER_FACTOR = 0.000001M;
        public const decimal NANOMETER_TO_METER_FACTOR = 1.0E-9M;
        public const decimal MILE_TO_METER_FACTOR = 1609.35M;
        public const decimal YARD_TO_METER_FACTOR = 0.9144M;
        public const decimal FOOT_TO_METER_FACTOR = 0.3048M;
        public const decimal INCH_TO_METER_FACTOR = 0.0254M;

        public const decimal METER_TO_KILOMETER_FACTOR = 0.001M;
        public const decimal CENTIMETER_TO_KILOMETER_FACTOR = 0.00001M;
        public const decimal MILLIMETER_TO_KILOMETER_FACTOR = 0.000001M;
        public const decimal MICROMETER_TO_KILOMETER_FACTOR = 9.999999999E-10M;
        public const decimal NANOMETER_TO_KILOMETER_FACTOR = 1.0E-12M;
        public const decimal MILE_TO_KILOMETER_FACTOR = 1.60935M;
        public const decimal YARD_TO_KILOMETER_FACTOR = 0.0009144M;
        public const decimal FOOT_TO_KILOMETER_FACTOR = 0.0003048M;
        public const decimal INCH_TO_KILOMETER_FACTOR = 0.0000254M;

        public const decimal METER_TO_CENTIMETER_FACTOR = 100M;
        public const decimal KILOMETER_TO_CENTIMETER_FACTOR = 100000M;
        public const decimal MILLIMETER_TO_CENTIMETER_FACTOR = 0.1M;
        public const decimal MICROMETER_TO_CENTIMETER_FACTOR = 0.0001M;
        public const decimal NANOMETER_TO_CENTIMETER_FACTOR = 1.0E-7M;
        public const decimal MILE_TO_CENTIMETER_FACTOR = 160935M;
        public const decimal YARD_TO_CENTIMETER_FACTOR = 91.44M;
        public const decimal FOOT_TO_CENTIMETER_FACTOR = 30.48M;
        public const decimal INCH_TO_CENTIMETER_FACTOR = 2.54M;

        public const decimal METER_TO_MILLIMETER_FACTOR = 1000M;
        public const decimal KILOMETER_TO_MILLIMETER_FACTOR = 1000000M;
        public const decimal CENTIMETER_TO_MILLIMETER_FACTOR = 10M;
        public const decimal MICROMETER_TO_MILLIMETER_FACTOR = 0.001M;
        public const decimal NANOMETER_TO_MILLIMETER_FACTOR = 0.000001M;
        public const decimal MILE_TO_MILLIMETER_FACTOR = 1609344M;
        public const decimal YARD_TO_MILLIMETER_FACTOR = 914.4M;
        public const decimal FOOT_TO_MILLIMETER_FACTOR = 304.8M;
        public const decimal INCH_TO_MILLIMETER_FACTOR = 25.4M;

        public const decimal METER_TO_MICROMETER_FACTOR = 1000000M;
        public const decimal KILOMETER_TO_MICROMETER_FACTOR = 1000000000M;
        public const decimal CENTIMETER_TO_MICROMETER_FACTOR = 10000M;
        public const decimal MILLIMETER_TO_MICROMETER_FACTOR = 1000M;
        public const decimal NANOMETER_TO_MICROMETER_FACTOR = 0.001M;
        public const decimal MILE_TO_MICROMETER_FACTOR = 1609350000M;
        public const decimal YARD_TO_MICROMETER_FACTOR = 914400M;
        public const decimal FOOT_TO_MICROMETER_FACTOR = 304800M;
        public const decimal INCH_TO_MICROMETER_FACTOR = 25400M;

        public const decimal METER_TO_NANOMETER_FACTOR = 1000000000M;
        public const decimal KILOMETER_TO_NANOMETER_FACTOR = 1000000000000M;
        public const decimal CENTIMETER_TO_NANOMETER_FACTOR = 10000000M;
        public const decimal MILLIMETER_TO_NANOMOETER_FACTOR = 1000000M;
        public const decimal MICROMETER_TO_NANOMETER_FACTOR = 1000M;
        public const decimal MILE_TO_NANOMETER_FACTOR = 1609350000000M;
        public const decimal YARD_TO_NANOMETER_FACTOR = 914400000M;
        public const decimal FOOT_TO_NANOMETER_FACTOR = 304800000M;
        public const decimal INCH_TO_NANOMETER_FACTOR = 25400000M;

        public const decimal METER_TO_MILE_FACTOR = 0.0006213689M;
        public const decimal KILOMETER_TO_MILE_FACTOR = 0.6213688756M;
        public const decimal CENTIMETER_TO_MILE_FACTOR = 0.0000062137M;
        public const decimal MILLIMETER_TO_MILE_FACTOR = 6.213688756E-7M;
        public const decimal MICROMETER_TO_MILE_FACTOR = 6.213688756E-10M;
        public const decimal NANOMETER_TO_MILE_FACTOR = 6.213688756E-13M;
        public const decimal YARD_TO_MILE_FACTOR = 0.0005681797M;
        public const decimal FOOT_TO_MILE_FACTOR = 0.0001893932M;
        public const decimal INCH_TO_MILE_FACTOR = 0.0000157828M;

        public const decimal METER_TO_YARD_FACTOR = 1.0936132983M;
        public const decimal KILOMETER_TO_YARD_FACTOR = 1093.6132983M;
        public const decimal CENTIMETER_TO_YARD_FACTOR = 0.010936133M;
        public const decimal MILLIMETER_TO_YARD_FACTOR = 0.0010936133M;
        public const decimal MICROMETER_TO_YARD_FACTOR = 0.0000010936M;
        public const decimal NANOMETER_TO_YARD_FACTOR = 1.093613298E-9M;
        public const decimal MILE_TO_YARD_FACTOR = 1760.0065617M;
        public const decimal FOOT_TO_YARD_FACTOR = 0.3333333333M;
        public const decimal INCH_TO_YARD_FACTOR = 0.0277777778M;

        public const decimal METER_TO_INCH_FACTOR = 39.37007874M;
        public const decimal KILOMETER_TO_INCH_FACTOR = 39370.07874M;
        public const decimal CENTIMETER_TO_INCH_FACTOR = 0.3937007874M;
        public const decimal MILLIMETER_TO_INCH_FACTOR = 0.0393700787M;
        public const decimal MICROMETER_TO_INCH_FACTOR = 0.0000393701M;
        public const decimal NANOMETER_TO_INCH_FACTOR = 3.937007874E-8M;
        public const decimal MILE_TO_INCH_FACTOR = 63360M;
        public const decimal YARD_TO_INCH_FACTOR = 36M;
        public const decimal FOOT_TO_INCH_FACTOR = 12M;

        public const decimal SQUAREKILOMETER_TO_SQUAREMETER_FACTOR = 1000000M;
        public const decimal SQUARECENTIMETER_TO_SQUAREMETER_FACTOR = 0.0001M;
        public const decimal SQUAREMILLIMETER_TO_SQUAREMETER_FACTOR = 0.000001M;
        public const decimal HECTARE_TO_SQUAREMETER_FACTOR = 10000M;
        public const decimal SQUAREMILE_TO_SQUAREMETER_FACTOR = 2589990M;
        public const decimal SQUAREYARD_TO_SQUAREMETER_FACTOR = 0.83612736M;
        public const decimal SQUAREFOOT_TO_SQUAREMETER_FACTOR = 0.09290304M;
        public const decimal SQUAREINCH_TO_SQUAREMETER_FACTOR = 0.00064516M;
        public const decimal ACRE_TO_SQUAREMETER_FACTOR = 4046.8564224M;

        public const decimal SQUAREMETER_TO_SQUAREKILOMETER_FACTOR = 0.000001M;
        public const decimal SQUARECENTIMETER_TO_SQUAREKILOMETER_FACTOR = 1.0E-10M;
        public const decimal SQUAREMILLIMETER_TO_SQUAREKILOMETER_FACTOR = 1.0E-12M;
        public const decimal HECTARE_TO_SQUAREKILOMETER_FACTOR = 0.01M;
        public const decimal SQUAREMILE_TO_SQUAREKILOMETER_FACTOR = 2.58999M;
        public const decimal SQUAREYARD_TO_SQUAREKILOMETER_FACTOR = 8.3612736E-7M;
        public const decimal SQUAREFOOT_TO_SQUAREKILOMETER_FACTOR = 9.290304E-8M;
        public const decimal SQUAREINCH_TO_SQUAREKILOMETER_FACTOR = 6.4516E-10M;
        public const decimal ACRE_TO_SQUAREKILOMETER_FACTOR = 0.0040468564M;

        public const decimal SQUAREMETER_TO_SQUARECENTIMETER_FACTOR = 10000M;
        public const decimal SQUAREKILOMETER_TO_SQUARECENTIMETER_FACTOR = 10000000000M;
        public const decimal SQUAREMILLIMETER_TO_SQUARECENTIMETER_FACTOR = 0.01M;
        public const decimal HECTARE_TO_SQUARECENTIMETER_FACTOR = 100000000M;
        public const decimal SQUAREMILE_TO_SQUARECENTIMETER_FACTOR = 25899900000M;
        public const decimal SQUAREYARD_TO_SQUARECENTIMETER_FACTOR = 8361.2736M;
        public const decimal SQUAREFOOT_TO_SQUARECENTIMETER_FACTOR = 929.0304M;
        public const decimal SQUAREINCH_TO_SQUARECENTIMETER_FACTOR = 6.4516M;
        public const decimal ACRE_TO_SQUARECENTIMETER_FACTOR = 40468564.224M;

        public const decimal SQUAREMETER_TO_SQUAREMILLIMETER_FACTOR = 1000000M;
        public const decimal SQUAREKILOMETER_TO_SQUAREMILLIMETER_FACTOR = 1000000000000M;
        public const decimal SQUARECENTIMETER_TO_SQUAREMILLIMETER_FACTOR = 100M;
        public const decimal HECTARE_TO_SQUAREMILLIMETER_FACTOR = 10000000000M;
        public const decimal SQUAREMILE_TO_SQUAREMILLIMETER_FACTOR = 2589990000000M;
        public const decimal SQUAREYARD_TO_SQUAREMILLIMETER_FACTOR = 836127.36M;
        public const decimal SQUAREFOOT_TO_SQUAREMILLIMETER_FACTOR = 92903.04M;
        public const decimal SQUAREINCH_TO_SQUAREMILLIMETER_FACTOR = 645.16M;
        public const decimal ACRE_TO_SQUAREMILLIMETER_FACTOR = 4046856422.4M;

        public const decimal SQUAREMETER_TO_HECTARE_FACTOR = 0.0001M;
        public const decimal SQUAREKILOMETER_TO_HECTARE_FACTOR = 100M;
        public const decimal SQUARECENTIMETER_TO_HECTARE_FACTOR = 1.0E-8M;
        public const decimal SQUAREMILLIMETER_TO_HECTARE_FACTOR = 9.999999999E-11M;
        public const decimal SQUAREMILE_TO_HECTARE_FACTOR = 258.999M;
        public const decimal SQUAREYARD_TO_HECTARE_FACTOR = 0.0000836127M;
        public const decimal SQUAREFOOT_TO_HECTARE_FACTOR = 0.0000092903M;
        public const decimal SQUAREINCH_TO_HECTARE_FACTOR = 6.4516E-8M;
        public const decimal ACRE_TO_HECTARE_FACTOR = 0.4046856422M;

        public const decimal SQUAREMETER_TO_SQUAREMILE_FACTOR = 3.861018768E-7M;
        public const decimal SQUAREKILOMETER_TO_SQUAREMILE_FACTOR = 0.3861018768M;
        public const decimal SQUARECENTIMETER_TO_SQUAREMILE_FACTOR = 3.861018768E-11M;
        public const decimal SQUAREMILLIMETER_TO_SQUAREMILE_FACTOR = 3.861018768E-13M;
        public const decimal HECTARE_TO_SQUAREMILE_FACTOR = 0.0038610188M;
        public const decimal SQUAREYARD_TO_SQUAREMILE_FACTOR = 3.228303429E-7M;
        public const decimal SQUAREFOOT_TO_SQUAREMILE_FACTOR = 3.58700381E-8M;
        public const decimal SQUAREINCH_TO_SQUAREMILE_FACTOR = 2.490974868E-10M;
        public const decimal ACRE_TO_SQUAREMILE_FACTOR = 0.0015624989M;

        public const decimal SQUAREMETER_TO_SQUAREYARD_FACTOR = 1.1959900463M;
        public const decimal SQUAREKILOMETER_TO_SQUAREYARD_FACTOR = 1195990.0463M;
        public const decimal SQUARECENTIMETER_TO_SQUAREYARD_FACTOR = 0.000119599M;
        public const decimal SQUAREMILLIMETER_TO_SQUAREYARD_FACTOR = 0.000001196M;
        public const decimal HECTARE_TO_SQUAREYARD_FACTOR = 11959.900463M;
        public const decimal SQUAREMILE_TO_SQUAREYARD_FACTOR = 3097602.26M;
        public const decimal SQUAREFOOT_TO_SQUAREYARD_FACTOR = 0.1111111111M;
        public const decimal SQUAREINCH_TO_SQUAREYARD_FACTOR = 0.0007716049M;
        public const decimal ACRE_TO_SQUAREYARD_FACTOR = 4840M;

        public const decimal SQUAREMETER_TO_SQUAREFOOT_FACTOR = 10.763910417M;
        public const decimal SQUAREKILOMETER_TO_SQUAREFOOT_FACTOR = 10763910.417M;
        public const decimal SQUARECENTIMETER_TO_SQUAREFOOT_FACTOR = 0.001076391M;
        public const decimal SQUAREMILLIMETER_TO_SQUAREFOOT_FACTOR = 0.0000107639M;
        public const decimal HECTARE_TO_SQUAREFOOT_FACTOR = 107639.10417M;
        public const decimal SQUAREMILE_TO_SQUAREFOOT_FACTOR = 27878420.34M;
        public const decimal SQUAREYARD_TO_SQUAREFOOT_FACTOR = 9M;
        public const decimal SQUAREINCH_TO_SQUAREFOOT_FACTOR = 0.0069444444M;
        public const decimal ACRE_TO_SQUAREFOOT_FACTOR = 43560M;

        public const decimal SQUAREMETER_TO_SQUAREINCH_FACTOR = 1550.0031M;
        public const decimal SQUAREKILOMETER_TO_SQUAREINCH_FACTOR = 1550003100M;
        public const decimal SQUARECENTIMETER_TO_SQUAREINCH_FACTOR = 0.15500031M;
        public const decimal SQUAREMILLIMETER_TO_SQUAREINCH_FACTOR = 0.0015500031M;
        public const decimal HECTARE_TO_SQUAREINCH_FACTOR = 15500031M;
        public const decimal SQUAREMILE_TO_SQUAREINCH_FACTOR = 4014492529M;
        public const decimal SQUAREYARD_TO_SQUAREINCH_FACTOR = 1296M;
        public const decimal SQUAREFOOT_TO_SQUAREINCH_FACTOR = 144M;
        public const decimal ACRE_TO_SQUAREINCH_FACTOR = 6272640M;

        public const decimal SQUAREMETER_TO_ACRE_FACTOR = 0.0002471054M;
        public const decimal SQUAREKILOMETER_TO_ACRE_FACTOR = 247.10538147M;
        public const decimal SQUARECENTIMETER_TO_ACRE_FACTOR = 2.471053814E-8M;
        public const decimal SQUAREMILLIMETER_TO_ACRE_FACTOR = 2.471053814E-10M;
        public const decimal HECTARE_TO_ACRE_FACTOR = 2.4710538147M;
        public const decimal SQUAREMILE_TO_ACRE_FACTOR = 640.00046695M;
        public const decimal SQUAREYARD_TO_ACRE_FACTOR = 0.0002066116M;
        public const decimal SQUAREFOOT_TO_ACRE_FACTOR = 0.0000229568M;
        public const decimal SQUAREINCH_TO_ACRE_FACTOR = 1.594225079E-7M;



    }
}
