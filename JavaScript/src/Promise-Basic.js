/* Promise - Subscription */
// 제작 코드(Projucing Code) - 시간이 걸리는 코드
// 소비 코드(Consuming Code) - 시간이 걸리는 코드를 기다렸다 실행하는 코드
// 프라미스(Promise) - 제작 코드와 소비 코드를 연결해주는 객체

let promiseBasic = new Promise(function (resolve, reject) {
  //   setTimeout(() => resolve("완료"), 1000);
  setTimeout(() => reject("에러"), 1000);
});

promiseBasic.then(
  // 첫번째 - 이행
  function (result) {
    console.log(result);
  },
  // 두번째 - 거부
  function (error) {
    console.log(error);
  }
);

// 이행 코드만 실행
promiseBasic.then(function (result) {
  console.log(result);
});

// 에러 코드만 실행
promiseBasic.catch(function (error) {
  console.log(error);
});

let promiseFinally = new Promise(function (resolve, reject) {
  setTimeout(() => resolve("결과"), 1000);
});

promiseFinally
  .finally(() => console.log("프라미스"))
  .then((result) => console.log(result));

new Promise((resolve, reject) => {
  reject("에러");
})
  .finally(() => console.log("프라미스"))
  .catch((err) => console.log(err));