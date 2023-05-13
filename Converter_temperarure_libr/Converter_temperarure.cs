using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_temperarure_libr
{
    class Converter_temperarure
    {
        public void CelsiusToFahrenheit()
        {
            //Console.Write($"Введино цельсия: {VALUE}");
            int Celsius = 50; /*int.Parse(VALUE);*/
            Celsius = ((Celsius - 32) * 5) / 9;
            Console.Write($"Fahrenheit To Celsius - {Celsius}");
            object test = new object();
        }
        public void FahrenheitToCelsius()
        {
            //Console.WriteLine("Введите: ");
            //double Celsius = double.Parse(Console.ReadLine());
            int Fahrenheit = 10; /*int.Parse(value);*/
            Fahrenheit = ((Fahrenheit * 9) / 5) + 32;
            Console.Write($"Celsius To Fahrenheit - {Fahrenheit}");
            object test = new object();
            Console.ReadKey();
        }
    }
}
