using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double CelsiusToFahrenheit(double dInCelsius) 
        {
            return (dInCelsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double dInFahrenheit)
        {
            return (dInFahrenheit - 32) /1.8;
        }

        public static double GetTemp(string userPrompt)
        {
            double userInput = 0;
            bool validUserInput = false;
            do
            {
                if (Double.TryParse(Console.ReadLine(), out userInput))
                {
                    validUserInput = true;
                    Console.WriteLine("Thanks!\n");
                }
                else
                {
                    Console.WriteLine("Sorry, this is not a valid input. You need to provide temperature as a double, retry please:  ");
                }
            }
            while (!validUserInput);
            return userInput;
        }
    }
}
