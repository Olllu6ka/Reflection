using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var libraryPas = @"C:\Users\Мой друг\source\repos\Converter_temperarure_libr\Converter_temperarure_libr\bin\Debug\Converter_temperarure_libr.dll";
            Assembly assembly = Assembly.LoadFrom(libraryPas);
            var printerClass = assembly.GetTypes().First(t => t.FullName == TYPE_NAME);
            foreach (Type type in assembly.GetTypes())
            {
                Console.WriteLine($"Full name: {type.FullName}");
                Console.WriteLine($"Is visible: {type.IsVisible}");
                Console.WriteLine($"Base type: {type.BaseType}");
                Console.WriteLine($"Module: {type.Module}");
            }
            Console.WriteLine();
            var instanse = Activator.CreateInstance(printerClass);
            MethodInfo printMethod = printerClass.GetMethod(TYPE_Celsius);
            printMethod.Invoke(instanse,null);
            Console.WriteLine();
            MethodInfo print = printerClass.GetMethod(TYPE_FahrenheitToCelsius);
            print.Invoke(instanse,null);
            Console.ReadKey();
        }
        static string TYPE_NAME = "Converter_temperarure_libr.Converter_temperarure";
        static string TYPE_Celsius = "CelsiusToFahrenheit";
        static string TYPE_FahrenheitToCelsius = "FahrenheitToCelsius";
    }
}
