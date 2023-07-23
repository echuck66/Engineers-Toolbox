using EngineersToolbox.Models;
using EngineersToolbox.Services.Calculators;
using EngineersToolbox.Services.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Tests
{
    [TestClass]
    public class PaymentCalculatorTests
    {

        [TestMethod]
        public void GetPayment_ReturnsNonZeroPayment()
        {
            PaymentCalculator calculator = new PaymentCalculator();
            decimal principal = 30000M;
            decimal interestRate = 0.08M;
            int term = 60;
            PaymentFrequency frequency = PaymentFrequency.Monthly;

            decimal payment = calculator.GetPayment(term, frequency, principal, interestRate);

            decimal expectedPayment = 608.29M;

            Assert.AreEqual(expectedPayment, payment, 2);
        }

    }
}
