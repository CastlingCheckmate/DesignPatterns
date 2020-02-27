using System;

using ChainOfResponsibilityPattern.Interfaces;

namespace ChainOfResponsibilityPattern.Implementations
{

    public class BaseHandler<T> : IHandler<T>
    {

        private IHandler<T> _next;
        private Func<T, bool> _predicate;

        public BaseHandler(Func<T, bool> predicate)
        {
            _predicate = predicate;
        }

        protected Func<T, bool> Predicate =>
            _predicate;

        public IHandler<T> Next
        {
            private get =>
                _next;

            set =>
                _next = value;
        }

        public virtual bool Handle(T request)
        {
            // TODO: ?!
            if (Next != null)
            {
                return Next.Handle(request);
            }
        }

    }

}