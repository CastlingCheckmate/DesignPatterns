using AbstractFactoryPattern.Enumerations;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Implementation
{

    public class SomeStyleProductFactory : IAbstractFactory
    {

        public IProduct CreateProductA(string value)
        {
            return new ProductA(ProductStyles.SomeProductStyle, value);
        }

        public IProduct CreateProductB(int value)
        {
            return new ProductB(ProductStyles.SomeProductStyle, value);
        }

    }

}