using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracEMExTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Ingrese una opcion");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    funcion1();
                    break;
                case 2:
                    funcion2();
                    break;
                case 3:
                    funcion3();
                    break;
                case 4:
                    funcion4();
                    break;
            }
            

            Console.ReadKey();

        }
        public static void funcion1()
        {
            Console.WriteLine("ingrese un valor");
            int valor = Convert.ToInt32(Console.ReadLine());
            ExceptionEnCero.DivisionEnCero(valor);
        }

        public static void funcion2()
        {
            Console.WriteLine("ingrese un valor1");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese un valor2");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Division.Div(valor1,valor2);
        }

        public static void funcion3()
        {
            int pos = 0;
            do
            {
                Console.WriteLine("INGRESE LA POSICIÓN DEL VALOR QUE DESEA BUSCAR:");
                pos = Convert.ToInt16(Console.ReadLine());
            } while (pos < 0);
            Logic.ingenio(pos);
        }

        public static void funcion4()
        {
            try                  
            {
                Logic.throwExcepcionPersonaliza();
            }
            catch (Personalizada e)
            {
                Console.WriteLine($"{e.Message}fue capturada.");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(" ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Programa terminado");
            }
        }


    }
    
}
