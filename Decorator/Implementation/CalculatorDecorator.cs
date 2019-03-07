using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Implementation
{

    public abstract class CalculatorDecorator : ICalculator
    {

        private ICalculator _calculator;

        public CalculatorDecorator(ICalculator calculator)
        {
            Calculator = calculator;
        }

        protected ICalculator Calculator
        {
            get => _calculator;

            private set => _calculator = value;
        }

        public double Division(double dividend, double divider)
        {
            return Calculator.Division(dividend, divider);
        }

        public double ModuloDivision(double dividend, double divider)
        {
            return Calculator.ModuloDivision(dividend, divider);
        }

        public double Multiplication(double firstFactor, double secondFactor)
        {
            return Calculator.Multiplication(firstFactor, secondFactor);
        }

        public double Subtraction(double minuend, double subtrahend)
        {
            return Calculator.Subtraction(minuend, subtrahend);
        }

        public double Sum(double firstSummand, double secondSummand)
        {
            return Calculator.Sum(firstSummand, secondSummand);
        }

    }

}