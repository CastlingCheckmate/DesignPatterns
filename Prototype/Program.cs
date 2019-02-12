using System;

using PrototypePattern.Implementation;

namespace PrototypePattern
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            var prototype = new ConcretePrototype(123);
            var fromPrototype = (ConcretePrototype)prototype.Clone();
            Console.WriteLine("{0}: {1}, {2}: {3}", nameof(prototype), prototype, nameof(fromPrototype), fromPrototype);
            var otherPrototype = new InheritedConcretePrototype(456, "string");
            var fromOtherPrototype = (InheritedConcretePrototype)otherPrototype.Clone();
            Console.WriteLine("{0}{1}: {2}, {3}: {4}", Environment.NewLine, nameof(otherPrototype), otherPrototype
                , nameof(fromOtherPrototype), fromOtherPrototype);
        }

    }

}