namespace DecoratorPattern.Interfaces
{

    public interface ICalculator
    {

        double Sum(double firstSummand, double secondSummand);
        double Subtraction(double minuend, double subtrahend);
        double Multiplication(double firstFactor, double secondFactor);
        double Division(double dividend, double divider);
        double ModuloDivision(double dividend, double divider);

    }

}