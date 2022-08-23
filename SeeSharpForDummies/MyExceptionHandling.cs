using System;

namespace SeeSharpForDummies
{
    class MyExceptionHandling
    {
        public static int FactorialCalc()
        {
            Console.WriteLine("Enter a positive number or quit:");
            string ? input = Console.ReadLine();
            int factor = 1;
            int n = 0;
            
            if (int.TryParse(input, out n))
            {
                if(n > 0)
                {
                    for(int i = 1; i <= n; i++)
                    {
                        factor*=i;
                    }
                    
                } else if (n == 0){
                    factor = 1;

                } else
                {
                    throw new ArgumentOutOfRangeException(String.Format(
                        "Illegal negative argument to Factorial {0}", factor));
                }
                Console.WriteLine("calculated factorial for " + n + " is: " + factor);
            } else if(input.Equals("Quit"))
            {
                System.Environment.Exit(-1);
            }
            
            return factor;
        }

        static void Test()
        {
            try
            {
                FactorialCalc();
            } catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
               
            }
        }
    }
}
