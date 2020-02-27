using System;

namespace ChainOfResponsibilityPattern.Implementations
{

    public sealed class ConcreteHandler<T> : BaseHandler<T>
    {

        public ConcreteHandler(Func<T, bool> predicate)
            : base(predicate)
        {

        }

        public override bool Handle(T request)
        {
            return Predicate(request);
        }
        
    }

}