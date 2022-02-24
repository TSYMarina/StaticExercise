using System;

namespace StaticExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, Human! Looking for help with temperature conversions? I can do that for you!\n");

            var celsius = TempConverter.FahrenheitToCelsius(2); 
            var fahrenheit = TempConverter.CelsiusToFahrenheit(-10); 

            Console.WriteLine("Please see the results of the conversions:\n");
            Console.WriteLine($"Your input in Fahrenheit equals to {celsius} degrees in Celsius.");
            Console.WriteLine($"Your input in Celsius equals to  {fahrenheit} degrees in Fahrenheit.");

        }


        //static public int ConversionDirection(string userPrompt)
        //{
        //    int userInt = 0;
        //    bool validUserInt = false;
        //    do
        //    {
        //        if (userInt == 1 || userInt == 2)
        //        {
        //            validUserInt = true;
        //            Console.WriteLine("Thanks!\n");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Sorry, this is not a valid input. You need to choose 1 or 2, retry please:  ");
        //        }
        //    }
        //    while (!validUserInt);
        //    return userInt;
        //}
    }
}
