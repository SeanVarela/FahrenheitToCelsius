using System;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("[1] Celsius to Fahrenheit / [2] Fahrenheit to Celsius: ");

            int choice = Int16.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("What is the temperature in Celsius? : ");

                int inputCelsius = Int16.Parse(Console.ReadLine());

                double finalFahrenheit = (1.8 * inputCelsius) + 32;

                Console.WriteLine("The temperature in Fahrenheit is : " + finalFahrenheit);

                Console.WriteLine("Press Enter to quit");

                Console.ReadLine();
            }
            else if (choice == 2)
            {
               Console.Write("What is the temperature in Fahrenheit? : ");

               int inputFahrenheit = Int16.Parse(Console.ReadLine());

               double Celsius = (inputFahrenheit - 32) * .55555555555;

               double finalCelsius = Math.Round(Celsius);

               Console.WriteLine("The temperature in Celsius is : " + finalCelsius);

               Console.WriteLine("Press Enter to quit");

               Console.ReadLine();
            }
        }
    }
}
