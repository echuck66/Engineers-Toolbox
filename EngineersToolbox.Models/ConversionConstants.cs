using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Models
{
    public static class ConversionConstants
    {
        // DISTANCE FACTORS
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

        // AREA FACTORS
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

        // VOLUME FACTORS
        public const decimal CUBICKILOMETER_TO_CUBICMETER_FACTOR = 1000000000M;
        public const decimal CUBICCENTIMETER_TO_CUBICMETER_FACTOR = 0.000001M;
        public const decimal CUBICMILLIMETER_TO_CUBICMETER_FACTOR = 1.0E-9M;
        public const decimal LITER_TO_CUBICMETER_FACTOR = 0.001M;
        public const decimal MILLILITER_TO_CUBICMETER_FACTOR = 0.000001M;
        public const decimal GALLON_TO_CUBICMETER_FACTOR = 0.0037854118M;
        public const decimal QUART_TO_CUBICMETER_FACTOR = 0.0009463529M;
        public const decimal PINT_TO_CUBICMETER_FACTOR = 0.0004731765M;
        public const decimal CUBICMILE_TO_CUBICMETER_FACTOR = 4168181825.4M;
        public const decimal CUBICYARD_TO_CUBICMETER_FACTOR = 0.764554858M;
        public const decimal CUBICFOOT_TO_CUBICMETER_FACTOR = 0.0283168466M;
        public const decimal CUBICINCH_TO_CUBICMETER_FACTOR = 0.0000163871M;
        
        public const decimal CUBICMETER_TO_CUBICKILOMETER_FACTOR = 1.0E-9M;
        public const decimal CUBICCENTIMETER_TO_CUBICKILOMETER_FACTOR = 1.0E-15M;
        public const decimal CUBICMILLIMETER_TO_CUBICKILOMETER_FACTOR = 1.0E-18M;
        public const decimal LITER_TO_CUBICKILOMETER_FACTOR = 1.0E-12M;
        public const decimal MILLILITER_TO_CUBICKILOMETER_FACTOR = 1.0E-15M;
        public const decimal GALLON_TO_CUBICKILOMETER_FACTOR = 3.785411783E-12M;
        public const decimal QUART_TO_CUBICKILOMETER_FACTOR = 9.463529459E-13M;
        public const decimal PINT_TO_CUBICKILOMETER_FACTOR = 4.731764729E-13M;
        public const decimal CUBICMILE_TO_CUBICKILOMETER_FACTOR = 4.1681818254M;
        public const decimal CUBICYARD_TO_CUBICKILOMETER_FACTOR = 7.645548579E-10M;
        public const decimal CUBICFOOT_TO_CUBICKILOMETER_FACTOR = 2.831684659E-11M;
        public const decimal CUBICINCH_TO_CUBICKILOMETER_FACTOR = 1.6387064E-14M;

        public const decimal CUBICMETER_TO_CUBICCENTIMETER_FACTOR = 1000000M;
        public const decimal CUBICKILOMETER_TO_CUBICCENTIMETER_FACTOR = 1000000000000000M;
        public const decimal CUBICMILLIMETER_TO_CUBICCENTIMETER_FACTOR = 0.001M;
        public const decimal LITER_TO_CUBICCENTIMETER_FACTOR = 1000M;
        public const decimal MILLILITER_TO_CUBICCENTIMETER_FACTOR = 1M;
        public const decimal GALLON_TO_CUBICCENTIMETER_FACTOR = 3785.411784M;
        public const decimal QUART_TO_CUBICCENTIMETER_FACTOR = 946.352946M;
        public const decimal PINT_TO_CUBICCENTIMETER_FACTOR = 473.176473M;
        public const decimal CUBICMILE_TO_CUBICCENTIMETER_FACTOR = 4168181825440540M;
        public const decimal CUBICYARD_TO_CUBICCENTIMETER_FACTOR = 764554.85798M;
        public const decimal CUBICFOOT_TO_CUBICCENTIMETER_FACTOR = 28316.846592M;
        public const decimal CUBICINCH_TO_CUBICCENTIMETER_FACTOR = 16.387064M;

        public const decimal CUBICMETER_TO_CUBICMILLIMETER_FACTOR = 1000000000M;
        public const decimal CUBICKILOMETER_TO_CUBICMILLIMETER_FACTOR = 1000000000000000000M;
        public const decimal CUBICCENTIMETER_TO_CUBICMILLIMETER_FACTOR = 1000M;
        public const decimal LITER_TO_CUBICMILLIMETER_FACTOR = 1000000M;
        public const decimal MILLILITER_TO_CUBICMILLIMETER_FACTOR = 1000M;
        public const decimal GALLON_TO_CUBICMILLIMETER_FACTOR = 3785411.784M;
        public const decimal QUART_TO_CUBICMILLIMETER_FACTOR = 946352.946M;
        public const decimal PINT_TO_CUBICMILLIMETER_FACTOR = 473176.473M;
        public const decimal CUBICMILE_TO_CUBICMILLIMETER_FACTOR = 4168181825440539600M;
        public const decimal CUBICYARD_TO_CUBICMILLIMETER_FACTOR = 764554857.98M;
        public const decimal CUBICFOOT_TO_CUBICMILLIMETER_FACTOR = 28316846.592M;
        public const decimal CUBICINCH_TO_CUBICMILLIMETER_FACTOR = 16387.064M;

        public const decimal CUBICMETER_TO_LITER_FACTOR = 1000M;
        public const decimal CUBICKILOMETER_TO_LITER_FACTOR = 1000000000000M;
        public const decimal CUBICCENTIMETER_TO_LITER_FACTOR = 0.001M;
        public const decimal CUBICMILLIMETER_TO_LITER_FACTOR = 0.000001M;
        public const decimal MILLILITER_TO_LITER_FACTOR = 0.001M;
        public const decimal GALLON_TO_LITER_FACTOR = 3.785411784M;
        public const decimal QUART_TO_LITER_FACTOR = 0.946352946M;
        public const decimal PINT_TO_LITER_FACTOR = 0.473176473M;
        public const decimal CUBICMILE_TO_LITER_FACTOR = 4168181825441M;
        public const decimal CUBICYARD_TO_LITER_FACTOR = 764.55485798M;
        public const decimal CUBICFOOT_TO_LITER_FACTOR = 28.316846592M;
        public const decimal CUBICINCH_TO_LITER_FACTOR = 0.016387064M;

        public const decimal CUBICMETER_TO_MILLILITER_FACTOR = 1000000M;
        public const decimal CUBICKILOMETER_TO_MILLILITER_FACTOR = 1000000000000000M;
        public const decimal CUBICCENTIMETER_TO_MILLILITER_FACTOR = 1M;
        public const decimal CUBICMILLIMETER_TO_MILLILITER_FACTOR = 0.001M;
        public const decimal LITER_TO_MILLILITER_FACTOR = 1000M;
        public const decimal GALLON_TO_MILLILITER_FACTOR = 3785.411784M;
        public const decimal QUART_TO_MILLILITER_FACTOR = 946.352946M;
        public const decimal PINT_TO_MILLILITER_FACTOR = 473.176473M;
        public const decimal CUBICMILE_TO_MILLILITER_FACTOR = 4168181825440540M;
        public const decimal CUBICYARD_TO_MILLILITER_FACTOR = 764554.85798M;
        public const decimal CUBICFOOT_TO_MILLILITER_FACTOR = 28316.846592M;
        public const decimal CUBICINCH_TO_MILLILITER_FACTOR = 16.387064M;

        public const decimal CUBICMETER_TO_GALLON_FACTOR = 264.17205236M;
        public const decimal CUBICKILOMETER_TO_GALLON_FACTOR = 264172052358M;
        public const decimal CUBICCENTIMETER_TO_GALLON_FACTOR = 0.0002641721M;
        public const decimal CUBICMILLIMETER_TO_GALLON_FACTOR = 2.641720523E-7M;
        public const decimal LITER_TO_GALLON_FACTOR = 0.2641720524M;
        public const decimal MILLILITER_TO_GALLON_FACTOR = 0.0002641721M;
        public const decimal QUART_TO_GALLON_FACTOR = 0.25M;
        public const decimal PINT_TO_GALLON_FACTOR = 0.125M;
        public const decimal CUBICMILE_TO_GALLON_FACTOR = 1101117147429M;
        public const decimal CUBICYARD_TO_GALLON_FACTOR = 201.97402597M;
        public const decimal CUBICFOOT_TO_GALLON_FACTOR = 7.4805194805M;
        public const decimal CUBICINCH_TO_GALLON_FACTOR = 0.0043290043M;

        public const decimal CUBICMETER_TO_QUART_FACTOR = 1056.6882094M;
        public const decimal CUBICKILOMETER_TO_QUART_FACTOR = 1056688209433M;
        public const decimal CUBICCENTIMETER_TO_QUART_FACTOR = 0.0010566882M;
        public const decimal CUBICMILLIMETER_TO_QUART_FACTOR = 0.0000010567M;
        public const decimal LITER_TO_QUART_FACTOR = 1.0566882094M;
        public const decimal MILLILITER_TO_QUART_FACTOR = 0.0010566882M;
        public const decimal GALLON_TO_QUART_FACTOR = 4M;
        public const decimal PINT_TO_QUART_FACTOR = 0.5M;
        public const decimal CUBICMILE_TO_QUART_FACTOR = 4404468589714M;
        public const decimal CUBICYARD_TO_QUART_FACTOR = 807.8961039M;
        public const decimal CUBICFOOT_TO_QUART_FACTOR = 29.922077922M;
        public const decimal CUBICINCH_TO_QUART_FACTOR = 0.0173160173M;

        public const decimal CUBICMETER_TO_PINT_FACTOR = 2113.3764189M;
        public const decimal CUBICKILOMETER_TO_PINT_FACTOR = 2113376418865M;
        public const decimal CUBICCENTIMETER_TO_PINT_FACTOR = 0.0021133764M;
        public const decimal CUBICMILLIMETER_TO_PINT_FACTOR = 0.0000021134M;
        public const decimal LITER_TO_PINT_FACTOR = 2.1133764189M;
        public const decimal MILLILITER_TO_PINT_FACTOR = 0.0021133764M;
        public const decimal GALLON_TO_PINT_FACTOR = 8M;
        public const decimal QUART_TO_PINT_FACTOR = 2M;
        public const decimal CUBICMILE_TO_PINT_FACTOR = 8808937179429M;
        public const decimal CUBICYARD_TO_PINT_FACTOR = 1615.7922078M;
        public const decimal CUBICFOOT_TO_PINT_FACTOR = 59.844155844M;
        public const decimal CUBICINCH_TO_PINT_FACTOR = 0.0346320346M;

        public const decimal CUBICMETER_TO_CUBICMILE_FACTOR = 2.399127585E-10M;
        public const decimal CUBICKILOMETER_TO_CUBICMILE_FACTOR = 0.2399127586M;
        public const decimal CUBICCENTIMETER_TO_CUBICMILE_FACTOR = 2.399127585E-16M;
        public const decimal CUBICMILLIMETER_TO_CUBICMILE_FACTOR = 2.399127585E-19M;
        public const decimal LITER_TO_CUBICMILE_FACTOR = 2.399127585E-13M;
        public const decimal MILLILITER_TO_CUBICMILE_FACTOR = 2.399127585E-16M;
        public const decimal GALLON_TO_CUBICMILE_FACTOR = 9.081685834E-13M;
        public const decimal QUART_TO_CUBICMILE_FACTOR = 2.270421458E-13M;
        public const decimal PINT_TO_CUBICMILE_FACTOR = 1.135210729E-13M;
        public const decimal CUBICYARD_TO_CUBICMILE_FACTOR = 1.83426465E-10M;
        public const decimal CUBICFOOT_TO_CUBICMILE_FACTOR = 6.79357278E-12M;
        public const decimal CUBICINCH_TO_CUBICMILE_FACTOR = 3.931465729E-15M;

        public const decimal CUBICMETER_TO_CUBICYARD_FACTOR = 1.3079506193M;
        public const decimal CUBICKILOMETER_TO_CUBICYARD_FACTOR = 1307950619.3M;
        public const decimal CUBICCENTIMETER_TO_CUBICYARD_FACTOR = 0.000001308M;
        public const decimal CUBICMILLIMETER_TO_CUBICYARD_FACTOR = 1.307950619E-9M;
        public const decimal LITER_TO_CUBICYARD_FACTOR = 0.0013079506M;
        public const decimal MILLILITER_TO_CUBICYARD_FACTOR = 0.000001308M;
        public const decimal GALLON_TO_CUBICYARD_FACTOR = 0.0049511317M;
        public const decimal QUART_TO_CUBICYARD_FACTOR = 0.0012377829M;
        public const decimal PINT_TO_CUBICYARD_FACTOR = 0.0006188915M;
        public const decimal CUBICMILE_TO_CUBICYARD_FACTOR = 5451776000M;
        public const decimal CUBICFOOT_TO_CUBICYARD_FACTOR = 0.037037037M;
        public const decimal CUBICINCH_TO_CUBICYARD_FACTOR = 0.0000214335M;

        public const decimal CUBICMETER_TO_CUBICFOOT_FACTOR = 35.314666721M;
        public const decimal CUBICKILOMETER_TO_CUBICFOOT_FACTOR = 35314666721M;
        public const decimal CUBICCENTIMETER_TO_CUBICFOOT_FACTOR = 0.0000353147M;
        public const decimal CUBICMILLIMETER_TO_CUBICFOOT_FACTOR = 3.531466672E-8M;
        public const decimal LITER_TO_CUBICFOOT_FACTOR = 0.0353146667M;
        public const decimal MILLILITER_TO_CUBICFOOT_FACTOR = 0.0000353147M;
        public const decimal GALLON_TO_CUBICFOOT_FACTOR = 0.1336805556M;
        public const decimal QUART_TO_CUBICFOOT_FACTOR = 0.0334201389M;
        public const decimal PINT_TO_CUBICFOOT_FACTOR = 0.0167100694M;
        public const decimal CUBICMILE_TO_CUBICFOOT_FACTOR = 147197952000M;
        public const decimal CUBICYARD_TO_CUBICFOOT_FACTOR = 27M;
        public const decimal CUBICINCH_TO_CUBICFOOT_FACTOR = 0.0005787037M;

        public const decimal CUBICMETER_TO_CUBICINCH_FACTOR = 61023.744095M;
        public const decimal CUBICKILOMETER_TO_CUBICINCH_FACTOR = 61023744094732M;
        public const decimal CUBICCENTIMETER_TO_CUBICINCH_FACTOR = 0.0610237441M;
        public const decimal CUBICMILLIMETER_TO_CUBICINCH_FACTOR = 0.0000610237M;
        public const decimal LITER_TO_CUBICINCH_FACTOR = 61.023744095M;
        public const decimal MILLILITER_TO_CUBICINCH_FACTOR = 0.0610237441M;
        public const decimal GALLON_TO_CUBICINCH_FACTOR = 231M;
        public const decimal QUART_TO_CUBICINCH_FACTOR = 57.75M;
        public const decimal PINT_TO_CUBICINCH_FACTOR = 28.875M;
        public const decimal CUBICMILE_TO_CUBICINCH_FACTOR = 254358061055996M;
        public const decimal CUBICYARD_TO_CUBICINCH_FACTOR = 46656M;
        public const decimal CUBICFOOT_TO_CUBICINCH_FACTOR = 1728M;

    }
}
