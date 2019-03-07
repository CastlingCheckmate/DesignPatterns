using System;
using System.Collections.Generic;
using System.Linq;

using FlyweightPattern.Interfaces;

namespace FlyweightPattern.Implementations
{

    public sealed class FlyweightContainer<T> : IFlyweightContainer<T>
        where T : class, IEquatable<T>
    {

        private static FlyweightContainer<T> _instance;

        public static FlyweightContainer<T> Instance =>
            _instance ?? (_instance = new FlyweightContainer<T>());

        private List<IFlyweightOfT<T>> _cache;

        private FlyweightContainer()
        {
            Cache = new List<IFlyweightOfT<T>>();
        }

        private List<IFlyweightOfT<T>> Cache
        {
            get => _cache;

            set => _cache = value;
        }

        public bool TryGetFlyweight(T innerState, out IFlyweightOfT<T> result)
        {
            var cachedFlyweights = Cache.Where(f => f.InnerState.Equals(innerState));
            if (cachedFlyweights.Count() != 0)
            {
                result = cachedFlyweights.ElementAt(0);
                return true;
            }
            Cache.Add(new FlyweightOfT<T>(innerState));
            result = Cache.Where(f => f.InnerState.Equals(innerState)).ElementAt(0);
            return false;
        }

    }

}