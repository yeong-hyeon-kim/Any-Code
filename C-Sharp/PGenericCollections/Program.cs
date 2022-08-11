namespace GenericCollections
{
    public class Program
    {
        static void Main(string[] arg)
        {
            AddListArray();
            AddDictionary();
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

        static void AddDictionary()
        {
            // Dictionary<KeyType, ValueType> dic = new Dictionary<KeyType, ValueType>();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Key A", "Value A");
            // 중복된 키 삽입 시 에러 발생.
            dic.Add("Key B", "Value B");

            Console.WriteLine(dic["Key A"]);
        }
    }
}