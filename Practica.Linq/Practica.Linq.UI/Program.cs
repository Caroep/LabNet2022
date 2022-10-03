using Practica.Linq.Logic;
using Practica.Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.menu();

            Console.ReadKey();
        }
    }
}

           