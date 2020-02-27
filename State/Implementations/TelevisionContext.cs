using System;

using StatePattern.Interfaces;

namespace StatePattern.Implementations
{

    public sealed class TelevisionContext : ITelevisionContext
    {

        private ITelevisionState _state;

        public ITelevisionState State
        {
            get =>
                _state;
        }

    }

}