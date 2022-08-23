using System;


namespace SeeSharpForDummies
{
    class CalcIntrest
    {

        static void Calc()
        {
            Console.WriteLine("Please enter your deposit amount:");

            string? input = Console.ReadLine();
            decimal deposit = Convert.ToDecimal(input);

            while (deposit < 0)
            {
                Console.WriteLine("Deposit cannot be negative");
                Console.WriteLine("Please enter your deposit amount again:");
                input = Console.ReadLine();
                deposit = Convert.ToDecimal(input);
            }

            Console.WriteLine("Please enter the requested intrest rate:");
            string? input2 = Console.ReadLine();
            decimal rate = Convert.ToDecimal(input2);

            while (rate < 0)
            {
                Console.WriteLine("Interest cannot be negative");
                Console.WriteLine("Please enter the requested intrest rate again:");
                input2 = Console.ReadLine();
                rate = Convert.ToDecimal(input2);
            }
            Console.WriteLine("Please insert the number of years you would like the interest to be calculated:");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int years = 0;
           
            while (years < input3)
            {
                decimal intrest = deposit * (rate / 100);
                Console.WriteLine(String.Format("Calculated monthly interest is: {0:N2}$", intrest));
                deposit = deposit + intrest;
                years++;
            }
            
            Console.WriteLine(String.Format("Your total amount this mount will be {0:N2}$: ", deposit));
           
            Console.Read();
        }
    }
}
