using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    //delegate void TestDelegate(int Number);
    internal class Delegate
    {
        static void main(string[] args)
        {
            Action<int> test = new Action<int>(Write);
            test(1234);
            // 1234
        }

        static void Write(int Number)
        {
            Console.WriteLine(Number);
        }
    }
}
