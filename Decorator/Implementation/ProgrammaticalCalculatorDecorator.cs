using System;

using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Implementation
{

    internal sealed class ProgrammaticalCalculatorDecorator : CalculatorDecorator
    {

        public ProgrammaticalCalculatorDecorator(ICalculator calculator)
            : base(calculator)
        {

        }

        public double SomeOperationOfProgrammaticalCalculator()
        {
            var randomSource = new Random();
            return randomSource.NextDouble() * randomSource.Next(); 
        }

    }

}