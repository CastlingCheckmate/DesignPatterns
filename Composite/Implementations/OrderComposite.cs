using System.Collections.Generic;
using System.Linq;

using CompositePattern.Interfaces;

namespace CompositePattern.Implementations
{

    public sealed class OrderComposite : IOrderComponent
    {

        private double _cost;
        private IEnumerable<IOrderComponent> _children;

        public OrderComposite(double cost = default(double))
        {
            _cost = cost;
            _children = Enumerable.Empty<IOrderComponent>();
        }

        public double Cost =>
            _cost + _children.Select(c => c.Cost).Aggregate((_1, _2) => _1 + _2);

        public OrderComposite Add(IOrderComponent component)
        {
            _children = _children.Concat(new[] { component });
            return this;
        }

        public OrderComposite Remove(IOrderComponent component)
        {
            _children = _children.Where(child => !ReferenceEquals(child, component));
            return this;
        }

    }

}