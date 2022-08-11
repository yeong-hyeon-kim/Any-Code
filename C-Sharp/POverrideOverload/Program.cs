namespace OverrideOverloading
{
    class Car
    {
        public virtual void Load()
        {
            Console.WriteLine("Load");
        }

        public virtual void Move()
        {
            Console.WriteLine("Move");
        }
    }

    class Ray : Car
    {
        static void Main(string[] args)
        {
            Car cars = new Car();
            Ray ray = new Ray();

            // Override
            cars.Load();
            ray.Load();

            // Overload
            Add(1234, 5678, 9012);
        }

        override public void Load()
        {
            Console.WriteLine("Ray에 짐을 실어요~");
        }

        override public void Move()
        {
            Console.WriteLine("Ray는 블루레이 처럼 빨라요~");
        }

        static void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
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