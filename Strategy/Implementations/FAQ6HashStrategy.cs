using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Implementations
{

    public sealed class FAQ6HashStrategy : IHashAlgorithmStrategy
    {

        public byte[] Hash(byte[] dataToHash)
        {
            var hash = default(uint);
            foreach (var @byte in dataToHash)
            {
                hash += @byte;
                hash += hash << 10;
                hash ^= hash >> 6;
            }
            hash += hash << 3;
            hash ^= hash >> 11;
            hash += hash << 15;
            return BitConverter.GetBytes(hash);
        }

    }

}