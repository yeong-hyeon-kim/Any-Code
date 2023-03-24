// 유일성을 보장하기 위해 만들어진 심볼
let idA = Symbol("ID");
let idB = Symbol("ID");

console.log(idA == idB); // false : 서로 다른 객체

// ---------------------

// 객체 오버라이딩 기능
let User = {
  name: "강수진",
  age: 21,
};

let ID = Symbol("id");

User[ID] = "A";

console.log(User[ID]);
console.log(User);
