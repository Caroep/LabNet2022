using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaEMEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exceptio.ThrowException(); //a     EJERCICIO 1

            // Division.Div();       // EJERCICIO 2

            // Logic.ingenio();      // EJERCICIO 3

            try                      //EJERCICIO 4
            {
                Logic.throwExcepcionPersonaliza();  
            }
            catch (Personalizada e)
            {
                Console.WriteLine($"{e.Message}fue capturada.");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(" ");
            }
            catch(Exception e)
            { 
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("Programa terminado");
            }
            
            Console.ReadKey();
        }
    }
}
