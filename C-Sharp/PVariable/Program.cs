namespace Variable
{
    class Program
    {
        const int FixValue = 1234;
        readonly int VarValue = 5678;

        public Program()
        {
            Console.WriteLine("초기값 : " + VarValue);
            VarValue = 1234;
        }

        static void Main(string[] args)
        {
            //FixValue = 5678;

            Program program = new Program();
            Console.WriteLine("할당값 : " + program.VarValue);
        }
    }
}