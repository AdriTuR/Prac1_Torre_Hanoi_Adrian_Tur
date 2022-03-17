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
            this.Top = 0;
            this.Elementos = new List<Disco>();
        }

        //--------------------------------------------------------------------------------------//
        //------------------------------------ ANYADIRDISCO -------------------------------------//
        public void anyadirDisco(Disco d)
        {
            this.Elementos.Add(d);
            this.Top = d.Valor;
            this.Size = Elementos.Count;
        }

        //--------------------------------------------------------------------------------------//
        //------------------------------------ EXTRAERDISCO -------------------------------------//
        public Disco extraerDisco()
        {
            Disco discoTop = Elementos.Last();
            
            //Actualizarción de la pila
            this.Elementos.Remove(discoTop);
            this.Size = Elementos.Count;

            if(Elementos.Count == 0)
            {
                this.Top = 0;
            }
            else
            {
                this.Top = Elementos.Last().Valor;
            }
            
            return discoTop;
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
