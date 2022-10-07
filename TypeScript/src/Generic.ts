/* 제네릭(Generic) */
// 함수의 입력 값에 대한 타입과 출력 값에 대한 타입이 동일한지 검증합니다.
function logText<T>(text: T): T {
  return text;
}
/* 제네릭 함수 호출 */
const log1 = logText<string>("Hello Generic");
const log2 = logText("Hello Generic");

/* 제네릭 타입 변수 */
function getLog<T>(log: Array<T>): Array<T> {
  console.log(log.length);
  return log;
}

/* 제네릭 타입 */
function logs<T>(logs: T): T {
  console.log(logs);
  return logs;
}
let getLogs: <T>(logs: T) => T = logs;
