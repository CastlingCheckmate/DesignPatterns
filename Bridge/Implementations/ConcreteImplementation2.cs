using System;

using BridgePattern.Interfaces;

namespace BridgePattern.Implementations
{
    public sealed class ConcreteImplementation2 : IImplementation
    {

        public void DoOperation1()
        {
            Console.WriteLine("DoOperation1() from ConcreteImplementation2...");
        }

        public void DoOperation2()
        {
            Console.WriteLine("DoOperation2() from ConcreteImplementation2...");
        }

    }

}