using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaEMEx
{
    public class Division
    {
        public static void Div()
        {
            decimal resultado = 0;
            try
			{
				Console.WriteLine("INGRESAR NÚMERO DIVIDENDO:");
				decimal numero1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("INGRESAR NÚMERO DIVISOR:");
				decimal numero2 = Convert.ToInt32(Console.ReadLine());
                
				resultado = numero1/numero2;
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
            catch (Exception e) {
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
            
        }
    }
}
