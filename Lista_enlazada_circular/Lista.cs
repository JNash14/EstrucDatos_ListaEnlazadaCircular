using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_enlazada_circular
{
    class Lista
    {
        private Nodo pri = new Nodo();
        private Nodo ulti = new Nodo();

        public Lista()
        {
            pri = null;
            ulti = null;
        }

        public void insertar_Final (int valor) //10
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = valor;

            if (pri == null)
            {
                pri = nuevo;
                ulti = nuevo;
                pri.Sgte = pri;               
                pri.Ant = pri;
            }
            else
            {
                ulti.Sgte = nuevo;
                nuevo.Ant = ulti;
                nuevo.Sgte = pri;
                ulti = nuevo;
                pri.Ant = ulti;
            }
        }

        public bool listado(ListBox lista)
        {
            Nodo actual = pri;
            do
            {
                lista.Items.Add(actual.Dato);
                actual = actual.Sgte;
            }
            while (actual != pri);

            return true;
        }


        public void insertar_inicio(int valor)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = valor;

            if (pri == null)
            {
                pri = nuevo;
                ulti = nuevo;
                pri.Sgte = pri;
                pri.Ant = pri;
            }
            else
            {
                nuevo.Ant = ulti;
                nuevo.Sgte = pri;
                pri.Ant = nuevo;
                pri = nuevo;
                ulti.Sgte = pri;
            }
        }

        public bool Buscar(int valor)
        {
            Nodo actual = pri;
            do
            {
                if (actual.Dato == valor) 
                    return true;
                actual = actual.Sgte;
            }
            while (actual != pri);

            return false;
        }

        public bool Modificar(int d1, int d2)
        {
            Nodo actual = pri;
            do
            {
                if (actual.Dato == d1)
                    actual.Dato = d2;
                actual = actual.Sgte;
            }
            while (actual != pri);

            return false;
        }

        public void contar()
        {
            int contador = 0;

            Nodo actual = pri;
            do
            {
                contador++;
                actual = actual.Sgte;
            }
            while (actual != pri);
            MessageBox.Show("La lista circular tiene " + contador + " elementos");
        }
    }
}
