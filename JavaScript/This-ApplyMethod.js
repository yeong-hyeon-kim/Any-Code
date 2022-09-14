(function () {
  var func = function (a, b, c) {
    console.log(this, a, b, c);
  };

  //명시적으로 this를 바인딩.
  // 배열을 인자로 받아 매개 변수로 이용.
  func("X", "Y", "Z");
  func.apply({ Time: "T" }, ["X", "Y", "Z"]);
})();
