using EngineersToolbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Services.Calculators
{
    public class PaymentCalculator : ICalculator
    {
        private ToolType _toolType;
        public ToolType ToolType { get { return _toolType; } }

        private CalculatorType _calculatorType;
        public CalculatorType CalculatorType { get { return _calculatorType; } }

        public PaymentCalculator()
        {
            _toolType = ToolType.Calculator;
            _calculatorType = CalculatorType.Payment;
        }

        public decimal GetPayment(int term, PaymentFrequency frequency, decimal principal, decimal interestRate)
        {
            return 0;
        }
    }
}
