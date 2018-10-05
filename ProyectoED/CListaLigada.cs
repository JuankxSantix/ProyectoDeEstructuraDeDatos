using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoED
{
    class CListaLigada
    {
        //Es el ancla o encabezado de la lista
        private Cnodo ancla;
        //esta variable de referencia nos ayuda a trabajar con la lista
        private Cnodo trabajo;
        //Esta variable de referencia apoya en ciertas operaciones de la lista
        private Cnodo Trabajo2;
        public CListaLigada()
        {
            //instanciamos el ancla
            ancla = new Cnodo();
            //como es una lista vacia su siguiente es null
            ancla.Siguiente = null;
        }
        //Recorre toda la lista

        public void Transversa()//
        {
            //Trabajo al inicio
            trabajo = ancla;
            //Recorremos hasta el final
            while (trabajo.Siguiente!=null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                //Obtenemos el dato y lo mistramos
                string dato = trabajo.Dato;
                //int pos = trabajo.Posicion;
                Console.WriteLine("{0}",dato);
            }
            //Bajamos la ninea
            Console.WriteLine();
        }
        //adiciona 
        public void Adicionar(string pDato)//
        {
            //int num=0;
            // trabajo al inicio
            trabajo = ancla;
            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                //num++;
            }

            //creamos el nuevo nodo
            Cnodo temp = new Cnodo();

            //insertamos el dato
            temp.Dato = pDato;
            //temp.Posicion = num;
            //Finalizamos correctamente
            temp.Siguiente = null;
            //ligamos el ultimo nodo encontrado con el recien creado
            trabajo.Siguiente = temp;


        }
        public void Vaciar()//
        {
            ancla.Siguiente = null;
            
        }
        public bool EstaVacia()
        {
            if (ancla.Siguiente == null)
                return true;
            else
                return false;
        }
        public Cnodo Buscar(string dato)//
        {
            if (EstaVacia())
                return null;
            Trabajo2 = ancla;

            while (Trabajo2.Siguiente!=null)
            {
                Trabajo2 = Trabajo2.Siguiente;
                if (Trabajo2.Dato == dato)
                    return Trabajo2;
            }
            //no se encontro el dato
            return null;
        }
        public int BuscarIndice(string dato)
        {
            int n = -1;
            trabajo = ancla;
            while (trabajo.Siguiente!=null)
            {
                trabajo = trabajo.Siguiente;
                n++;
                if (trabajo.Dato == dato)
                    return n;
            }
            return -1;
        }
        public Cnodo BuscarANterior(string dato)
        {
            Trabajo2 = ancla;
            while (Trabajo2.Siguiente!=null && Trabajo2.Siguiente.Dato!=dato)
            {
                Trabajo2 = Trabajo2.Siguiente;
            }
            return Trabajo2;
        }
        public void Borrar(string dato) //
        {
            if (EstaVacia())
                return;
            Cnodo anterior = BuscarANterior(dato);

            Cnodo encontrado = Buscar(dato);

            if (encontrado == null)
                return;

            anterior.Siguiente = encontrado.Siguiente;

            encontrado.Siguiente = null;
        }
        public void Insertar(string DatoDonde, string dato) //
        {
            trabajo = Buscar(DatoDonde);
            if (trabajo == null)
                return;
            Cnodo temp = new Cnodo();
            temp.Dato = dato;

            temp.Siguiente = trabajo.Siguiente;
            trabajo.Siguiente = temp;
        }
        public void InsertarAlInicio( string dato) //
        {
            
            Cnodo temp = new Cnodo();
            temp.Dato = dato;

            temp.Siguiente = ancla.Siguiente;
            ancla.Siguiente = temp;
        }
        public Cnodo ObtenerPorIndice(int  PIndice)
        {
            Cnodo trabajo2 = null;
            int indice = -1;
            trabajo = ancla;
            while (trabajo.Siguiente!=null)
            {
                trabajo = trabajo.Siguiente;
                indice++;
                if (indice == PIndice)
                    trabajo2 = trabajo;
            }
            return trabajo2;
            //poner condiciones
        }
        //para cambiar un dato
        public string this[int pIndice]
        {
            get
            {
                trabajo = ObtenerPorIndice(pIndice);
                return trabajo.Dato;
            }
            set
            {
                trabajo = ObtenerPorIndice(pIndice);
                if (trabajo != null)
                    trabajo.Dato = value;
            }
        }
    }
}
