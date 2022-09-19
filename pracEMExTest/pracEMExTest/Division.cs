using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracEMExTest
{
    public class Division
    {
        public static decimal Div(decimal numero1,decimal numero2)
        {
            decimal resultado = 0;
            try
            {
                if(numero2 == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                     resultado = numero1 / numero2;
                }
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero");
                Console.WriteLine(" ");

            }
            catch (FormatException e)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (resultado != 0)
                {
                    Console.WriteLine("La división es {0}", ((float)resultado));
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("No es posible realizar la operación");
                    Console.WriteLine(" ");
                }

            }
            return resultado;

        }
    }
}
