using System;

namespace SeeSharpForDummies
{
    public class Strings
    {
        public static void MyString()
        {
            //declare and initialize
            string s = new String("abc");

            string s2 = new String("ABC");

            bool b = s == s2 ? true : false;
            //Console.WriteLine(s.Equals(s2));//true
            //Console.WriteLine(b);//true
            //Console.WriteLine(s+"def");
            //Console.WriteLine(s);
            s += "def";
            //Console.WriteLine(s);

            Console.WriteLine(String.Compare(s, s2, false));//0 - same, 1 - left>right, -1 - right>left

            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s2.ToLower());

            //foreach(char c in s){
            //    Console.WriteLine(c);
            //}

            char[] cArr = new char[s.Length];
            int i = 0;
            foreach (char c in s)
            {
                cArr[i] = c;
                i++;
                Console.Write(c);
            }

            char myChar = s[0];
            s2.IndexOf('b');

            int ind = s2.IndexOfAny(cArr);//int index = name.IndexOfAny(new char[] { 'a', 'b', 'c' }); returns the index of first found
            int ind2 = s2.LastIndexOfAny(cArr);// returns the first match from the end;
            int ind3 = s2.LastIndexOf('c');
            bool cont = s.Contains("ab");
            string newS = s.Substring(0, 3);
            Console.WriteLine();
            Console.WriteLine("substring: " + newS);
            string empty = " ";
            string blank = "";
            empty = string.Empty;
            bool isNullorEmpty = String.IsNullOrEmpty(empty);

            Console.WriteLine(isNullorEmpty);
            bool isNullOrWhiteSpace = String.IsNullOrWhiteSpace(blank);
            Console.WriteLine(isNullOrWhiteSpace);

            //test modification
            Console.WriteLine("test");
        }

    }
}
