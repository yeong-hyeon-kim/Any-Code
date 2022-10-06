/* readonly */
// class Fruit {
//   readonly name: string;
//   constructor(theName: string) {
//     this.name = theName;
//   }
// }

// class Fruit {
//   readonly name: string;
//   constructor(readonly theName: string) {
//     this.name = theName;
//   }
// }

// let banana = new Fruit("BANANA");

/* Accessor */
class Furit {
  private name: string = "";

  get getName(): string {
    return this.name;
  }

  public set setName(value: string) {
    this.name = value;
  }
}
const babana = new Furit();
babana.setName = "BANANA";

abstract class SuperComputer {
  abstract noticeWeather(): void;
  abstract parallelComputation(): void;
}

class FiveGenerationSuperComputer extends SuperComputer {
  noticeWeather(): void {
    console.log("날씨 예측 중...");
  }

  parallelComputation(): void {
    console.log("병렬 계산 중...");
  }
}

let nurion = new FiveGenerationSuperComputer();
nurion.noticeWeather();
nurion.parallelComputation();
