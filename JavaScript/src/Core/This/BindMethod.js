(function () {
  var func = function (a, b, c, d) {
    console.log(this, a, b, c, d);
  };

  func(1, 2, 3, 4);

  // 함수에 this를 미리 적용.
  var funcWithbind = func.bind({ Words: "Hello World!" });
  funcWithbind("A", "B", "C", "D");

  // this를 미리 적용
  var bindFunc = func.bind({ Word: "Hello World!" }, 4, 5);
  // 부분 적용 함수 구현.
  // this 값이 바뀐 값을 제외하고 최초에 4,5,6,7을 넘긴것과 같은 동작을 수행.
  bindFunc(6, 7);

  console.log(func.name);
  // bound func : 원본 함수 func를 bind를 적용한 새로운 함수.
  console.log(bindFunc.name);

  var obj = {
    outer: function () {
      console.log(this);
      var innerFunc = function () {
        console.log(this);
      };
      innerFunc.call(this);
    },
  };
  obj.outer();

  var obj2 = {
    outer: function () {
      console.log(this);
      var innerFunc = function () {
        console.log(this);
      }.bind(this);
      innerFunc();
    },
  };
  obj2.outer();
})();
