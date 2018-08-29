using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos
{
    class Nodo
    {
        public string Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo()
        {

        }

        public Nodo(string valor)
        {
            this.Valor = valor;
        }

        public Nodo(string valor, Nodo siguiente)
        {
            this.Valor = valor;
            this.Siguiente = siguiente;
        }
    }
}
