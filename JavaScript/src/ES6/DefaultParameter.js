/* ES5 */
function Func(a, b) {
  var a = a || 100;
  var b = a || 200;
  return a + b;
}
console.log(Func);

/* ES6 */
const InitFunc = (a = 100, b = 200) => a + b;
console.log(InitFunc);
