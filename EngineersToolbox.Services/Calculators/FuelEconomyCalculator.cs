using EngineersToolbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Services.Calculators
{
    public class FuelEconomyCalculator : ICalculator
    {
        private ToolType _toolType;
        public ToolType ToolType { get { return _toolType; } }

        private CalculatorType _calculatorType;
        public CalculatorType CalculatorType { get { return _calculatorType; } }

        public FuelEconomyCalculator()
        {
            _toolType = ToolType.Calculator;
            _calculatorType = CalculatorType.FuelEconomy;
        }
    }
}
