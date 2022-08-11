// 동등 연산자( == : Equality Operator)
// 피연산자들의 타입이 다를 경우 암시적 형변환을 통해 타입을 일치시켜 비교합니다.

// 문자열(String), 수치(Number)
if ("1" == 1) {
  console.log(true);
} else {
  console.log(false);
}

// Boolean(true : 1 , false : 0)
console.log(true == 1);
console.log(false == 0);

// 일치 연산자( === : Identity Operator)
// 피연산자들의 값과 타입이 모두 같을 경우 ture를 반환합니다.

// false
if ("1" === 1) {
  console.log(true);
} else {
  console.log(false);
}

// true
if (1 === 1) {
  console.log(true);
} else {
  console.log(false);
}

// Boolean(true : 1 , false : 0)
// false
console.log(true === 1);
console.log(false === 0);

// true
console.log(true === true);
console.log(false === false);
