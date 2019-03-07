using System;

using BridgePattern.Interfaces;

namespace BridgePattern.Implementations
{

    public sealed class ConcreteAbstraction2 : IAbstraction
    {

        private IImplementation _implementation;

        public ConcreteAbstraction2(IImplementation implementation)
        {
            Implementation = implementation;
        }

        public IImplementation Implementation
        {
            get => _implementation ??
                throw new ArgumentNullException(nameof(Implementation));

            private set => _implementation = value;
        }

        public void OperationFromConcreteAbstraction1()
        {
            Console.WriteLine("Operation from ConcreteAbstraction2 is called...");
        }

    }

}