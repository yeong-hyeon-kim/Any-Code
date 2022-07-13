namespace PLoop
{
    class Program
    {
        static void Main()
        {
            Loop();
        }

        static void Loop()
        {
            int Sum = 0;
            int[] ArraySum = { 1, 2, 3 };

            // for : 단순 반복, 배열 인덱스 접근
            // 1. 초기화
            // 2. 조건문 검사
            // 3. 반복문 실행
            // 4. 증감문 실행
            for (int i = 0; i < 10; i++)
            {
                Sum += i;
                Console.WriteLine("for : " + Sum);

                if (i % 2 == 0)
                {
                    // 조건문에 만족하면 현재 단계를 넘어갑니다.
                    continue;
                }

                if (i > 50)
                {
                    // 조건문에 만족하면 반복문을 종료.
                    break;
                }
            }


            // foreach : 컬렉션 또는 배열 길이까지 반복, 특히 컬렉션 내부 타입을 정확히 모를 경우 사용.
            // 1. 초기화
            // 2. 반복문 실행
            foreach (var item in ArraySum)
            {
                Sum += item;
                Console.WriteLine("foreach : " + Sum);
            }

            // while : 조건식이 만족할때까지 반복할때 사용.
            // 첫 번째부터 조건문 검사
            // 1. 조건문 검사
            // 2. 반복문 실행
            while (Sum > 0)
            {
                Sum -= 1;
                Console.WriteLine("while : " +  Sum);
            }

            // do : 조건식이 만족할때까지 반복할때 사용.
            // 두 번째부터 조건문 검사
            // 1. 반복문 실행
            // 2. 조건문 검사
            do
            {
                Sum -= 1;
                Console.WriteLine("do : " + Sum);

            } while (Sum > 0);
        }
    }
}