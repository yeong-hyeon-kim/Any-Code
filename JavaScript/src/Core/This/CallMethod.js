(function () {
  var func = function (a, b, c) {
    console.log(this, a, b, c);
  };

  func(1, 2, 3);
  //명시적으로 this를 바인딩.
  func.call({ AAS: 123456789 }, 1, 2, 3);
})();
