using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {

       public int movimientos;

        //--------------------------------------------------------------------------------------//
        //------------------------------------- MÉTODOS ----------------------------------------//

        //----------- CONSTRUCTOR -----------//

        public Hanoi()
        {
            this.movimientos = 0;
        }

        //----------------------------------------------------------------------------------------//
        //------------------------------------- MOVERDISCO ---------------------------------------//
        public void mover_disco(Pila a, Pila b)
        {
            if(a.isEmpty())
            {
                a.anyadirDisco(b.extraerDisco());
                movimientos++;
            }
            else if (b.isEmpty())
            {
                b.anyadirDisco(a.extraerDisco());
                movimientos++;
            }
            else if (a.Top < b.Top)
            {
                b.anyadirDisco(a.extraerDisco());
                movimientos++;
            }
            else
            {
                a.anyadirDisco(b.extraerDisco());
                movimientos++;
            }
        }

        //----------------------------------------------------------------------------------------//
        //------------------------------------- ITERATIVO ----------------------------------------//
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            mostrarPilas(ini, aux, fin);

            if(n % 2 == 0)
            {
                while(fin.Size != n )
                {
                    mover_disco(ini, aux);
                    mostrarPilas(ini, aux, fin);
                    mover_disco(ini, fin);
                    mostrarPilas(ini, aux, fin);
                    mover_disco(aux, fin);
                    mostrarPilas(ini, aux, fin);
                }
            }
            else
            {
                while(fin.Size != n)
                {
                    mover_disco(ini, fin);
                    mostrarPilas(ini, aux, fin);
                    mover_disco(ini, aux);
                    mostrarPilas(ini, aux, fin);
                    mover_disco(aux, fin);
                    mostrarPilas(ini, aux, fin);
                }
            }
            int total_movimientos = this.movimientos;
            return total_movimientos;
        }

        //----------------------------------------------------------------------------------------//
        //----------------------------------- MOSTRARPILAS ---------------------------------------//
        public void mostrarPilas(Pila ini, Pila aux, Pila fin)
        {
                    Console.Write(" [ ");
                    for(int i=0;i<ini.Elementos.Count;i++) 
                    {
                        Console.Write(ini.Elementos[i].Valor);
                    }
                    Console.Write(" ] , [ ");
                    for(int i=0;i<aux.Elementos.Count;i++) 
                    {
                        Console.Write(aux.Elementos[i].Valor);
                    }
                    Console.Write(" ] , [ ");
                    for(int i=0;i<fin.Elementos.Count;i++) 
                    {
                        Console.Write(fin.Elementos[i].Valor);
                    }
                    Console.Write(" ] ");
                    if(movimientos != 0)
                    {
                    Console.Write(" => Movimiento: ");
                    Console.Write(movimientos); 
                    }
                    Console.WriteLine();
        }

    }

     //--------------------------------------------------------------------------------------//
    //--------------------------------------------------------------------------------------//
    //--------------------------------------------------------------------------------------//
}
