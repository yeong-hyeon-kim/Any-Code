namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }

        static async void RunTask()
        {
            Task TasksA = Task.Run(() => TaskA());
            Task TasksB = Task.Run(() => TaskB());
            Task TasksC = Task.Run(() => TaskC());
            Task<string> TasksD = Task.Run(() => TaskD());

            // ASync 비동기 실행

            // 반환 값이 없을 경우 Task.Wait()로 작업이 완료될때까지 대기.

            // Tasks A가 종료될때까지 대기 하세요.
            TasksA.Wait();
            // Tasks B가 종료될때까지 대기 하세요.
            TasksB.Wait();
            // Tasks C가 종료될때까지 대기 하세요.
            TasksC.Wait();
            // Tasks D가 종료될때까지 대기 하세요.
            TasksD.Wait();

            // await 키워드는 반환 값이 있을 때 사용.
            // await 키워드로 대기하고 반환 값 할당.
            string text = await TasksD;

            // Sync 동기 실행
            // TaskA();
            // TaskB();
            // TaskC();
        }

        static async void TaskA()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Task A 종료!");
        }

        static async void TaskB()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Task B 종료!");
        }

        static async void TaskC()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Task C 종료!");
        }

        static async Task<string> TaskD()
        {
            Thread.Sleep(500);
            Console.WriteLine("Task D 종료!");

            return "Task D 종료!";
        }
    }
}