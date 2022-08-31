namespace PConditionalStatements
{

    class Program
    {
        static void Main()
        {
            IfConditional();
            SwitchConditional();
        }

        static void IfConditional()
        {
            bool ConditionalA = true;
            bool ConditionalB = true;

            // if
            if (ConditionalA)
                Console.WriteLine("TRUE!");

            // if else
            if (ConditionalA)
            {
                Console.WriteLine("TRUE!");
            }
            else
            {
                Console.WriteLine("FALSE!");
            }

            // if else if
            if (ConditionalA)
            {
                Console.WriteLine("TRUE!");
            }
            else if (ConditionalB)
            {
                Console.WriteLine("ELSE TRUE!");
            }
            else
            {
                Console.WriteLine("ALL FALSE!");
            }
        }

        static void SwitchConditional()
        {
            string Animal = "북극곰";

            switch (Animal)
            {
                case "북극곰":
                    Console.WriteLine(Animal);
                    break;
                case "불곰":
                    Console.WriteLine(Animal);
                    break;
                case "반달곰":
                    Console.WriteLine(Animal);
                    break;
                default:
                    Console.WriteLine(Animal);
                    break;
            }
        }
    }
}