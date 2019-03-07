using BridgePattern.Interfaces;
using BridgePattern.Implementations;

namespace BridgePattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            var abstraction = default(IAbstraction);
            var implementation = default(IImplementation);
            implementation = new ConcreteImplementation1();
            abstraction = new ConcreteAbstraction1(implementation);
            abstraction.Implementation.DoOperation1();
            abstraction.Implementation.DoOperation2();
            (abstraction as ConcreteAbstraction1).OperationFromConcreteAbstraction1();
            abstraction = new ConcreteAbstraction2(implementation);
            abstraction = new ConcreteAbstraction2(new ConcreteImplementation2());
            abstraction.Implementation.DoOperation2();
        }

    }

}