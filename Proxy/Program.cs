using System;
using System.Threading.Tasks;

using ProxyPattern.Implementations;

namespace ProxyPattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            var service = new ConcreteService();
            var proxy = new ProxyService(service);
            Parallel.For(0, 3, i =>
            {
                proxy.SomeOperation();
                proxy.SomeOtherOperation();
            });
            foreach (var log in proxy.Logs)
            {
                Console.WriteLine($"    {log}");
            }
        }

    }

}