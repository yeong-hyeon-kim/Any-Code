const func = function () {
  console.log("FUNC");
};

const text1 = "ES";
const text2 = "ES";

/* ES6 */
const obj = {
  inside() {
    console.log("객체 안 함수!");
  },
  func,
  // 객체 내부에서 프로퍼티를 동적으로 생성할 수 있습니다.
  [text1 + 6]: "최신 버전",
};

obj.inside();
obj.func();
// ES5
obj[text2 + 5] = "이전 버전";

console.log(obj.ES5);
console.log(obj.ES6);
