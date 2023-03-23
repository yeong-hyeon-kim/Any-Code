// 생성자 함수 첫 문자는 대문자
function SmartPhone(maker, model) {
  this.maker = maker;
  this.model = model;
}

// Galaxy는 SmartPhone의 인스턴스(Instance)
const Galaxy = new SmartPhone("삼성전자", "갤럭시S22 울트라");
// IPhone은 SmartPhone의 인스턴스(Instance)
const IPhone = new SmartPhone("애플", "아이폰 14 프로");

console.log(Galaxy.maker, Galaxy.model);
console.log(IPhone.maker, IPhone.model);
