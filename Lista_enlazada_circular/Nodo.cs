using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_enlazada_circular
{
    class Nodo
    {
        
        private int dato;
        private Nodo ant;
        private Nodo sgte;

        //Recuerda que se encapsula para proteger el dato
        public int Dato { get => dato; set => dato = value; }
        internal Nodo Ant { get => ant; set => ant = value; }
        internal Nodo Sgte { get => sgte; set => sgte = value; }
    }
}
