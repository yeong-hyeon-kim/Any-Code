// String
let str: string = "TypeScript!";

// Number
let num: number = 2022;

// boolean
let logical: boolean = true;

// Array
let array: number[] = [1, 2, 3, 4];
let arrayGeneric: Array<Number> = [1, 2, 3, 4];

// Tuple
// 배열의 길이가 고정되고 각 요소의 타입이 지정되어 있는 배열 형식을 의미합니다.
let arr: [string, number] = ["TypeScript", 2022];

// Enum
// 상수들의 집합을 의미합니다.
enum Computers {
  DeskTop,
  LabTop,
  NoteBook,
  SmartPhone,
}

let PC: Computers = Computers.DeskTop;

// Any
// 모든 타입을 허용한다는 의미를 지니고 있습니다.
let AnyString: any = "TypeScript";
let AnyNumber: any = 1;
let AnyArray: any = [1, 2, 3, 4];

// Void
// 변수에서는 undefined와 null만 할당 가능한 타입.
let Undefine: void = undefined;

// 함수에서는 반환 값을 설정할 수 없는 타입.
function FuncNotUse(): void {
  console.log("Not Use!");
}

FuncNotUse();

// Never
// 절대로 함수 끝에 도달하지 않는다는 의미를 지닌 타입입니다.
function FuncNeverEnd(): never {
  while (true) {}
}
