using System.Collections;

namespace Collections
{
    class Program
    {
        static ArrayList arrayList = new ArrayList();

        static void Main() 
        {
            AddArrayList();
            ReturnArrayList();
        }

        static void AddArrayList()
        {
            // 박싱(Boxing) : 값 타입을 참조 타입으로 변환
            arrayList.Add(1234);
            arrayList.Add(1.154F);
            arrayList.Add(1024D);
            arrayList.Add("1224");
        }

        static void ReturnArrayList()
        {
            foreach (var item in arrayList)
            {
                // 언박싱(UnBoxing) : 참조 타입을 값 타입으로 변환.
                Console.WriteLine(item.ToString());
            }
        }
    }
}