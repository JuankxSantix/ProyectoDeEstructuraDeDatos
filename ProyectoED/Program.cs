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
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("\t\t  MENU");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("|   1.- Unidad I ''Recursividad''          |");
                Console.WriteLine("|   2.- Unidad II ''Estructuras lineales'' |");
                Console.WriteLine("|   3.- Salir                              |");
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
                        UnidadII();
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
            void UnidadII()
            {
                string Respuesta = "";
                do
                {
                    Console.Clear();

                    int res;
                    Console.WriteLine("1.- Pilas");
                    Console.WriteLine("2.- Colas");
                    Console.WriteLine("3.- Lineas");
                    Console.WriteLine("4.- Regresar");
                    res = int.Parse(Console.ReadLine());

                    switch (res)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
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

        }

        
    }
    
}
