using System;

using FlyweightPattern.Interfaces;

namespace FlyweightPattern.Implementations
{

    public sealed class FlyweightOfT<T> : IFlyweightOfT<T>
        where T : class, IEquatable<T>
    {

        private T _innerState;

        public FlyweightOfT(T innerState)
        {
            _innerState = innerState;
        }

        public T InnerState =>
            _innerState;

    }

}