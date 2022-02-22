using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    //---------------------------------------------------------------------------------------------------//
    //---------------------------------------------------------------------------------------------------//
    //                                         CLASE PILA                                                //
    //---------------------------------------------------------------------------------------------------//
    //---------------------------------------------------------------------------------------------------//

    class Pila
    {

        //--------------------------------------------------------------------------------------//
        //----------------------------------- PROPIEDADES --------------------------------------//

        public int Size { get; set; } //Tamaño --> Cantidad de discos que hay en el palo.

        public int Top { get; set; } //Top ---> Disco que está en la parte superior del palo.

        public List<Disco> Elementos { get; set; } //Elementos ---> Conjunto de discos que hay en ese palo.


        //--------------------------------------------------------------------------------------//
        //------------------------------------- MÉTODOS ----------------------------------------//

        //----------- CONSTRUCTOR -----------//

        public Pila()
        {
            this.Size = 0;
        }

        public Pila(List<Disco> listaDiscos)
        {
            this.Elementos = listaDiscos;
            this.Size = listaDiscos.Count;
            this.Top = listaDiscos.Count - 1;
        }

        //--------------------------------------------------------------------------------------//
        //------------------------------------ ANYADIRDISCO -------------------------------------//
        public void anyadirDisco(Disco d)
        {
            Elementos.Add(d);
            this.Top = d.Valor;
            this.Size = Elementos.Count;
        }

        //--------------------------------------------------------------------------------------//
        //------------------------------------ EXTRAERDISCO -------------------------------------//
        public Disco extraerDisco()
        {
            Elementos.Remove(Elementos[Elementos.Count - 1]);
            this.Top = Elementos.Count - 1;
            this.Size = Elementos.Count;
            return null;
        }

        //----------------------------------------------------------------------------------------//
        //--------------------------------------- ISEMPTY ----------------------------------------//
        public bool isEmpty()
        {
            if (Elementos.Count == 0)
            {
                return true;
            }
            return false;
        }

    }
    //--------------------------------------------------------------------------------------//
    //--------------------------------------------------------------------------------------//
    //--------------------------------------------------------------------------------------//
}
