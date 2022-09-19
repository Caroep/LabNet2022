using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace pracEMExTest
{
    public class ExceptionEnCero
    {
        public static string DivisionEnCero(int numero)
        {
            string message =" ";
            try
            {
                int total = numero / 0;
            }
            catch (DivideByZeroException dex)
            {
                message = dex.Message;
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            finally
            {
                Console.WriteLine("Finalizó el programa. {0}", message);
                Console.WriteLine(" ");
            }
            return message;
        }
    }
}
