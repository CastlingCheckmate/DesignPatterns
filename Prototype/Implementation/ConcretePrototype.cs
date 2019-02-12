using PrototypePattern.Interface;

namespace PrototypePattern.Implementation
{

    internal class ConcretePrototype : IPrototype
    {

        #region Fields

        private int _value;

        #endregion

        #region Constructors

        public ConcretePrototype(int value)
        {
            _value = value;
        }

        private ConcretePrototype(ConcretePrototype obj)
            : this(obj._value)
        {
            
        }

        #endregion

        #region Properties

        public int Value =>
            _value;

        #endregion

        #region Object class virtual members reimplementation

        public override string ToString()
        {
            return $"{{{Value}}}";
        }

        #endregion

        #region IPrototype interface implementation

        public IPrototype Clone()
        {
            return new ConcretePrototype(this);
        }

        #endregion

    }

}