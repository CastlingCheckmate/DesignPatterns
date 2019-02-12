using PrototypePattern.Interface;

namespace PrototypePattern.Implementation
{

    internal class InheritedConcretePrototype : ConcretePrototype
    {

        #region Fields

        private string _otherValue;

        #endregion

        #region Constructors

        public InheritedConcretePrototype(int value, string otherValue)
            : base(value)
        {
            _otherValue = otherValue;
        }

        private InheritedConcretePrototype(InheritedConcretePrototype obj)
            : base(obj.Value)
        {
            _otherValue = obj.OtherValue;
        }

        #endregion

        #region Properties

        public string OtherValue =>
            _otherValue;

        #endregion

        #region Object class virtual members reimplementation

        public override string ToString()
        {
            return $"{{{Value}, {OtherValue}}}";
        }

        #endregion

        #region IPrototype interface implementation

        public new IPrototype Clone()
        {
            return new InheritedConcretePrototype(this);
        }

        #endregion

    }

}