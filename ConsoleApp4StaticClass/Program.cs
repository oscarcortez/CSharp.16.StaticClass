using Models;
using System;

namespace ConsoleApp4StaticClass
{
    class Program
    {
        /// <summary>
        /// STATIC: una clase estatica no puede ser instanciada
        /// una clase normal puede tener static methods y se las llama sin instanciar la clase
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine($"Calculadora.suma: {Calculadora.Suma(4,5) }");

            Calculadora c = new Calculadora();

            Console.WriteLine($"calculadora instanciada: {c.Mult(2, 4)}");
            
        }
    }
}
