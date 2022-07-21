using System;

namespace EnhancedIfStatements_TernaryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;

            // 1 Basic if else statement 
            if (temperature < 0)
                stateOfMatter = "solid"; //what happened with the curly brackets? dont need them ever?
            else if (temperature > 0 && temperature < 100)
                stateOfMatter = "liquid";
            else
                stateOfMatter = "gas";

            Console.WriteLine($"State of matter is {stateOfMatter}");

            temperature += 30;

            // 2 Enhanced if statement = in short
            //stateofmatter = temperature < 0 "if yes, then" "solid" "if no then" "liquid")
            stateOfMatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");

            //increasing temp after that console write
            temperature += 200;
            stateOfMatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";
            Console.WriteLine($"State of matter is {stateOfMatter}");

            Console.ReadKey();
        }
    }
}
