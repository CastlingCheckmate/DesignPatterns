using System;
using System.Threading.Tasks;

using SingletonPattern.Implementation;

namespace SingletonPattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            Parallel.For(0, Environment.ProcessorCount, (i) =>
            {
                Singleton.Instance.Equals(Singleton.Instance);
            });
        }

    }

}