/* 첫번째 함수만 실행된다. */

// let promise = new Promise(function (resolve, reject) {
//   resolve(1);

//   setTimeout(() => resolve(2), 1000);
// });

// promise.then(alert);

function delay(ms) {
  return new Promise((resolve) => setTimeout(() => resolve(), ms));
}

delay(3000).then(() => console.log("3초 후 실행"));
