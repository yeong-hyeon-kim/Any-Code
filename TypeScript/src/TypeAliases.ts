// string 타입을 사용할 때
const User: string = "First User";

// 타입 별칭을 사용할 때
type userAliase = string;
const ohterUser: userAliase = "Second User";

type SmartPhone = {
  name: string;
  strc: string;
};

type User<T> = {
  name: T;
};
