/* 타입스크립트(TypeScript) : 타입 추론 */
/* 타입 추론 기본 */
// 타입을 따로 지정하지 않아도 타입을 추론합니다.
let x = 3;

/* 가장 적절한 타입(Best Common Type) */
// 다른 타입들과 가장 잘 호환이 잘되는 타입을 선정합니다.
let arrays = [1, "A", null];

/* 문맥상의 타이핑(Contextual Typing) */
window.onmousedown = function (mouseEvent) {
  console.log(mouseEvent.button);
  // 타입 추론을 위해 'window.onmousedown' 검사
  //console.log(mouseEvent.dog);
};

// 타입 추론을 위해 'window.onscroll' 검사
// window.onscroll = function (uiEvent) {
//     console.log(uiEvent.button)
// }

// 할당받는 변수로만으로는 타입을 추정하기 어려워 타입에러가 발생하지 않습니다.
const handlers = function (uiEvent: any) {
  console.log(uiEvent.button);
};
