using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Inicialización de las variables pilas

            Pila Ini = new Pila();
            Pila Aux = new Pila();
            Pila Fin = new Pila();

            //Muestra en pantalla
            Console.WriteLine("--------------------------- TORRES DE HANOI ---------------------------");
            Console.WriteLine("Indica el número de discos que:");
            string Input = Console.ReadLine();

            //Comprobación de si se introduce un número entero
            while (int.TryParse(Input, out int numero) == false)
            {
                Console.WriteLine("Porfavor, introduce un número entero:");
                Input = Console.ReadLine();
            }

            Console.WriteLine("----------------------------- Movimientos -----------------------------");
            
            int numero_discos = int.Parse(Input);
            

            
        }
    }
}
