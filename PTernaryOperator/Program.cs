namespace PTernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            int x = 1;
            Console.WriteLine(x == 1 ? "참(True)" : "거짓(False)");

            if (x == 1)
            {
                Console.WriteLine("참(True)");
            }
            else
            {
                Console.WriteLine("거짓(False)");
            }
        }
    }
}