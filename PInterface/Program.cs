using System.Configuration;
using System.Data.OleDb;

namespace PInterface
{
    #region 인터페이스 활용
    interface IPower
    {
        void TurnOn();
        void TurnOff();
    }

    class Monitor : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("Monitor : On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Monitor : Off");
        }
    }

    class Computer : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("Computer : On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Computer : Off");
        }
    }

    class Switch
    {
        #region Switch - 인터페이스 사용
        // 상위 클래스(인터페이스)를 상속한 하위 클래스는 상위 클래스(인터페이스) 타입(Type)으로 변환이 가능하다.
        /// <summary>
        /// /// IPower의 PowerOn를 구현(재정의)한 메소드를 출력  
        /// </summary>
        /// <param name="Device"></param>
        public void PowerOn(IPower Device)
        {
            // IPower 타입의 TurnOn 메서드를 실행한다.
            // IPower의 타입을 가져야 하므로 IPower를 상속한 클래스여야한다.
            Device.TurnOn();
        }

        /// <summary>
        /// IPower의 PowerOff를 구현(재정의)한 메소드를 출력  
        /// </summary>
        /// <param name="Device">IPower를 상속한 클래스의 인스턴스(Instance)</param>
        public void PowerOff(IPower Device)
        {
            // IPower 타입의 TurnOff 메서드를 실행한다.
            // IPower의 타입을 가져야 하므로 IPower를 상속한 클래스여야한다.
            Device.TurnOff();
        }
        #endregion

        #region Switch - 클래스 사용

        // 타입 별로 PowerOn, PowerOff 메소드가 있어야 한다.
        public void PowerOn(Computer Device)
        {
            // 무조건 Computer 타입(Type)만 매계변수로 받을 수 있다
            Device.TurnOn();
        }

        public void PowerOff(Computer Device)
        {
            // 무조건 Computer 타입(Type)만 매계변수로 받을 수 있다
            Device.TurnOn();
        }

        #endregion
    }

    #endregion

    #region 인터페이스 기본
    interface ITransportation
    {
        // 각 클래스의 공통된 행위(메서드), 특성을 정의하고 구현할 것을 강제.
        // 반환 형식, 메서드명, 시그니처만 선언.
        // 인터페이스는 내용이 아닌 외형.
        // 구체적인 기능 구현은 인터페이스를 상속받는 클래스에서 작성. 
        void Move();

        void Load();
    }

    class Car : ITransportation
    {
        public void Load()
        {
            Console.WriteLine("차에 짐을 싣고 갑니다.");
        }

        public void Move()
        {
            Console.WriteLine("차로 집에 갑니다.");
        }

        public virtual void Model()
        {
            Console.WriteLine("여러가지 모델이 있습니다.");
        }
    }

    class Avante : Car
    {
        public override void Model()
        {
            Console.WriteLine("Avante");
        }
    }

    class MotorBike : ITransportation
    {
        public void Load()
        {
            Console.WriteLine("오토바이에 짐을 싣고 갑니다.");
        }

        public void Move()
        {
            Console.WriteLine("오토바이로 집에 갑니다.");
        }

        public virtual void Model()
        {
            Console.WriteLine("여러가지 모델이 있습니다.");
        }
    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // ※ 인터페이스 기본
            Car car = new Car();
            MotorBike motorBike = new MotorBike();

            car.Load();
            motorBike.Load();

            Avante avante = new Avante();
            avante.Model();

            // ※ 인터페이스 활용
            // IPower를 상속받은 어떤 클래스(Class)가 와도 Switch의 변경없이 구현 가능하다.
            Switch s = new Switch();

            Monitor monitor = new Monitor();
            Computer computer = new Computer();

            // ※ 클래스(Class) 이용
            // Switch 클래스(Class)의 PowerOn 메소드(Method) 매계변수 타입(Type)을 특정 클래스(Computer)로 명시해야 하므로 강한 결합의 코드가 된다.
            s.PowerOn(computer);
            s.PowerOff(computer);

            // ※ 인터페이스(Interface) 이용
            // Switch 클래스(Class)의 PowerOn 메소드(Method) 매계변수 타입(Type)을 특정 클래스(Class)로 명시할 필요가 없어 느슨한 결합의 코드가 된다.
            // IPower를 강제 구현(재정의)한 Monitor 클래스(Class)의 PowerOn 메소드(Method)가 실행된다.
            s.PowerOn(monitor);
            // IPower를 강제 구현(재정의)한 Monitor 클래스(Class)의 PowerOff 메소드(Method)가 실행된다.
            s.PowerOff(monitor);
        }
    }
}