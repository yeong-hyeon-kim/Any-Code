let Car = {
  Move() {
    console.log("자동차가 부릉부릉 움직입니다.");
  },
  Load: true,
};

let Avante = {
  Maker: "HYUNDAI",
  Model: "AVANTE",
  __proto__: Car,
};

let AvanteHybrid = {
  Fuel: "OLI + Eeletro",
  __proto__: Avante,
};

AvanteHybrid.Move();
AvanteHybrid.Move = function () {
  console.log("하이브리드 잘 굴러 갑니다~");
};

AvanteHybrid.Move();

/* 접근자 프로퍼티와 프로토타입*/

let user = {
  name: "이유이",
  age: 20,
  set profile(value) {
    [this.name, this.age] = value.split(" ");
  },

  get profile() {
    return `${this.name}, ${this.age}`;
  },
};

let admin = {
  isAdmin: true,
  __proto__: user,
};

console.log(admin.profile);

admin.profile = "앨리스 18";

// user에 있었던 프로퍼티에서 가져옵니다.
console.log(user.profile);
// setter에 의해 추가된 admin 프로퍼티에서 가져옵니다.
console.log(admin.profile);

let transportation = {
  moving() {
    this.isPower = true;
    console.log("움직이기");
  },

  loading() {
    console.log("물건 싣기");
  },
};

let airplane = {
  name: "A380",
  __proto__: transportation,
};

airplane.moving();
console.log(airplane.isPower);
console.log(transportation.isPower);
