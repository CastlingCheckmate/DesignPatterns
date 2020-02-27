namespace StrategyPattern.Interfaces
{

    public interface IHashAlgorithmStrategy
    {

        byte[] Hash(byte[] dataToHash);

    }

}