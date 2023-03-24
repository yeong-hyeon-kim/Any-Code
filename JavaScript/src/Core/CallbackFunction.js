// 단일 실행
var TimeoutCallBack = (p) => {
  console.log(this, p + " Task");
};

// 반복 실행
var IntervalCallBack = (p) => {
  console.log(this, p + " Task");
};

var Timeout = setTimeout(TimeoutCallBack, 1000, "setTimeout");
clearTimeout(Timeout);
var Interval = setInterval(IntervalCallBack, 1000, "setInterval");
clearInterval(Interval);

console.log(Timeout);
console.log(Interval);
