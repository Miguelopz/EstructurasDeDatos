using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos
{
    class NodoEnlazado<T> : Nodo<T>
    {
        public int Posicion { get; set; }
        public NodoEnlazado<T> Anterior { get; set; }

        public NodoEnlazado(T valor)
            : base(valor)
        {
        }

        public NodoEnlazado(T valor, Nodo<T> siguiente)
            : base(valor, siguiente)
        {
        }
    }
}
