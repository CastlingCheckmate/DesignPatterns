using ChainOfResponsibilityPattern.Implementations;

namespace ChainOfResponsibilityPattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            var handler1 = new ConcreteHandler<int>(i => i > 5);
            var handler2 = new ConcreteHandler<int>(i => i % 6 == 7);
            handler1.Next = handler2;
        }

    }

}