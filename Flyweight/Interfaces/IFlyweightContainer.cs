using System;

namespace FlyweightPattern.Interfaces
{

    public interface IFlyweightContainer<T>
        where T : class, IEquatable<T>
    {

        bool TryGetFlyweight(T innerState, out IFlyweightOfT<T> result);

    }

}