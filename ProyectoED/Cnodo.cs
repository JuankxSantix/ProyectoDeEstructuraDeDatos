using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoED
{
    class Cnodo
    {
        //Aqui colocamos el dato que guarda el nodo
        private string dato;
        private int posicion;
        //Esta variable de referencia es usada para apuntar el nodo siguiente
        private Cnodo siguiente = null;
        //Propiedades que se usara
        public string Dato { get => dato; set => dato = value; }
        //public int Posicion { get => posicion; set => posicion = value; }
        internal Cnodo Siguiente { get => siguiente; set => siguiente = value; }
        //Mejor imprecion
        public override string ToString()
        {
            return string.Format("[{0}]",posicion);
        }
    }
}
