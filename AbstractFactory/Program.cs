using AbstractFactoryPattern.Implementation;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            IAbstractFactory someStyleFactory = new SomeStyleProductFactory();
            var someStyleProductA = someStyleFactory.CreateProductA("123");
            var someStyleProductB = someStyleFactory.CreateProductB(123);
            IAbstractFactory someOtherStyleFactory = new SomeOtherStyleProductFactory();
            var someOtherStyleProductA = someOtherStyleFactory.CreateProductA("123");
            var someOtherStyleProductB = someStyleFactory.CreateProductB(123);

        }

    }

}