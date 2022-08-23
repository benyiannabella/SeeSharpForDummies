using System;


namespace SeeSharpForDummies
{
    internal class DatesAndTimes
    {
        static void Dates()
        {
            //DateTime dt = DateTime.Now;
            //DateTime dt1 = DateTime.Today;
            //Console.WriteLine(dt1.ToString());
            ////Console.WriteLine(dt.ToString());
            //Console.WriteLine(dt.ToShortDateString());
            //Console.WriteLine(dt.ToShortTimeString());
            //Console.WriteLine(dt.ToLongDateString());
            //Console.WriteLine(dt.ToLongTimeString());

            //Console.WriteLine(dt.AddDays(3).ToLongDateString());//add
            //Console.WriteLine(dt.AddDays(-3).ToLongDateString());//subtract
            //Console.WriteLine(dt.AddHours(3).ToLongTimeString());
            //Console.WriteLine(dt.AddHours(-3).ToLongTimeString());

            //Console.WriteLine(dt.Month);
            //Console.WriteLine(dt.Day);

            //DateTime myBirthday = new DateTime(1983, 6, 23);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("6/23/1983");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
           
            Console.WriteLine(myAge.TotalDays);
            
        }
    }
}
