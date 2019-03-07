using FlyweightPattern.Implementations;

namespace FlyweightPattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            FlyweightContainer<Color>.Instance.TryGetFlyweight(new Color(1, 2, 3, 4), out var a);
            FlyweightContainer<Color>.Instance.TryGetFlyweight(new Color(5, 6, 7, 8), out var b);
            FlyweightContainer<Color>.Instance.TryGetFlyweight(new Color(1, 2, 3, 4), out var c);
            FlyweightContainer<Color>.Instance.TryGetFlyweight(new Color(1, 2, 3, 4), out var d);
        }

    }

}