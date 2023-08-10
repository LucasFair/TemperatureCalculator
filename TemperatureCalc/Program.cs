using System;

namespace TemperatureCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            double celcius;
            double reaumur;
            double fahren;

            // Adding some information by writing to the console
            Console.WriteLine("This is a temperture converter.\nThere are three measurements to pick from.\n" +
                "Celcius, fahrenheit and reaumur.\n\nEnter \"C\" to input celcius, \"F\" to input fahrenheit, " +
                "or \"R\" to input reaumur.\nOtherwise type anything else to exit the application.\n");

            Console.Write("> ");
            string choiceIn = Console.ReadLine();  // Allows for input
            string choiceOut = choiceIn.ToUpper();  // This turns the input into uppercase
            switch (choiceOut)  // The switch will allow for cases, that is, decisions to be made.
            {
                case "C":
                case "\"C\"":  //  If the user is obtuse to a pedantic degree, in case they add the quotation marks it will still work.
                    Console.WriteLine("Enter celcius:");
                    while (true)  // Using a while loop to prevent an input that is not a double to crash the program.
                                  // Originally, this was a try-catch with a FormatExecption, but this will suffice.
                    {
                        Console.Write("> ");
                        if (double.TryParse(Console.ReadLine(), out celcius)) break;
                        Console.WriteLine("Your input is invalid. Please try again.");
                    }
                    //Console.WriteLine("Fahrenheit = " + ((celcius * 1.8) + 32));
                    Console.WriteLine("Fahrenheit = " + ((celcius * 9 / 5) + 32));
                    Console.WriteLine("Reaumur = " + (celcius * 0.8));
                    break;

                case "F":
                case "\"F\"":
                    Console.WriteLine("Enter fahrenheit:");
                    while (true)
                    {
                        Console.Write("> ");
                        if (double.TryParse(Console.ReadLine(), out fahren)) break;
                        Console.WriteLine("Your input is invalid. Please try again.");
                    }
                    Console.WriteLine("Celcius = " + ((fahren - 32) * 5 / 9));
                    Console.WriteLine("Reaumur = " + (((fahren - 32) * 4) / 9));
                    break;

                case "R":
                case "\"R\"":
                    Console.WriteLine("Enter reaumur:");
                    while (true)
                    {
                        Console.Write("> ");
                        if (double.TryParse(Console.ReadLine(), out reaumur)) break;
                        Console.WriteLine("Your input is invalid. Please try again.");
                    }
                    Console.WriteLine("Celcius = " + (reaumur * 1.25));
                    Console.WriteLine("Fahrenheit = " + ((reaumur * 9 / 4) + 32));
                    break;
            }
            Console.WriteLine("\nGood-bye!\n");  // This is a farewell message that says "Good-bye" to the user.
        }
    }
}