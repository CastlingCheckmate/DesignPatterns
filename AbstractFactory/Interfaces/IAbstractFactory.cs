namespace AbstractFactoryPattern.Interfaces
{

    public interface IAbstractFactory
    {

        IProduct CreateProductA(string value);
        IProduct CreateProductB(int value);

    }

}