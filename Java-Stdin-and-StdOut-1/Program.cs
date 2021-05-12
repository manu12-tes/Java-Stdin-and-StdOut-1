using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Stdin_and_StdOut_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introudce una cadena y un numero sin punto decimal");
            String myString = Console.ReadLine();
            String entrada = Console.ReadLine();
            int myInt = Convert.ToInt32(entrada);
            Console.WriteLine("My string: " + myString);
            Console.WriteLine("My int: " + entrada);
        }
    }
}
