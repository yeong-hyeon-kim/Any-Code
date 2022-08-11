namespace PEnum
{
    /// <summary>
    /// 열거형 상수(constant)를 표현하거나
    /// 상수 숫자들을 보다 의미있는 단어들로 표현.
    /// </summary>
    enum SmartPhone
    {
        Galaxy,
        // 기본적으로 자동 증가 값을 할당 받지만 직접 할당할 수 있다. 
        iPhone,
        Motorola,
        Xperia
    }

    class Program
    {
        static void Main()
        {
            // Enum 타입을 선언합니다.
            SmartPhone Phone;
            // Enum 타입에 값을 대입합니다.
            Phone = SmartPhone.Galaxy;
            // 정수형으로 캐스팅하면 Galaxy의 상수 값인 0이 대입됩니다. 
            int PhoneValue = (int)Phone;

            //Enum 값을 비교
            if (Phone == SmartPhone.Galaxy)
            {
                Console.WriteLine("Galaxy");
            }

            // With Enum Type
            switch (Phone)
            {
                // SmartPhone이 Galaxy 일때 실행.
                case SmartPhone.Galaxy:
                    Console.WriteLine("SmartPhone Galaxy.");
                    break;
                // SmartPhone이 iPhone 일때 실행.
                case SmartPhone.iPhone:
                    Console.WriteLine("SmartPhone iPhone.");
                    break;
                // SmartPhone이 Motorola 일때 실행.
                case SmartPhone.Motorola:
                    Console.WriteLine("SmartPhone Motorola.");
                    break;
                // SmartPhone이 Xperia 일때 실행.
                case SmartPhone.Xperia:
                    Console.WriteLine("SmartPhone Xperia.");
                    break;
            }

            // Without Enum Type
            switch ((int)Phone)
            {
                // 값이 0 일때 실행.
                case 0:
                    Console.WriteLine("SmartPhone Galaxy.");
                    break;
                // 값이 1 일때 실행.
                case 1:
                    Console.WriteLine("SmartPhone iPhone.");
                    break;
                // 값이 2 일때 실행.
                case 2:
                    Console.WriteLine("SmartPhone Motorola.");
                    break;
                // 값이 3 일때 실행.
                case 3:
                    Console.WriteLine("SmartPhone Xperia.");
                    break;
            }
        }
    }
}