using DecoratorPattern.Implementation;

namespace DecoratorPattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var engineeringCalculator = new EngineeringCalculatorDecorator(calculator);
            var programmaticalCalculatorDecorator = new ProgrammaticalCalculatorDecorator(engineeringCalculator);
        }

    }

}