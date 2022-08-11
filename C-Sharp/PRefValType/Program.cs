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

            int x = 9999;
            ReferenceType(ref x);
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

        /// <summary>
        /// 매개 변수는 값 타입이라 독립적이지만 ref 키워드로 인해 인자의 주소 값을 참조하는 참조 형식이 되어 인자의 값이 변경된다.
        /// </summary>
        /// <param name="x"></param>
        static void ReferenceType(ref int x)
        {
            x = 1234;
        }
    }
}