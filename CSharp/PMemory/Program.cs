namespace PMemory
{
    class Program
    {
        static string FieldText = "";

        static void Main()
        {
            Action action = () =>
            {
                Console.WriteLine("Memory");
            };
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

        static void WriteConsole(int Number)
        {
            string PreFix = "Value : ";

            try
            {
                Console.WriteLine(PreFix + Number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}