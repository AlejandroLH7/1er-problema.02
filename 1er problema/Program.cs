using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1er_problema
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            float c = 0.0f, f = 0.0f;
            
            Console.WriteLine("Ingrese la temperatura en grados Fahrenheit: ");
           
            f = Convert.ToSingle(Console.ReadLine());
            c = (f - 32) * 5 / 9;
            
            Console.WriteLine("La temperatura equivalente de {0} grados Fahrenheit en Celsius es: {1}", f, c);
           
            Console.ReadKey();            
        }
    }
}
