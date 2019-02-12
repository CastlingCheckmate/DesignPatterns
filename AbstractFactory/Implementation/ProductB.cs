using AbstractFactoryPattern.Enumerations;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Implementation
{

    public sealed class ProductB : IProduct
    {

        #region Fields

        private ProductStyles _style;
        private int _productBValue;

        #endregion

        #region Constructors

        public ProductB(ProductStyles style, int value)
        {
            Style = style;
            ProductBValue = value;
        }

        #endregion

        #region Properties

        public ProductStyles Style
        {
            get => _style;

            private set => _style = value;
        }

        public int ProductBValue
        {
            get => _productBValue;

            private set => _productBValue = value;
        }

        #endregion

    }

}