namespace FactoryMethodPattern
{

    internal sealed class SomeClass
    {

        private int _a;

        public SomeClass(int a)
        {
            _a = a;
        }

        public static SomeClass Create(int a)
        {
            return new SomeClass(a);
        }

        public static SomeClass CreateMultipliedBy2(int a)
        {
            return new SomeClass(a * 2);
        }

    }

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            var a = new SomeClass(123);
            var b = SomeClass.Create(123);
            var c = SomeClass.CreateMultipliedBy2(123);
        }

    }

}