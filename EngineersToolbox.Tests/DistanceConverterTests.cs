using EngineersToolbox.Services.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Tests
{
    [TestClass]
    public class DistanceConverterTests
    {
        const decimal inchesInFoot = 12M;
        const decimal inchesInYard = 36M;
        const decimal feetInMile = 5280M;
        const decimal inchesInMeter = 39.3700787M;
        const decimal milesInKilometer = 1.609344M;
        const decimal inchesToMeterFactor = 0.0254M;

        [TestMethod]
        public void GetMillimetersFromMillimeters_ReturnsMillimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal cm = 1M;
            decimal mm = converter.GetMillimeters(cm, Models.Enums.DistanceUnits.Millimeter);

            decimal expectedMM = cm;

            Assert.AreEqual(expectedMM, mm, 6);
        }

        [TestMethod]
        public void GetMillimetersFromCentimeters_ReturnsMillimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal cm = 1M;
            decimal mm = converter.GetMillimeters(cm, Models.Enums.DistanceUnits.Centimeter);

            decimal expectedMM = cm * 10M;

            Assert.AreEqual(expectedMM, mm, 6);
        }

        [TestMethod]
        public void GetMillimetersFromMeters_ReturnsMillimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal m = 1M;
            decimal mm = converter.GetMillimeters(m, Models.Enums.DistanceUnits.Meter);

            decimal expectedMM = m * 1000M;

            Assert.AreEqual(expectedMM, mm, 6);
        }

        [TestMethod]
        public void GetMillimetersFromKilometers_ReturnsMillimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal km = 1M;
            decimal mm = converter.GetMillimeters(km, Models.Enums.DistanceUnits.Kilometer);

            decimal expectedMM = km * 1000000M;

            Assert.AreEqual(expectedMM, mm, 6);
        }

        [TestMethod]
        public void GetMillimetersFromInches_ReturnsMillimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal inches = 1M;
            decimal mm = converter.GetMillimeters(inches, Models.Enums.DistanceUnits.Inch);

            decimal expectedMM = (inches / inchesInMeter) * 1000M;

            Assert.AreEqual(expectedMM, mm, 6);
        }

        [TestMethod]
        public void GetMillimetersFromFeet_ReturnsMillimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal feet = 1M;
            decimal mm = converter.GetMillimeters(feet, Models.Enums.DistanceUnits.Foot);

            decimal expectedMM = ((feet * inchesInFoot) / inchesInMeter) * 1000M;

            Assert.AreEqual(expectedMM, mm, 6);
        }

        [TestMethod]
        public void GetMillimetersFromYards_ReturnsMillimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal yd = 1M;
            decimal mm = converter.GetMillimeters(yd, Models.Enums.DistanceUnits.Yard);

            decimal expectedMM = ((yd * inchesInYard) / inchesInMeter) * 1000M;

            Assert.AreEqual(expectedMM, mm, 5);
        }

        [TestMethod]
        public void GetMillimetersFromMiles_ReturnsMillimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mi = 1M;
            decimal mm = converter.GetMillimeters(mi, Models.Enums.DistanceUnits.Mile);

            var expectedFT = mi * feetInMile;
            var expectedIN = expectedFT * inchesInFoot;
            var expectedM = expectedIN * inchesToMeterFactor;
            var expectedMM = expectedM * 1000M;

            //decimal expectedMM = (((mi * feetInMile) * inchesInFoot) / inchesInMeter) * 1000M;

            Assert.AreEqual(expectedMM, mm, 5);
        }

        [TestMethod]
        public void GetCentimetersFromMillimeters_ReturnsCentimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mm = 1M;
            decimal cm = converter.GetCentimeters(mm, Models.Enums.DistanceUnits.Millimeter);

            decimal expectedCM = mm / 10M;

            Assert.AreEqual(expectedCM, cm, 6);
        }

        [TestMethod]
        public void GetCentimetersFromCentimeters_ReturnsCentimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal cm = 1M;
            decimal cmResults = converter.GetCentimeters(cm, Models.Enums.DistanceUnits.Centimeter);

            decimal expectedCM = cm;

            Assert.AreEqual(expectedCM, cmResults, 6);
        }

        [TestMethod]
        public void GetCentimetersFromMeters_ReturnsCentimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal m = 1M;
            decimal cm = converter.GetCentimeters(m, Models.Enums.DistanceUnits.Meter);

            decimal expectedCM = m * 100M;

            Assert.AreEqual(expectedCM, cm, 6);
        }

        [TestMethod]
        public void GetCentimetersFromKilometers_ReturnsCentimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal km = 1M;
            decimal cm = converter.GetCentimeters(km, Models.Enums.DistanceUnits.Kilometer);

            decimal expectedCM = km * 100000M;

            Assert.AreEqual(expectedCM, cm, 6);
        }

        [TestMethod]
        public void GetCentimetersFromInches_ReturnsCentimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal inches = 1M;
            decimal cm = converter.GetCentimeters(inches, Models.Enums.DistanceUnits.Inch);

            decimal expectedCM = inches / inchesInMeter * 100M;

            Assert.AreEqual(expectedCM, cm, 6);
        }

        [TestMethod]
        public void GetCentimetersFromFeet_ReturnsCentimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal feet = 1M;
            decimal cm = converter.GetCentimeters(feet, Models.Enums.DistanceUnits.Foot);

            decimal expectedCM = ((feet * inchesInFoot) / inchesInMeter) * 100M;

            Assert.AreEqual(expectedCM, cm, 6);
        }

        [TestMethod]
        public void GetCentimetersFromYards_ReturnsCentimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal yd = 1M;
            decimal cm = converter.GetCentimeters(yd, Models.Enums.DistanceUnits.Yard);

            decimal expectedCM = ((yd * inchesInYard) / inchesInMeter) * 100M;

            Assert.AreEqual(expectedCM, cm, 6);
        }

        [TestMethod]
        public void GetCentimetersFromMiles_ReturnsCentimeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mi = 1M;
            decimal cm = converter.GetCentimeters(mi, Models.Enums.DistanceUnits.Mile);

            decimal expectedCM = ((mi * feetInMile * inchesInFoot) / inchesInMeter) * 100M;

            Assert.AreEqual(expectedCM, cm, 6);
        }


        [TestMethod]
        public void GetMetersFromMillimeters_ReturnsMeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mm = 1M;
            decimal m = converter.GetMeters(mm, Models.Enums.DistanceUnits.Millimeter);

            decimal expectedM = mm / 1000M;

            Assert.AreEqual(expectedM, m);
        }

        [TestMethod]
        public void GetMetersFromCentimeters_ReturnsMeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal cm = 1M;
            decimal m = converter.GetMeters(cm, Models.Enums.DistanceUnits.Centimeter);

            decimal expectedM = cm / 100M; ;

            Assert.AreEqual(expectedM, m);
        }

        [TestMethod]
        public void GetMetersFromMeters_ReturnsMeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal m = 1M;
            decimal mResults = converter.GetMeters(m, Models.Enums.DistanceUnits.Meter);

            decimal expectedM = m;

            Assert.AreEqual(expectedM, mResults);
        }

        [TestMethod]
        public void GetMetersFromKilometers_ReturnsMeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal km = 1M;
            decimal m = converter.GetMeters(km, Models.Enums.DistanceUnits.Kilometer);

            decimal expectedM = km * 1000M;

            Assert.AreEqual(expectedM, m);
        }

        [TestMethod]
        public void GetMetersFromInches_ReturnsMeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal inches = 1M;
            decimal m = converter.GetMeters(inches, Models.Enums.DistanceUnits.Inch);

            decimal expectedM = inches / inchesInMeter;

            Assert.AreEqual(expectedM, m, 6);
        }

        [TestMethod]
        public void GetMetersFromFeet_ReturnsMeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal feet = 1M;
            decimal m = converter.GetMeters(feet, Models.Enums.DistanceUnits.Foot);

            decimal expectedM = (feet * inchesInFoot) / inchesInMeter;

            Assert.AreEqual(expectedM, m, 6);
        }

        [TestMethod]
        public void GetMetersFromYards_ReturnsMeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal yd = 1M;
            decimal m = converter.GetMeters(yd, Models.Enums.DistanceUnits.Yard);

            decimal expectedM = (yd * inchesInYard) / inchesInMeter;

            Assert.AreEqual(expectedM, m, 6);
        }

        [TestMethod]
        public void GetMetersFromMiles_ReturnsMeters()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mi = 1M;
            decimal m = converter.GetMeters(mi, Models.Enums.DistanceUnits.Mile);

            decimal expectedM = (mi * feetInMile * inchesInFoot) / inchesInMeter;

            Assert.AreEqual(expectedM, m, 6);
        }


        [TestMethod]
        public void GetKilometersFromMillimeters_ReturnsKilometers()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mm = 1M;
            decimal km = converter.GetKilometers(mm, Models.Enums.DistanceUnits.Millimeter);

            decimal expectedKM = mm / 1000000M;

            Assert.AreEqual(expectedKM, km);
        }

        [TestMethod]
        public void GetKilometersFromCentimeters_ReturnsKilometers()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal cm = 1M;
            decimal km = converter.GetKilometers(cm, Models.Enums.DistanceUnits.Centimeter);

            decimal expectedKM = cm / 100000M; ;

            Assert.AreEqual(expectedKM, km);
        }

        [TestMethod]
        public void GetKilometersFromMeters_ReturnsKilometers()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal m = 1M;
            decimal kmResults = converter.GetKilometers(m, Models.Enums.DistanceUnits.Meter);

            decimal expectedKM = m / 1000M;

            Assert.AreEqual(expectedKM, kmResults);
        }

        [TestMethod]
        public void GetKilometersFromKilometers_ReturnsKilometers()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal km = 1M;
            decimal kmResults = converter.GetKilometers(km, Models.Enums.DistanceUnits.Kilometer);

            decimal expectedKM = km;

            Assert.AreEqual(expectedKM, kmResults);
        }

        [TestMethod]
        public void GetKilometersFromInches_ReturnsKilometers()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal inches = 1M;
            decimal km = converter.GetKilometers(inches, Models.Enums.DistanceUnits.Inch);

            decimal expectedKM = (inches / inchesInMeter) / 1000M;

            Assert.AreEqual(expectedKM, km, 6);
        }

        [TestMethod]
        public void GetKilometersFromFeet_ReturnsKilometers()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal feet = 1M;
            decimal km = converter.GetKilometers(feet, Models.Enums.DistanceUnits.Foot);

            decimal expectedKM = ((feet / inchesInFoot) / inchesInMeter) / 1000M;

            Assert.AreEqual(expectedKM, km, 6);
        }

        [TestMethod]
        public void GeKilometersFromYards_ReturnsKilometers()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal yd = 1M;
            decimal km = converter.GetKilometers(yd, Models.Enums.DistanceUnits.Yard);

            decimal expectedKM = ((yd * inchesInYard) / inchesInMeter) / 1000M;

            Assert.AreEqual(expectedKM, km, 6);
        }

        [TestMethod]
        public void GetKilometersFromMiles_ReturnsKilometers()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mi = 1M;
            decimal km = converter.GetKilometers(mi, Models.Enums.DistanceUnits.Mile);

            decimal expectedKM = (((mi * feetInMile) * inchesInFoot) / inchesInMeter) / 1000M;

            Assert.AreEqual(expectedKM, km, 6);
        }


        [TestMethod]
        public void GetInchesFromMillimeters_ReturnsInches()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mm = 1M;
            decimal inchesResults = converter.GetInches(mm, Models.Enums.DistanceUnits.Millimeter);

            decimal expectedIN = (mm / 1000M) * inchesInMeter;

            Assert.AreEqual(expectedIN, inchesResults, 6);
        }

        [TestMethod]
        public void GetInchesFromCentimeters_ReturnsInches()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal cm = 1M;
            decimal inches = converter.GetInches(cm, Models.Enums.DistanceUnits.Centimeter);

            decimal expectedIN = (cm * 100M) / inchesInMeter;

            Assert.AreEqual(expectedIN, inches, 6);
        }

        [TestMethod]
        public void GetInchesFromMeters_ReturnsInches()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal m = 1M;
            decimal inches = converter.GetInches(m, Models.Enums.DistanceUnits.Meter);

            decimal expectedIN = (m * inchesInMeter);

            Assert.AreEqual(expectedIN, inches, 6);
        }

        [TestMethod]
        public void GetInchesFromKilometers_ReturnsInches()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal km = 1M;
            decimal inches = converter.GetInches(km, Models.Enums.DistanceUnits.Kilometer);

            decimal expectedIN = (km * 1000M) * inchesInMeter;

            Assert.AreEqual(expectedIN, inches, 6);
        }

        [TestMethod]
        public void GetInchesFromInches_ReturnsInches()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal inches = 1M;
            decimal inchesResults = converter.GetInches(inches, Models.Enums.DistanceUnits.Inch);

            decimal expectedIN = inches;

            Assert.AreEqual(expectedIN, inchesResults, 6);
        }

        [TestMethod]
        public void GetInchesFromFeet_ReturnsInches()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal feet = 1M;
            decimal inches = converter.GetInches(feet, Models.Enums.DistanceUnits.Foot);

            decimal expectedIN = feet * inchesInFoot;

            Assert.AreEqual(expectedIN, inches, 6);
        }

        [TestMethod]
        public void GetInchesFromYards_ReturnsInches()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal yd = 1M;
            decimal inches = converter.GetInches(yd, Models.Enums.DistanceUnits.Yard);

            decimal expectedIN = yd * inchesInYard;

            Assert.AreEqual(expectedIN, inches, 6);
        }

        [TestMethod]
        public void GetInchesFromMiles_ReturnsInches()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mi = 1M;
            decimal inches = converter.GetInches(mi, Models.Enums.DistanceUnits.Mile);

            decimal expectedIN = (mi * feetInMile) * inchesInFoot;

            Assert.AreEqual(expectedIN, inches, 6);
        }


        [TestMethod]
        public void GetFeetFromMillimeters_ReturnsFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mm = 1M;
            decimal inchesResults = converter.GetFeet(mm, Models.Enums.DistanceUnits.Millimeter);

            decimal expectedIN = (mm / 1000M) * inchesInMeter;

            Assert.AreEqual(expectedIN, inchesResults, 6);
        }

        [TestMethod]
        public void GetFeetFromCentimeters_ReturnsFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal cm = 1M;
            decimal inches = converter.GetFeet(cm, Models.Enums.DistanceUnits.Centimeter);

            decimal expectedIN = (cm * 100M) / inchesInMeter;

            Assert.AreEqual(expectedIN, inches, 6);
        }

        [TestMethod]
        public void GetFeetFromMeters_ReturnsFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal m = 1M;
            decimal ftResults = converter.GetFeet(m, Models.Enums.DistanceUnits.Meter);

            decimal expectedFT = (m * inchesInMeter) / inchesInFoot;

            Assert.AreEqual(expectedFT, ftResults, 6);
        }

        [TestMethod]
        public void GetFeetFromKilometers_ReturnsFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal km = 1M;
            decimal ftResults = converter.GetFeet(km, Models.Enums.DistanceUnits.Kilometer);

            decimal expectedFT = (km / milesInKilometer) * feetInMile;

            Assert.AreEqual(expectedFT, ftResults, 6);
        }

        [TestMethod]
        public void GetFeetFromInches_ReturnsFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal inches = 1M;
            decimal inchesResults = converter.GetFeet(inches, Models.Enums.DistanceUnits.Inch);

            decimal expectedIN = inches;

            Assert.AreEqual(expectedIN, inchesResults, 6);
        }

        [TestMethod]
        public void GetFeetFromFeet_ReturnsFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal feet = 1M;
            decimal ftResults = converter.GetFeet(feet, Models.Enums.DistanceUnits.Foot);

            decimal expectedIN = feet;

            Assert.AreEqual(expectedIN, ftResults, 6);
        }

        [TestMethod]
        public void GetFeetFromYards_ReturnsFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal yd = 1M;
            decimal ftResults = converter.GetFeet(yd, Models.Enums.DistanceUnits.Yard);

            decimal expectedFT = (yd * inchesInYard) / inchesInFoot;

            Assert.AreEqual(expectedFT, ftResults, 6);
        }

        [TestMethod]
        public void GetFeetFromMiles_ReturnsFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mi = 1M;
            decimal inches = converter.GetFeet(mi, Models.Enums.DistanceUnits.Mile);

            decimal expectedIN = (mi * feetInMile);

            Assert.AreEqual(expectedIN, inches, 6);
        }


        [TestMethod]
        public void GetYardsFromMillimeters_ReturnsYards()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mm = 1M;
            decimal ydResults = converter.GetYards(mm, Models.Enums.DistanceUnits.Millimeter);

            decimal expectedYD = ((mm / 1000M) * inchesInMeter) / inchesInYard;

            Assert.AreEqual(expectedYD, ydResults, 6);
        }

        [TestMethod]
        public void GetYardsFromCentimeters_ReturnsYards()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal cm = 1M;
            decimal inches = converter.GetYards(cm, Models.Enums.DistanceUnits.Centimeter);

            decimal expectedIN = (cm * 100M) / inchesInMeter;

            Assert.AreEqual(expectedIN, inches, 6);
        }

        [TestMethod]
        public void GetYardsFromMeters_ReturnsYards()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal m = 1M;
            decimal ydResults = converter.GetYards(m, Models.Enums.DistanceUnits.Meter);

            decimal expectedYD = (m * inchesInMeter) / inchesInYard;

            Assert.AreEqual(expectedYD, ydResults, 6);
        }

        [TestMethod]
        public void GetYardsFromKilometers_ReturnsYards()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal km = 1M;
            decimal ydResults = converter.GetYards(km, Models.Enums.DistanceUnits.Kilometer);

            decimal expectedYD = ((km * 1000M) * inchesInMeter) / inchesInYard;

            Assert.AreEqual(expectedYD, ydResults, 6);
        }

        [TestMethod]
        public void GetYardsFromInches_ReturnsYards()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal inches = 1M;
            decimal inchesResults = converter.GetYards(inches, Models.Enums.DistanceUnits.Inch);

            decimal expectedIN = inches;

            Assert.AreEqual(expectedIN, inchesResults, 6);
        }

        [TestMethod]
        public void GetYardsFromFeet_ReturnsYards()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal feet = 1M;
            decimal ydResults = converter.GetYards(feet, Models.Enums.DistanceUnits.Foot);

            decimal expectedYD = (feet * inchesInFoot) / inchesInYard;

            Assert.AreEqual(expectedYD, ydResults, 6);
        }

        [TestMethod]
        public void GetYardsFromYards_ReturnsYards()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal yd = 1M;
            decimal ydResults = converter.GetYards(yd, Models.Enums.DistanceUnits.Yard);

            decimal expectedYD = yd;

            Assert.AreEqual(expectedYD, ydResults, 6);
        }

        [TestMethod]
        public void GetYardsFromMiles_ReturnsYards()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mi = 1M;
            decimal ydResults = converter.GetYards(mi, Models.Enums.DistanceUnits.Mile);

            decimal expectedYD = ((mi * feetInMile) * inchesInFoot) / inchesInYard;

            Assert.AreEqual(expectedYD, ydResults, 6);
        }


        [TestMethod]
        public void GetMilesFromMillimeters_ReturnsMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mm = 1M;
            decimal miResults = converter.GetMiles(mm, Models.Enums.DistanceUnits.Millimeter);

            decimal expectedMI = (((mm / 1000M) * inchesInMeter) / inchesInFoot) / feetInMile ;

            Assert.AreEqual(expectedMI, miResults, 10);
        }

        [TestMethod]
        public void GetMilesFromCentimeters_ReturnsMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal cm = 1M;
            decimal miResults = converter.GetMiles(cm, Models.Enums.DistanceUnits.Centimeter);

            decimal expectedIN = (((cm * 100M) / inchesInMeter) / inchesInFoot) / feetInMile;

            Assert.AreEqual(expectedIN, miResults, 10);
        }

        [TestMethod]
        public void GetMilesFromMeters_ReturnsMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal m = 1M;
            decimal miResults = converter.GetMiles(m, Models.Enums.DistanceUnits.Meter);

            decimal expectedMI = ((m * inchesInMeter) / inchesInFoot) / feetInMile;

            Assert.AreEqual(expectedMI, miResults, 10);
        }

        [TestMethod]
        public void GetMilesFromKilometers_ReturnsMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal km = 1M;
            decimal miResults = converter.GetMiles(km, Models.Enums.DistanceUnits.Kilometer);

            decimal expectedMI = km * milesInKilometer;

            Assert.AreEqual(expectedMI, miResults, 10);
        }

        [TestMethod]
        public void GetMilesFromInches_ReturnsMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal inches = 1M;
            decimal miResults = converter.GetMiles(inches, Models.Enums.DistanceUnits.Inch);

            decimal expectedMI = inches / inchesInFoot / feetInMile;

            Assert.AreEqual(expectedMI, miResults, 10);
        }

        [TestMethod]
        public void GetMilesFromFeet_ReturnsMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal feet = 1M;
            decimal miResults = converter.GetMiles(feet, Models.Enums.DistanceUnits.Foot);

            decimal expectedMI = feet / feetInMile;

            Assert.AreEqual(expectedMI, miResults, 10);
        }

        [TestMethod]
        public void GetMilesFromYards_ReturnsMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal yd = 1M;
            decimal miResults = converter.GetMiles(yd, Models.Enums.DistanceUnits.Yard);

            decimal expectedMI = (yd / inchesInYard) / inchesInFoot / feetInMile;

            Assert.AreEqual(expectedMI, miResults, 10);
        }

        [TestMethod]
        public void GetMilesFromMiles_ReturnsMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            decimal mi = 1M;
            decimal miResults = converter.GetMiles(mi, Models.Enums.DistanceUnits.Mile);

            decimal expectedMI = mi;

            Assert.AreEqual(expectedMI, miResults, 10);
        }

    }
}
