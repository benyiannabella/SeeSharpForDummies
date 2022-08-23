using System;
using System.Collections;

namespace SeeSharpForDummies
{
    class Iterate
    {
        static void IterationTypes()
        {
            List<string> colors = new List<string> { "Red", "Yellow", "Green", "Blue" };

            Console.WriteLine("iterate using delegate:");
            colors.ForEach(delegate(string color)
            {
                Console.WriteLine(color);
            });

            Console.WriteLine("iterate using foreach");
            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("iterate using enumerator:");
            IEnumerator enumerator = colors.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.ReadLine();
        }
    }
}
