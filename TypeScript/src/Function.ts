/* TypeScript : Function Args */

// 매개 변수 : 객체지향 언어처럼 매개 변수에 타입을 지정합니다.
function Sum(a: number, b: number, c: number): number {
  return a + b + c;
}

Sum(10, 20, 30);

function Multiply(a: number, b: number, c: number): number {
  return a * b * c;
}

Multiply(11, 22, 33);

/* TypesScript : this */
// function FunctionName(this: type) {}

interface React {
  node: string;
  count: number;
  init(this: React): () => {};
}

let project: React = {
  node: "",
  count: 1234,
  init: function (this: React) {
    return () => {
      return this.count;
    };
  },
};

let getUseCount = project.init();
let useCount = getUseCount();
console.log(useCount);

interface UIElement {
  // this:void 'this' 타입을 선언할 필요가 없다는 의미입니다.
  addClickListener(onclick: (this: void, e: Event) => void): void;
}

class Handler {
  onClick(this: void, e: Event) {
    console.log("clicked!");
  }
}

let handler = new Handler();
// Env.HTML
// uiElement.addClickListener(Handler.onClick);
handler.onClick;
