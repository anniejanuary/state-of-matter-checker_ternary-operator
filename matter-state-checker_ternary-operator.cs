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
            else
                stateOfMatter = "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}"); 
            
            // 2 Enhanced if statement = in short
            //stateofmatter = temperature < 0 "if yes, then" "solid" "if no then" "liquid")
            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");

            //increasing temp after that console write
            temperature += 30;
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine($"State of matter is {stateOfMatter}");

            Console.ReadKey();
        }
    }
}
