using System;

using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Implementation
{

    internal sealed class EngineeringCalculatorDecorator : CalculatorDecorator
    {

        public EngineeringCalculatorDecorator(ICalculator calculator)
            : base(calculator)
        {

        }

        public double Sqrt(double value)
        {
            return Math.Sqrt(value);
        }

    }

}