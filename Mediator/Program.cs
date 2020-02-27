using MediatorPattern.Implementations;

namespace MediatorPattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            mediator.A1.TargetComponentAOperation();
            mediator.A2.TargetComponentAOperation();
            mediator.B.TargetComponentAOperation();
            mediator.C.TargetComponentAOperation();
        }

    }

}