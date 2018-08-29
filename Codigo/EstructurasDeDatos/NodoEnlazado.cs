using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos
{
    class NodoEnlazado : Nodo
    {
        public int Posicion { get; set; }
        public NodoEnlazado Anterior { get; set; }

        public NodoEnlazado(string valor)
            : base(valor)
        {
        }

        public NodoEnlazado(string valor, Nodo siguiente)
            : base(valor, siguiente)
        {
        }
    }
}
