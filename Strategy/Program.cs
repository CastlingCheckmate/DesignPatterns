using System;

using StrategyPattern.Interfaces;
using StrategyPattern.Implementations;

namespace StrategyPattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            var randomSource = new Random(12345);
            var dataToHash = new byte[128];
            randomSource.NextBytes(dataToHash);
            IHashAlgorithmStrategy strategy = new MD5HashStrategy();
            var dataHash = strategy.Hash(dataToHash);
            strategy = new FAQ6HashStrategy();
            dataHash = strategy.Hash(dataToHash);
            strategy = new SHA512HashStrategy();
            dataHash = strategy.Hash(dataToHash);
        }

    }

}