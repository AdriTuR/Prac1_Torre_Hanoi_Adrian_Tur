using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        public Pila Ini = new Pila();
        public Pila Aux = new Pila();
        public Pila Fin = new Pila();

        static void Main(string[] args)
        {

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
