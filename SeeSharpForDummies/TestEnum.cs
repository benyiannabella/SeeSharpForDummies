
namespace SeeSharpForDummies
{
    
    public class TestEnum
    {
       
        static void myTest()
        {
            // Display the color name.
            Console.WriteLine($"Color Name: {Colors.Blue}.");
            // Display the color value.
            Console.WriteLine($"Color Value: {(int)Colors.Blue}.");

            Console.WriteLine("\r\nEnum Colors names: ");
            foreach(string s in Enum.GetNames(typeof(Colors))){
                Console.WriteLine(s);
            }

            Console.WriteLine("\r\nAll Color Values:");
            foreach(Colors color in Enum.GetValues(typeof(Colors))){
                Console.WriteLine($"{color} is {color.GetTypeCode()} = {(int)color}");
            }
        }
    }
}
