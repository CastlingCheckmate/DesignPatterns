using AbstractFactoryPattern.Enumerations;

namespace AbstractFactoryPattern.Interfaces
{

    public interface IProduct
    {

        ProductStyles Style
        {
            get;
        }

    }

}