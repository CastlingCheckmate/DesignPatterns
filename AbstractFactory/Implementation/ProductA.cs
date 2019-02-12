using AbstractFactoryPattern.Enumerations;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Implementation
{

    public sealed class ProductA : IProduct
    {

        #region Fields

        private ProductStyles _style;
        private string _productAValue;

        #endregion

        #region Constructors

        public ProductA(ProductStyles style, string value)
        {
            Style = style;
            ProductAValue = value;
        }

        #endregion

        #region Properties

        public ProductStyles Style
        {
            get => _style;

            private set => _style = value;
        }

        public string ProductAValue
        {
            get => _productAValue;

            private set => _productAValue = value;
        }

        #endregion

    }

}