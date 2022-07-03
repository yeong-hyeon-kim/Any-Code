namespace Post
{
    delegate void Batch(int x, int y);

    class MethodChain
    {
        static void Main(string[] args)
        {
            var t = new Batch(Add);
            t += new Batch(Minus);
            t += new Batch(Division);
            t += new Batch(Multiply);

            t(1234,5678);

            Add(1234,5678);
            Minus(1234,5678);
            Division(1234,5678);
            Multiply(1234,5678);
        }

        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Minus(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void Division(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
    }
}
