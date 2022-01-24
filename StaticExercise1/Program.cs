using System;

namespace StaticExercise1
{
     class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"Celsius {celsius}");
            Console.WriteLine();
            Console.WriteLine();

            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"Fahrenheit {fahrenheit}");
        }

    }
}
