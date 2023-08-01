using EngineersToolbox.Services.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Tests
{
    [TestClass]
    public class AngleConverterTests
    {
        const decimal deg0Rad = 0M;
        const decimal deg30Rad = 0.524M;
        const decimal deg45Rad = 0.785M;
        const decimal deg60Rad = 1.047M;
        const decimal deg90Rad = 1.571M;
        const decimal deg120Rad = 2.094M;
        const decimal deg150Rad = 2.618M;
        const decimal deg180Rad = 3.14M;
        const decimal deg210Rad = 3.665M;
        const decimal deg270Rad = 4.713M;
        const decimal deg360Rad = 6.283M;

        const decimal deg0 = 0M;
        const decimal deg30 = 30M;
        const decimal deg45 = 45M;
        const decimal deg60 = 60M;
        const decimal deg90 = 90M;
        const decimal deg120 = 120M;
        const decimal deg150 = 150M;
        const decimal deg180 = 180M;
        const decimal deg210 = 210M;
        const decimal deg270 = 270M;
        const decimal deg360 = 360M;

        [TestMethod]
        public void GetRadiansTest_ReturnsRadians()
        {
            AngleConverter converter = new AngleConverter();

            var test0 = converter.GetRadians(deg0);
            Assert.AreEqual(deg0Rad, test0, 3);
            var test30 = converter.GetRadians(deg30);
            Assert.AreEqual(deg30Rad, test30, 3);
            var test45 = converter.GetRadians(deg45);
            Assert.AreEqual(deg45Rad, test45, 3);
            var test60 = converter.GetRadians(deg60);
            Assert.AreEqual(deg60Rad, test60, 3);
            var test90 = converter.GetRadians(deg90);
            Assert.AreEqual(deg90Rad, test90, 3);
            var test120 = converter.GetRadians(deg120);
            Assert.AreEqual(deg120Rad, test120, 3);
            var test150 = converter.GetRadians(deg150);
            Assert.AreEqual(deg150Rad, test150, 3);
            var test180 = converter.GetRadians(deg180);
            Assert.AreEqual(deg180Rad, test180, 3);
            var test210 = converter.GetRadians(deg210);
            Assert.AreEqual(deg210Rad, test210, 3);
            var test270 = converter.GetRadians(deg270);
            Assert.AreEqual(deg270Rad, test270, 3);
            var test360 = converter.GetRadians(deg360);
            Assert.AreEqual(deg360Rad, test360, 3);

            
        }

        [TestMethod]
        public void GetDegreesTest_ReturnsDegrees()
        {
            AngleConverter converter = new AngleConverter();

            var test0 = converter.GetDegrees(deg0Rad);
            Assert.AreEqual(deg0, test0, 3);
            var test30 = converter.GetDegrees(deg30Rad);
            Assert.AreEqual(deg30, test30, 3);
            var test45 = converter.GetDegrees(deg45Rad);
            Assert.AreEqual(deg45, test45, 3);
            var test60 = converter.GetDegrees(deg60Rad);
            Assert.AreEqual(deg60, test60, 3);
            var test90 = converter.GetDegrees(deg90Rad);
            Assert.AreEqual(deg90, test90, 3);
            var test120 = converter.GetDegrees(deg120Rad);
            Assert.AreEqual(deg120, test120, 3);
            var test150 = converter.GetDegrees(deg150Rad);
            Assert.AreEqual(deg150, test150, 3);
            var test180 = converter.GetDegrees(deg180Rad);
            Assert.AreEqual(deg180, test180, 3);
            var test210 = converter.GetDegrees(deg210Rad);
            Assert.AreEqual(deg210, test210, 3);
            var test270 = converter.GetDegrees(deg270Rad);
            Assert.AreEqual(deg270, test270, 3);
            var test360 = converter.GetDegrees(deg360Rad);
            Assert.AreEqual(deg360, test360, 3);


        }

    }
}
