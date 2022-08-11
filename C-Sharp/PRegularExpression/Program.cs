using System.IO;
using System.Text.RegularExpressions;

namespace PRegular
{
    class Program
    {
        static void Main()
        {
            MatchRegex();
        }

        static void MatchRegex()
        {
            string Ns = "동해 물과 백두산이 마르고 닳도록 하느님이 보우하사 우리나라 만세. 무궁화 삼천리 화려 강산 대한 사람, 대한으로 길이 보전하세.";
        
            Regex regex = new Regex("사");
            Match match = regex.Match(Ns);
            MatchCollection matchcollection = regex.Matches(Ns);

            // 첫 번째로 찾은 문자열만 출력.
            if (match.Success)
            {
                Console.WriteLine("{0}:{1}", match.Index, match.Value);
            }

            // 찾은 문자열을 계속 출력.
            while (match.Success)
            {
                Console.WriteLine("{0}:{1}", match.Index, match.Value);
                match = match.NextMatch();
            }

            // 찾은 문자열 콜렉션.
            foreach (Match item in matchcollection)
            {
                Console.WriteLine("{0}:{1}", item.Index, item.Value);
            }
        }
    }
}