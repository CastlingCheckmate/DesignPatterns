using CompositePattern.Interfaces;

namespace CompositePattern.Implementations
{

    public abstract class OrderLeaf : IOrderComponent
    {

        public abstract double Cost
        {
            get;
        }

    }

}