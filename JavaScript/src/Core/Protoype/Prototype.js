let Car = {
  Move() {
    console.log("자동차가 부릉부릉 움직입니다.");
  },
  Load: true,
};

let Avante = {
  Maker: "HYUNDAI",
  Model: "AVANTE",
};

console.log(Avante.Maker);
// Car는 Avante의 프로토타입(Prototype)이라고 합니다.
// Avante는 Car를 상속 받습니다.
Avante.__proto__ = Car;
// 상위 객체의 메서드를 사용할 수 있습니다.
Avante.Move();
