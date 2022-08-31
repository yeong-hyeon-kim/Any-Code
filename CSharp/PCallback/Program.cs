namespace PCallback
{
    delegate void EventHandler(int i);

    class Publisher
    {
        public event EventHandler Active;

        public void Work(int iNum)
        {
            if (Active != null)
            {
                if (iNum % 2 == 1)
                {
                    Active(iNum);
                }
            }
        }
    }

    // 콜백(Callback) 함수
    // 1. 다른 함수의 인자로써 이용되는 함수.
    // 2. 어떤 이벤트에 의해 호출되어지는 함수.

    class Program
    {
        static void Main(string[] args)
        {
            Action<Action> CallBackTest = (Action Callback) =>
            {
                Callback();
                Console.WriteLine("");
            };

            // Write 메서드는 CallBackTest 함수 인자로 사용되므로 콜백 함수이다.
            CallBackTest(Write);

            Publisher publisher = new Publisher();
            //CheckOld 메서드는 Active 이벤트에 의해 호출되므로 콜백 함수이다.
            publisher.Active += new EventHandler(CheckOld);

            publisher.Work(5);
        }

        static void Write()
        {
            Console.WriteLine("Write!");
        }

        static void CheckEven(int iNum)
        {
            Console.WriteLine(iNum + " : 짝수 입니다!");
        }

        static void CheckOld(int iNum)
        {
            Console.WriteLine(iNum + " : 는 홀수 입니다!");
        }
    }
}