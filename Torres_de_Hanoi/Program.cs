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

            //Muestra en pantalla
            Console.WriteLine("--------------------------- TORRES DE HANOI ---------------------------");
            Console.WriteLine("Indica el número de discos:");
            string Input = Console.ReadLine();

            //Comprobación de si se introduce un número entero
            while (int.TryParse(Input, out int numero) == false)
            {
                Console.WriteLine("Porfavor, introduce un número entero:");
                Input = Console.ReadLine();
            }
            Console.WriteLine("----------------------------- Movimientos -----------------------------");
            
            //Inicialización de las variables pilas
            Pila Ini = new Pila();
            Pila Aux = new Pila();
            Pila Fin = new Pila();

            //Creación de discos en la Pila Ini
            int numero_discos = int.Parse(Input);  
            for (int i = numero_discos ; i >= 1; i--)
            {
                Disco d = new Disco(i);
                Ini.anyadirDisco(d);
            }

            //Inicialización de Hanoi
            Hanoi hanoi = new Hanoi();
            int totalmovimientos = hanoi.iterativo(numero_discos, Ini, Fin, Aux);


            Console.WriteLine("-----------------------------------------------------------------------");
            Console.Write("  Movimientos totales: ");
            Console.Write(totalmovimientos);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
