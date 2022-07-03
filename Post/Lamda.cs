namespace Post
{
    class Lamda
    {
        static void Main(string[] args)
        {
            Action<int, int>? RamdaA = (int x, int y) => Add(x, y);
            Action<int, int>? RamdaB = (x, y) => { Console.WriteLine(x + y); };
            Func<int, int, int>? RamdaC = (x, y) => { return x + y; };

            RamdaA(12, 12);
            RamdaB(121, 121);

            var RamdaD = delegate (int x, int y)
            {
                Console.WriteLine(x + y);
            };

            RamdaD(1, 2);
        }

        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}