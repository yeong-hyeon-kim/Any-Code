namespace PDelegate
{
    delegate void TestDelegate(int Number);
    class Program
    {
        static void main(string[] args)
        {
            #region Lamda
            // Lamda
            Action<int, int>? RamdaA = (int x, int y) => Add(x, y);
            Action<int, int>? RamdaB = (x, y) => { Console.WriteLine(x + y); };
            Func<int, int, int>? RamdaC = (x, y) => { return x + y; };

            RamdaA(1234, 5678);
            RamdaB(1234, 5678);

            // 무명 메서드
            var RamdaD = delegate (int x, int y)
            {
                Console.WriteLine(x + y);
            };

            RamdaD(1234, 5678);

            #endregion

            #region Action,Func
            // Action<T>,Func<T>,<TResult>
            Action<int> test = new Action<int>(WriteConsole);
            test(1234);
            // 1234
            #endregion

            #region Delegate Chain
            // 델리게이트 체인 적용.
            var Chain = new Action<int, int>(Add);
            Chain += new Action<int, int>(Minus);
            Chain += new Action<int, int>(Division);
            Chain += new Action<int, int>(Multiply);

            Chain(1234, 5678);

            // 델리게이트 체인 미적용.
            Add(1234, 5678);
            Minus(1234, 5678);
            Division(1234, 5678);
            Multiply(1234, 5678);
            #endregion
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
            Console.WriteLine(Number);
        }
    }
}