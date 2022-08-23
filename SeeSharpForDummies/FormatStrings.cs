using System;

namespace SeeSharpForDummies
{
    class FormatStrings
    {
        static void Formatting()
        {
            string myS = String.Format("{0} times {1} equals {2}", "two", "five", "ten");
            Console.WriteLine(myS);

            string s = String.Format("{0:N0}", 12.333);//cuts the fractions
            Console.WriteLine(s);

            string s1 = String.Format("percent: {0:P}", 123);
            Console.WriteLine(s1);

            string s2 = String.Format("with currency: {0:C}", 44.56);
            Console.WriteLine(s2);

            int i = 10;
            int j = (int)(5.0 * i);
            Console.WriteLine(j);
        }
    }
}
