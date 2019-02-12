using AbstractFactoryPattern.Enumerations;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Implementation
{

    public class SomeOtherStyleProductFactory : IAbstractFactory
    {

        public IProduct CreateProductA(string value)
        {
            return new ProductA(ProductStyles.SomeOtherProductStyle, value);
        }

        public IProduct CreateProductB(int value)
        {
            return new ProductB(ProductStyles.SomeOtherProductStyle, value);
        }

    }

}