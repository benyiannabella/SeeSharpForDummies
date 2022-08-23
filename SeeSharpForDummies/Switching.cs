using System;

namespace SeeSharpForDummies
{
    public enum DayOfWeeks
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    class Switching
    {
        public static string SwitchDays(DayOfWeeks day) => day switch
        {
            DayOfWeeks.Monday => "Have a Good Monday!",
            DayOfWeeks.Tuesday => "Have a Good Tuesday!",
            DayOfWeeks.Wednesday => "Have a Good Tuesday!",
            DayOfWeeks.Thursday => "Have a Good Tuesday!",
            DayOfWeeks.Friday => "Have a Good Tuesday!",
            DayOfWeeks.Saturday => "Have a Good Tuesday!",
            DayOfWeeks.Sunday => "Have a Good Tuesday!",
            _ => "Not a valid day!"
                       
        };

        static void Greet()
        {
            Console.WriteLine(SwitchDays(DayOfWeeks.Tuesday));
        }
    }
}
