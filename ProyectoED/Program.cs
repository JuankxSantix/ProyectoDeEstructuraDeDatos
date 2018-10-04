using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoED
{
    class Program
    {
        static void Main()
        {
            int Opcion=0;
            
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("\t\t  MENU");
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("|   1.- Unidad II ''Recursividad''          |");
                Console.WriteLine("|   2.- Unidad III ''Estructuras lineales'' |");
                Console.WriteLine("|   3.- Salir                               |");
                try
                {
                    Opcion = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine("",ex.Message);
                    Console.ReadLine();
                    Main();
                }
                switch (Opcion)
                {
                    case 1:
                        Recursividad();
                        Main();
                        break;
                    case 2:
                        UnidadIII();
                        Main();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Gracias por utilizar el programa ");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Error");
                        Main();
                        break;
                }

            void Recursividad()
            {
                string Respuesta = "";
                do
                {
                    try
                    {
                        Console.Clear();
                        int valor;
                        Console.WriteLine("Ingresa el numero:");
                        valor = int.Parse(Console.ReadLine());
                        Recursivo r = new Recursivo();
                        Console.WriteLine("El factorial de {0} es: {1}", valor, r.Fac(valor));
                        Console.ReadLine();
                        Console.WriteLine("Deseas calcular otro factorial S | N");
                        Respuesta = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Error en: {0}", ex);
                        Recursividad();
                    }
                    if (Respuesta == "S" || Respuesta == "n")
                        break;
                } while (Respuesta != "N" || Respuesta != "n");

                


            }
            void UnidadIII()
            {
                string Respuesta = "";
                do
                {
                    Console.Clear();

                    int res;
                    Console.WriteLine("1.- Pilas");
                    Console.WriteLine("2.- Colas");
                    Console.WriteLine("3.- Listas enlazadas simples");
                    Console.WriteLine("4.- Regresar");
                    res = int.Parse(Console.ReadLine());

                    switch (res)
                    {
                        case 1:
                            Pilas();
                            break;
                        case 2:
                            Colas();
                            break; 
                        case 3:
                            ListasEnlazadas();
                            break;
                        case 4:
                            Console.WriteLine("Esta seguro de Regresar S | N");
                            Respuesta=Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Error\nOpcion No encontrada");
                            break;
                    }

                    if (Respuesta == "S" || Respuesta == "s")
                        break;

                } while (Respuesta != "S" || Respuesta != "s");
                


            }
            void ListasEnlazadas()
            {
                Console.Clear();

                int respuesta = 0; ;

                CListaLigada miLista = new CListaLigada();

                do
                {
                    Console.Clear();
                    Console.WriteLine("1.- Insertar al incio");
                    Console.WriteLine("2.- Insertar al final");
                    Console.WriteLine("3.- Insertar en medio");
                    Console.WriteLine("4.- Eliminar ");
                    Console.WriteLine("5.- Buscar ");
                    Console.WriteLine("6.- Mostrar la lista");
                    Console.WriteLine("7.- Nueva lista lista");
                    Console.WriteLine("8.- Salir");

                    respuesta = int.Parse(Console.ReadLine());

                    switch (respuesta)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingresa el dato a insertar");
                            miLista.InsertarAlInicio(Console.ReadLine());
                            Console.Write("\nSe adiciono satisfacoriamente");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Ingresa el dato a insertar");
                            miLista.Adicionar(Console.ReadLine());
                            Console.Write("\nSe adiciono satisfacoriamente");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            string dato = "";
                            Console.WriteLine("antes de que dato deseas insertar");
                            dato = Console.ReadLine();
                            miLista.Insertar(dato, Console.ReadLine());
                            Console.Write("\nSe adiciono satisfacoriamente");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Ingresa el dato a eliminar");
                            miLista.Borrar(Console.ReadLine());
                            Console.Write("\nSe adiciono satisfacoriamente");
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Ingresa el dato a buscar");
                            //hrf
                            Console.Write(miLista.Buscar(Console.ReadLine()));
                            Console.ReadLine();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Los elementos se veran separados por un salto de linea");
                            miLista.Transversa();
                            Console.ReadLine();
                            break;
                        case 7:
                            Console.Clear();
                            string res = "";
                            Console.WriteLine("Esta seguro de crear una nueva lista, perdera sus datos\nS | N");
                            res = Console.ReadLine();
                            if (res == "S" || res == "s")
                                miLista.Vaciar();
                            break;
                        case 8:
                            break;
                        default:
                            Console.WriteLine("Opcion no reconocida por favor verifique su respuesta");
                            Console.ReadLine();
                            break;
                    }

                } while (respuesta != 8);

            }
            void Pilas()
            {
                Console.Clear();
                int opcion2 = 0;
                int max;
                int tope = 0;

                Console.Write("Digite el maximo de elementos de la pila: ");
                max = int.Parse(Console.ReadLine());
                string[] pila = new string[max];
                do
                {
                    Console.Clear();
                    Console.Write("1. Insertar un elemento\n2. Eliminar un elemento\n3. Mostrar Pila\n4. Salir\nOpcion: ");
                    opcion2 = int.Parse(Console.ReadLine());
                    switch (opcion2)
                    {
                        case 1:
                            Console.Clear();
                            if (tope == max)
                            {
                                Console.WriteLine("Lapila esta llena, no se pueden gregar mas elementos");
                            }
                            else
                            {
                                Console.WriteLine("Inserte el elemento: ");
                                pila[tope] = Console.ReadLine();
                                tope++;
                                Console.WriteLine("\nEL ELEMENTO FUE AGREGADO");
                            }
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            string eliminar;
                            bool encontrado = false;
                            if (tope == 0)
                            {
                                Console.WriteLine("La pila esta vacia, no nay elementos");
                            }
                            else
                            {
                                Console.Write("Inserte el elemento que desea eliminar: ");
                                eliminar = Console.ReadLine();
                                for (int i = 0; i < max; i++)
                                {
                                    if (pila[i] == eliminar)
                                    {
                                        encontrado = true;
                                        tope = i;
                                        break;
                                    }

                                }
                                if (!encontrado)
                                {
                                    Console.WriteLine("\nEL ELEMENTO {0} NO EXISTE DENTRO DE LA PILA", eliminar);
                                }
                                else
                                {
                                    for (int i = 0; i < max; i++)
                                    
                                        if (i == tope || i > tope)
                                        
                                            pila[i] = null;
                                        
                                    
                                    Console.WriteLine("Elemento eliminado");
                                }
                            }
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            for (int i = 0; i < max; i++)
                            

                                Console.Write("{0} ", pila[i]);
                            
                            Console.ReadLine();
                            break;
                        default:
                            Console.Write("--Opcion no valida--");
                            break;
                    }
                } while (opcion2 != 4);
            }
            void Colas()
            {
                int frente = 0, final = 0, Max, opcion = 0;
                Console.WriteLine("Ingrese el tamaño de la cola: ");
                Max = int.Parse(Console.ReadLine());
                string[] cola = new string[Max];
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n1.- Insertar elemnto\n2.- Eliminar elemento\n3.- Mostrar Cola\n4.- Salir\nOpcion: ");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            if (final == Max)
                            {
                                Console.WriteLine("\nNO SE PUEDEN AGREGAR MÁS ELEMENTOS LA COLA ESTA LLENA");
                                Console.ReadLine();
                            }
                            else
                            {

                                Console.WriteLine("Inserte el elemento: ");
                                cola[final] = Console.ReadLine();
                                final++;
                                Console.WriteLine("\nEL ELEMENTO FUE AGREGADO");
                            }
                            Console.ReadLine();
                            break;
                        case 2:
                            string eliminar;
                            bool encontrado = false;
                            if (frente == Max)
                            {
                                Console.Write("NO SE PUEDEN ELIMINAR ELEMENTOS COLA VACIA ");
                            }
                            else
                            {
                                Console.Write("Inserte el elemento que desea eliminar: ");
                                eliminar = Console.ReadLine();
                                for (int i = 0; i < Max; i++)
                                {
                                    if (cola[i] == eliminar)
                                    {
                                        encontrado = true;
                                        frente = i + 1;
                                        break;
                                    }
                                }
                                if (!encontrado)
                                {
                                    Console.WriteLine("\nEL ELEMENTO {0} NO EXISTE DENTRO DE LA COLA", eliminar);
                                }
                                else
                                {
                                    for (int i = 0; i < frente; i++)
                                    {
                                        cola[i] = null;

                                    }
                                    Console.WriteLine("Elemento eliminado");
                                }
                            }
                            Console.ReadLine();
                            break;
                        case 3:
                            for (int i = 0; i < Max; i++)
                            {
                                Console.Write("{0} ", cola[i]);
                            }
                            Console.ReadLine();
                            break;
                        case 4:
                            break;
                    }
                } while (opcion != 4);
            }

        }

        
    }
    
}
