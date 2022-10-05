/* 유니온 타입(Union Type) */
// 타입이 '||' A이거나 B이다.
function getAge(Numbers: number | string) {
  if (typeof Numbers === "number") {
    Numbers *= 2;
    return Numbers;
  }
  if (typeof Numbers === "string") {
    return Numbers + "'";
  }

  return new TypeError("number, string 타입으로 입력하세요.");
}

/* 인터섹션 타입(Intersection Type) */
interface Animal {
  name: string;
  move: string;
}

interface Cat {
  name: string;
  cats: string;
}

type Cats = Animal & Cat;

function introduce(someone: Animal | Cat) {
  // 인터페이스들 간 일치하는 속성만 받을 수 있습니다.
  someone.name;
  // someone.age;
  // someone.skill;
}
