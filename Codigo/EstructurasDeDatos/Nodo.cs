using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos
{
    class Nodo<T>
    {
        public T Valor { get; set; }
        public Nodo<T> Siguiente { get; set; }

        public Nodo()
        {

        }

        public Nodo(T valor)
        {
            this.Valor = valor;
        }

        public Nodo(T valor, Nodo<T> siguiente)
        {
            this.Valor = valor;
            this.Siguiente = siguiente;
        }
    }
}
