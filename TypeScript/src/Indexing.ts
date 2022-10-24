interface NumberArray {
  [index: number]: number;
}

const ARR: NumberArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
ARR[0];

interface ReadonlyNumberArray {
  [index: number]: number;
}

const RARR: NumberArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// 타입 에러 발생.
//RARR[1] = '11'
