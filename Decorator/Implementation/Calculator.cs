using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Implementation
{

    public sealed class Calculator : ICalculator
    {

        public double Sum(double firstSummand, double secondSummand)
        {
            return firstSummand + secondSummand;
        }

        public double Subtraction(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public double Multiplication(double firstFactor, double secondFactor)
        {
            return firstFactor * secondFactor;
        }

        public double Division(double dividend, double divider)
        {
            return dividend / divider;
        }

        public double ModuloDivision(double dividend, double divider)
        {
            return dividend % divider;
        }

    }

}