using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaEMEx
{
    public class Exceptio
    {
        public static void ThrowException()
        {
            try
            {
                int numero1 = 0;
                int numero2 = 0;
                    
                Console.WriteLine("INGRESAR UN NÚMERO: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                int total = numero2 / numero1;   
            }
            catch(DivideByZeroException dex)
            {
                Console.WriteLine(dex.Message);
                Console.WriteLine(" ");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("No es posible realizar la operación");
                Console.WriteLine(" ");
            }
        }
    }
}
