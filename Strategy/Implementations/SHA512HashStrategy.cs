using System.Security.Cryptography;

using StrategyPattern.Interfaces;

namespace StrategyPattern.Implementations
{

    public sealed class SHA512HashStrategy : IHashAlgorithmStrategy
    {

        public byte[] Hash(byte[] dataToHash)
        {
            using (var sha4Hash = SHA512.Create())
            {
                return sha4Hash.ComputeHash(dataToHash);
            }
        }

    }

}