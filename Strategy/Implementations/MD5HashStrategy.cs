using System.Security.Cryptography;

using StrategyPattern.Interfaces;

namespace StrategyPattern.Implementations
{

    public sealed class MD5HashStrategy : IHashAlgorithmStrategy
    {

        public byte[] Hash(byte[] dataToHash)
        {
            using (var md5Hash = MD5.Create())
            {
                return md5Hash.ComputeHash(dataToHash);
            }
        }

    }

}