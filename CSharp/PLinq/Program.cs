namespace PLinq
{
    /// <summary>
    /// Q&A
    /// </summary>
    public class QNA
    {
        public int QnaNo { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserCd { get; set; }
        public string WriteDateTime { get; set; }
    }

    /// <summary>
    /// 사용자
    /// </summary>
    public class User
    {
        public string UserCd { get; set; }
        public string UserNm { get; set; }
        public string CompanyNm { get; set; }
    }

    class Linq
    {
        static void Main(string[] args)
        {
            WithLinq();
            WithoutLinq();
            Quantifiers();
        }

        // IEnumerable,IEnumerable
        static void WithLinq()
        {
            #region 기본 사용
            int[] ArrNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // from 범위 변수 in 데이터
            // where 조건식
            // orderby 범위 변수 (오름차순 : 생략, 내림차순 : descending)
            // select 범위 변수(최종 결과를 익명 형식으로 출력)                                                                                                                                                          ㅣㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏ
            var Result = from Even in ArrNumber
                         where Even % 2 == 0
                         orderby Even
                         select Even;
            #endregion


            List<QNA> QnaList = new List<QNA>()
            {
                new QNA {QnaNo = 0, Title = "제목 A", Content = "내용 A", UserCd = "A001", WriteDateTime = "2022-01-01"},
                new QNA {QnaNo = 1, Title = "제목 B", Content = "내용 B", UserCd = "A002", WriteDateTime = "2022-01-02"},
                new QNA {QnaNo = 2, Title = "제목 C", Content = "내용 C", UserCd = "A003", WriteDateTime = "2022-01-03"},
                new QNA {QnaNo = 3, Title = "제목 D", Content = "내용 D", UserCd = "A004", WriteDateTime = "2022-01-04"},
                new QNA {QnaNo = 4, Title = "제목 E", Content = "내용 E", UserCd = "A004", WriteDateTime = "2022-01-05"},
                new QNA {QnaNo = 5, Title = "제목 F", Content = "내용 F", UserCd = "A003", WriteDateTime = "2022-01-06"}
            };

            List<User> UserList = new List<User>()
            {
                //new User {UserCd = "A001", UserNm = "최윤미", CompanyNm = "구석기 전자"},
                //new User {UserCd = "A002", UserNm = "신현주", CompanyNm = "파산 은행"},
                new User {UserCd = "A003", UserNm = "윤진아", CompanyNm = "거북이 자동차"},
                new User {UserCd = "A004", UserNm = "박선아", CompanyNm = "사망 병원"},
                new User {UserCd = "A005", UserNm = "김서연", CompanyNm = "실패 컨설팅"}
            };

            #region LINQ Lamda

            // 특정 필드만 출력.
            var FilterA_Qna = QnaList.Select(x => x.QnaNo).ToList();
            // 조건식 지정 출력.
            var FilterB_1_Qna = QnaList.Where(x => x.UserCd.Equals("A004")).ToList();
            var FilterB_2_Qna = QnaList.Where(x => x.UserCd.Equals("A004") && x.Title.Equals("제목 E")).ToList();
            // 그룹 지정 출력.
            var FilterC_Qna = QnaList.GroupBy(x => x.UserCd.Equals("A004")).ToList();


            #endregion

            #region LINQ Group

            //var QueryQnas = UserList.Select(x => x.UserCd).ToList();

            // from 범위 변수 in 데이터
            // group 범위 변수(그룹화 할 범위 변수) by 그룹 조건식
            // into 그룹 범위 변수
            // orderby 그룹 범위 변수 (오름차순 : 생략, 내림차순 : descending)
            // select 그룹 범위 변수(최종 결과)
            var QueryQna = from Qna in QnaList
                           group Qna by Qna.UserCd == "A004"
                           into gQna
                           orderby gQna.Key
                           select gQna;

            foreach (var QnaGroup in QueryQna)
            {
                Console.WriteLine(QnaGroup.Key ? "A004" : "다른 코드");

                foreach (var Qna in QnaGroup)
                {
                    Console.WriteLine("{0},{1},{2},{3},{4}", Qna.QnaNo, Qna.Title, Qna.Content, Qna.UserCd, Qna.WriteDateTime);
                }
            }

            #endregion

            #region LINQ Join
            // 내부 조인(INNER JOIN) 조인 조건을 만족하는 행만 출력할 때 사용 됩니다.

            // 범위 변수 in 원본 데이터
            // join 비교 대상 범위 변수 in 비교 대상 데이터
            // on 비교 대상 범위 변수.필드 equals 데이터.필드
            // select new { 무명 형식.필드 = 필요한 필드};
            var QnaInnerJoin = from Qna in QnaList
                               join User in UserList on Qna.UserCd equals User.UserCd
                               select new { Title = Qna.Title, Content = Qna.Content, Writer = User.UserNm };

            Console.WriteLine("QnaInnerJoin");

            foreach (var QnaJoin in QnaInnerJoin)
            {
                Console.WriteLine("{0},{1},{2} ", QnaJoin.Title, QnaJoin.Content, QnaJoin.Writer);
            }


            // 외부 조인(OUTER JOIN) 조인 조건을 만족하지 않는 행까지 함께 출력할 때 사용됩니다.


            // 왼쪽 외부 조인(Left Outer Join) - A, B를 조인했을때 A 전체 값과 B와 매칭되는 값을 조회합니다.
            // Right Qna, Left User

            // 범위 변수 in 원본 데이터
            // join 범위 변수(비교 대상) in 비교 대상 데이터
            // on 범위 변수(비교 대상).필드 equals 데이터.필드
            // into 범위 변수(내부 조인 결과)
            // Linq 에서 일치하지 않는 값은 빈칸(Empty)로 표시
            // from 범위 변수(비교 대상) in 범위 변수(내부 조인 결과)에서 빈칸(일치하는 데이터 없음)인 것을 "NULL" 로 채움.
            // select new { 무명 형식.필드 = 필요한 필드};
            var QnaLeftOuterJoin = from Qna in QnaList
                                   join User in UserList on Qna.UserCd equals User.UserCd
                                   into Nb
                                   from User in Nb.DefaultIfEmpty(new User() { UserNm = "NULL" })
                                   select new { Title = Qna.Title, Content = Qna.Content, Writer = User.UserNm };

            Console.WriteLine("QnaLeftOuterJoin");

            foreach (var QnaJoin in QnaLeftOuterJoin)
            {
                Console.WriteLine("{0},{1},{2},{3}", QnaJoin.Title, QnaJoin.Content, QnaJoin.Content, QnaJoin.Writer);
            }

            // 오른쪽 외부 조인(Right Outer Join) - A, B를 조인했을때 B 전체 값과 B와 매칭되는 값을 조회합니다.
            // Right User , Left Qna

            var QnaRightOuterJoin = from User in UserList
                                    join Qna in QnaList on User.UserCd equals Qna.UserCd
                                    into Nb
                                    from Qna in Nb.DefaultIfEmpty(new QNA() { Title = "NULL" })

                                    select new { Title = Qna.Title, CompanyNm = User.CompanyNm, UserName = User.UserNm };

            Console.WriteLine("QnaRightOuterJoin");

            foreach (var UserJoin in QnaRightOuterJoin)
            {
                Console.WriteLine("{0},{1},{2}", UserJoin.Title, UserJoin.CompanyNm, UserJoin.UserName);
            }
            #endregion
        }

        static void WithoutLinq()
        {
            int[] ArrNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> LisNumber = new List<int>();

            for (int i = 0; i < ArrNumber.Length; i++)
            {
                if (ArrNumber[i] % 2 == 0)
                {
                    LisNumber.Add(ArrNumber[i]);
                }
            }

            foreach (var item in LisNumber)
            {
                Console.WriteLine(item);
            }
        }

        static void Quantifiers()
        {
            // All : 데이터 집합의 모든 요소가 주어진 조건을 만족하면 Ture 아니면 False
            List<string> QuantifiersAll = new List<string>()
            {
                "고구마", "감자", "옥수수"
            };

            var QuantifiersAllQueryResult = (from Food in QuantifiersAll
                                             select Food).All(item => item.Equals("옥수수"));

            var QuantifiersAllMethodResult = QuantifiersAll.All(item => item.Equals("옥수수"));

            // Any : 데이터 집합의 요소 중 하나라도 조건을 만족하면 Ture 아니면 False

            List<int> QuantifiersAny = new List<int>()
            {
               2,4,6,8,10,12
            };

            var QuantifiersAnyQueryResult = (from Food in QuantifiersAny
                                             select Food).Any(item => item > 10);

            var QuantifiersAnyMethodResult = QuantifiersAny.Any(item => item > 10);



            // Contains : 데이터 집합에서 특정 값이 포함되있다면 Ture 아니면 False
            List<string> QuantifiersContains = new List<string>()
            {
                "아반떼", "쏘나타" ,"그랜저", "제네시스"
            };

            var QuantifiersContainsQueryResult = (from Car in QuantifiersContains
                                             select Car).Contains("쏘나타");

            var QuantifiersContainsMethodResult = QuantifiersContains.Contains("쏘나타");
        }
    }
}