/* 타입 호환(Type Compatibility) */
interface Computer {
  name: string;
}

// class Galaxy {
//   name: string;
// }

// let i: Computer;
// i = new Galaxy();

/* 구조적 타이핑 */
// 타입스크립트가 추론한 타입 : {name: string; company: string;}
let GalaxyS: Computer;
// S22Ultra가 GalaxyS 타입에 호환될 수 있는 이유는 S22Ultra 속성 중 name 속성을 갖고 있기 때문입니다.
// Computer 인터페이스에 name 속성을 갖고 있기 때문에 S22Ultra는 GalaxyS타입에 호환될 수 있습니다.
let S22Ultra = { name: "GalaxyS22Ultra", company: "Samsung" };
GalaxyS = S22Ultra;

/* Soundness */
// 타입스크립트는 컴파일 시점에 타입을 추론할 수 없는 특정 타입에 대해서 일단 안전하다고 보는 특성이 있습니다.
// 이것을 "들리지 않는다(it is said to not be sound)"라고 표현합니다.
