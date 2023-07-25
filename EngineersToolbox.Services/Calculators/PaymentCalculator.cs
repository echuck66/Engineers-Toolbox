using EngineersToolbox.Models;
using EngineersToolbox.Models.Enums;
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
            if (interestRate <= 0)
            {
                return 0;
            }

            decimal termRate = 0;

            switch(frequency)
            {
                case PaymentFrequency.Daily:
                    termRate = interestRate / 356;
                    break;
                case PaymentFrequency.Weekly:
                    termRate = interestRate / 52;
                    break;
                case PaymentFrequency.SemiWeekly:
                    termRate = interestRate / 26;
                    break;
                case PaymentFrequency.SemiMonthly:
                    termRate = interestRate / 24;
                    break;
                case PaymentFrequency.Monthly:
                    termRate = interestRate / 12;
                    break;
                case PaymentFrequency.Annually:
                    termRate = interestRate;
                    break;
            }

            double dblTerm = Convert.ToDouble(term);
            double dblTermRate = Convert.ToDouble(termRate);
            double dblPrincipal = Convert.ToDouble(principal);

            double dblPayment = (dblTermRate * dblPrincipal) / (1 - Math.Pow((1 + dblTermRate), (-1 * dblTerm)));

            decimal payment = Convert.ToDecimal(dblPayment);

            return payment;
        }
    }
}
