using System;

using ProxyPattern.Interfaces;

namespace ProxyPattern.Implementations
{

    public class ConcreteService : IService
    {

        public void SomeOperation()
        {
            Console.WriteLine("SomeOperation() method called...");
        }

        public void SomeOtherOperation()
        {
            Console.WriteLine("SomeOtherOperation() method called...");
        }

    }

}