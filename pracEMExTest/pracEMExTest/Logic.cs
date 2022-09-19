using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracEMExTest
{
    public class Logic
    {
        public static void ingenio(int pos)
        {
            try
            {
                int[] arreglo = { 1, 2, 3, 4, 5, 6 };
                

                for (int i = 0; i <= arreglo.Length; i++)
                {
                    if (i == pos)
                    {
                        Console.WriteLine("El valor en la posición {0} es {1} ", i, arreglo[i]);
                    }
                    else
                    {
                        if (i < pos)
                        {
                            Console.WriteLine("El valor en la posición {0} es {1} ", pos, arreglo[pos]);
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException iex)
            {
                Console.WriteLine("La posición ingresada se encuentra fuera del tamaño del arreglo");
                Console.WriteLine(" ");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finalizamos");
            }
        }

        public static void throwExcepcionPersonaliza()
        {
            throw new Personalizada();
        }
    }
}
