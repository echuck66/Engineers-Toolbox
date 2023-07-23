using EngineersToolbox.Services.Converters;

namespace EngineersToolbox.Tests
{
    [TestClass]
    public class Base64ConverterTests
    {
        [TestMethod]
        public void HashValue_ReturnsHashedValue()
        {
            var value = "ABCDEFHIGJKLMNOPQRSTUVXYZ1234567890";
            var valueBytes = System.Text.Encoding.UTF8.GetBytes(value);
            var hashedValue = System.Convert.ToBase64String(valueBytes);


            var converter = new Base64Converter();

            var hashedResults = converter.HashValue(value);
            Assert.IsNotNull(hashedResults);
            Assert.AreEqual(hashedValue, hashedResults.HashedValue);
            Assert.AreNotEqual(hashedResults.Value, hashedResults.HashedValue);
        }

        [TestMethod]
        public void GetValue_ReturnsValue()
        {
            var value = "ABCDEFHIGJKLMNOPQRSTUVXYZ1234567890";
            var valueBytes = System.Text.Encoding.UTF8.GetBytes(value);
            var hashedValue = System.Convert.ToBase64String(valueBytes);

            var converter = new Base64Converter();

            var valueResults = converter.GetValue(hashedValue);
            Assert.IsNotNull(valueResults);
            Assert.AreEqual(value, valueResults.Value);
            Assert.AreNotEqual(valueResults.Value, valueResults.HashedValue);

        }

        [TestMethod]
        public void HashValue_ReturnsNULL()
        {
            string? value = null;
            string? hashedValue = null;


            var converter = new Base64Converter();

            var hashedResults = converter.HashValue(value);
            Assert.IsNotNull(hashedResults);
            Assert.IsNull(hashedResults.HashedValue);
            
        }

        [TestMethod]
        public void GetValue_ReturnsNULL()
        {
            string? value = null;
            string? hashedValue = null;

            var converter = new Base64Converter();

            var valueResults = converter.GetValue(hashedValue);
            Assert.IsNotNull(valueResults);
            Assert.IsNull(valueResults.Value);

        }
    }
}