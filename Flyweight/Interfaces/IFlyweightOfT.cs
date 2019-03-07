using System;

namespace FlyweightPattern.Interfaces
{

    public interface IFlyweightOfT<T>
        where T : class, IEquatable<T>
    {
        
        T InnerState
        {
            get;
        }

    }

}