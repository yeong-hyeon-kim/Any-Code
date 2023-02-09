/* 구조 분해 할당 */
// 값을 해체 한 후, 개별 값을 변수에 새로 할당하는 과정입니다.

/* 배열 */
const array = [1, 2, 3, 4, 5];
const [one, two, three, four, five] = array;

console.log(one);
console.log(two);
console.log(three);
console.log(four);
console.log(five);

/* 객체 */
const objCollections = {
  washer: "트롬 세탁기",
  dryer: "트롬 건조기",
  induction: "디오스 인덕션",
};

const { washer, dryer, induction } = objCollections;

console.log(washer, dryer, induction);
