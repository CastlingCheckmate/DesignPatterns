using System;

using BridgePattern.Interfaces;

namespace BridgePattern.Implementations
{

    public sealed class ConcreteAbstraction1 : IAbstraction
    {

        private IImplementation _implementation;

        public ConcreteAbstraction1(IImplementation implementation)
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
            Console.WriteLine("Operation from ConcreteAbstraction1 is called...");
        }

    }

}