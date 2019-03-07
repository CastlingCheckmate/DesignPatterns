using CompositePattern.Implementations;

namespace CompositePattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            var order = new OrderComposite();
            var box1 = new OrderComposite(5);
            var box2 = new OrderComposite(10);
            var nestedBox1 = new OrderComposite(2);
            order.Add(box1).Add(box2);
            box1.Add(nestedBox1);
            nestedBox1.Add(new OrderLeafOfType1()).Add(new OrderLeafOfType2());
            box1.Add(new OrderLeafOfType1());
            box2.Add(new OrderLeafOfType2());
            System.Console.Write(order.Cost);
        }

    }

}