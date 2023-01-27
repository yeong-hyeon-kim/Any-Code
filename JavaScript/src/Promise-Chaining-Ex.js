function loadScript(src) {
  return new Promise(function(resolve, reject) {
    let script = document.createElement('script');
    script.src = src;

    script.onload = () => resolve(script);
    script.onerror = () => reject(new Error(`${src}를 불러오는 도중에 에러가 발생함`));

    document.head.append(script);
  });
}

let promise =  loadScript("https://cdnjs.cloudflare.com/ajax/libs/lodash.js/4.17.11/lodash.js");

loadScript("/JavaScript/src/Promise-Chaining-Ex-One.js")
  .then(script => loadScript("/JavaScript/src/Promise-Chaining-Ex-Two.js"))
  .then(script => loadScript("/JavaScript/src/Promise-Chaining-Ex-three.js"))
  .then(script => {
    // 스크립트를 정상적으로 불러왔기 때문에 스크립트 내의 함수를 호출할 수 있습니다.
    One();
    Two();
    Three();
  });