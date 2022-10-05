/* 인터페이스(Interface) */
// 상호 간에 정의한 약속 혹은 규칙 > 속한 객체를 규칙에 따르게 합니다.

// Not Use Interface
let computer = { name: "GalaxyBook", company: "Samsung" };
function getName(obj: { name: string }) {
  console.log(obj.name);
}

console.log(computer);

// Use Interface
// 인터페이스 타입이 따라야할 규칙을 명시적으로 표현할 수 있습니다.
interface SmartPhones {
  // 필수 속성
  name: string;
  // 선택 속성
  service?: string;
  // 일기 전용 속성
  readonly price: string;
}

function getSmartPhoneName(obj: SmartPhones) {
  console.log(obj.name);
}

let phone = { name: "Galaxy Fold 4", company: "Samsung", price: "$999" };
let iPhone: SmartPhones = {
  name: "iPhone",
  price: "$999",
};

// 읽기 전용이라 수정할 수 없습니다.
// iPhone.price = "$999";
getSmartPhoneName(phone);

let ReadonlyArr: ReadonlyArray<number> = [1, 2, 3];
//ReadonlyArr.slice(0,1)

// 객체 선언과 관련된 타입 확인
// 타입 추론으로 에러 발생
// getSmartPhoneName({ name: "Galaxy Fold 4", company: "Samsung", price: "$999" });

// 타입 추론 무시
let anyPhone = { name: "Galaxy Fold 4", company: "Samsung", price: "$999" };
getSmartPhoneName(anyPhone as SmartPhones);

interface Car {
  model: string;
  // 클래스 타입 : 매개 변수 타입이 string이고 반환 값이 없는 클래스
  nameModel(Car: string): void;
}

class Kia implements Car {
  model: string = "";
  nameModel(c: string) {
    this.model = c;
  }

  constructor() {}
}

interface login {
  // 함수 타입 : 매개 변수 타입이 string이고 반환 값이 boolean 타입인 함수
  (username: string, password: string): boolean;
}

let loginUser: login;
loginUser = function (id: string, pw: string) {
  console.log("로그인!");
  return true;
};

interface Plant {
  name: string;
}

interface PlumTree extends Plant {
  color: string;
}

// 추론 무시를 위해 as 사용
let tree = {} as PlumTree;
tree.name = "PlumTree";
tree.color = "Pink";

interface Coffee {
  brand: string;
  color(): void;
  (type: string): string;
}

function myCoffe(): Coffee {
  let myCoffes = function (type: string) {} as Coffee;
  myCoffes.brand = "Illy";
  myCoffes.color = function () {};

  return myCoffes;
}
