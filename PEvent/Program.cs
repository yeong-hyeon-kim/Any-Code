namespace PEvent
{
    // 1. 이벤트 핸들러 델리게이트 선언
    delegate void EventHandler(int iNumber);

    // 2. 게시자(이벤트를 발생시키는 클래스) 클래스 선언
    class Publisher
    {
        // 3. 이벤트 선언
        public event EventHandler Active;

        public void ToDoWorks(int iNumber)
        {
            // Active 이벤트에 등록된 이벤트 핸들러가 있는지 확인. 
            if (Active != null)
            {
                if (iNumber % 2 == 0)
                {
                    // 이벤트 발생
                    Active(iNumber);
                }
            }
        }
    }

    // 4. 구독자(이벤트를 반응하는 클래스) 클래스 선언
    class Subscriber
    {
        static public void WriteResult(int iNumber)
        {
            Console.WriteLine(iNumber);
        }

        static void Main(string[] args)
        {
            Publisher pu = new();
            // 5. 이벤트 구독(연결)
            // 이벤트가 발생했을때 EventHandler가 참조하는 메서드를 실행.
            pu.Active += new EventHandler(WriteResult);

            for (int i = 1; i < 100; i++)
            {
                // 이벤트 사용
                pu.ToDoWorks(i);
            }
        }
    }
}