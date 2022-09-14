(function () {
  var obj = {
    outer: function () {
      console.log(this);
      // 화살표 함수는 가장 가까운 this에 접근한다.
      // outer this에 접근한다.
      // 명시적으로 this를 전달하기 위해 call/apply/bind를 적용할 필요가 없다.
      var innerFunc = () => {
        console.log(this);
      };
      innerFunc();
    },
  };
  obj.outer();
})();
