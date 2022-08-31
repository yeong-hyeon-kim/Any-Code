namespace PGeneric
{
    public class Program
    {
        const int Capacity = 5;

        static Stack<string> stack = new Stack<string>(Capacity);
        static Queue<string> queue = new Queue<string>(Capacity);

        static void Main(string[] arg)
        {
            //AddListArray();
            //AddDictionary();

            //StackPush();
            //StackPop();

            QueueEnqueue();
            QueueDequeue();
        }

        static void QueueEnqueue()
        {
            for (int i = 0; i < Capacity; i++)
            {
                queue.Enqueue("Dequeue : " + i);
                Console.WriteLine("Enqueue : " + i);
            }
        }

        static void QueueDequeue()
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        static void StackPush()
        {
            for (int i = 0; i <= Capacity; i++)
            {
                stack.Push(i.ToString());
                Console.WriteLine("STACK [" + i + "] = " + i);
            }
        }

        static void StackPop()
        {
            for (int i = 0; i <= Capacity; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        static void StackOverflow()
        {
            try
            {
                stack.Push("Item");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void StackUnderflow()
        {
            try
            {
                stack.Pop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void AddDictionary()
        {
            // Dictionary<KeyType, ValueType> dic = new Dictionary<KeyType, ValueType>();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Key A", "Value A");
            // 중복된 키 삽입 시 에러 발생.
            dic.Add("Key B", "Value B");

            Console.WriteLine(dic["Key A"]);
        }

        static void AddListArray()
        {
            List<string> StringList = new List<string>();
            // 선언 시 배열 길이 필수 지정
            string[] StringArray = new string[5];

            for (int i = 0; i < StringArray.Length; i++)
            {
                // 값 대입 시 인덱스 지정 필수
                StringArray[i] = i.ToString();
                StringList.Add(i.ToString());
            }

            StringArray[1] = "Insert";

            StringList.Insert(1, "Insert");
            StringList.Remove("Insert");
        }
    }
}