namespace PRefValType
{
    class Reference
    {
        public string RefName { get; set; } = "Property : Reference";
    }
    class Program
    {
        static void Main()
        {
            ValueType();
        }

        /// <summary>
        /// 스택(Stack) : 값 형식(Value Types)
        /// </summary>
        static void ValueType()
        {
            // Value Type : 메서드가 종료되면 소멸된다.
            int iA = 100;
            int iB = 200;
            int iC = 300;

            // Reference Type : 주소를 참조하기 때문에 실질적인 값은 힙(Heap)에 남아있다.
            Reference reference = new Reference();
        }
    }
}