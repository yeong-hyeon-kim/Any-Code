/* 유틸리티 타입? : 이미 정의해 놓은 타입을 변환할 때 사용하기 좋은 타입 문법입니다. */
// 필수는 아니지만 더 간결한 문법으로 타입을 정의할 수 있습니다.

// 파셜(Partial)
// 특정 타입의 부분 집합을 만족하는 타입을 정의할 수 있습니다.
interface Address {
  email: string;
  address: string;
}

type MayHaveEmail = Partial<Address>;
const me: MayHaveEmail = {};
const you: MayHaveEmail = { email: "you@test.com" };
const all: MayHaveEmail = { email: "all@test.com", address: "korea" };

// 픽(Pick)
// 특정 타입에서 몇 개의 속성을 선택하여 타입을 정의할 수 있습니다.
interface Beer {
  name: string;
  brand: string;
}

const NonAlcohol: Pick<Beer, "name"> = {
  name: "무알콜 맥주",
};

// 오밋(Omit)
// 특정 타입에서 지정된 속성만 제거한 타입을 정의해줍니다.
interface AddressBook {
  name: string;
  phone: string;
  address: string;
  company: string;
}

const Book: Omit<AddressBook, "address"> = {
  name: "Windows 고객센터",
  phone: "010-1234-1234",
  company: "마이크로소프트",
};

const chingtao: Omit<AddressBook, "address" | "company"> = {
  name: "카페",
  phone: "02-1234-1234",
};
