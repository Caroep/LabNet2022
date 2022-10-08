using Practica.EF.Entities;
using Practica.EF.Logic;
using System;

namespace Practica.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.mostrarOpciones();

            CategoriesLogic categories = new CategoriesLogic();
            Console.WriteLine(categories.Search(13));

            Console.ReadLine();
        }
    }
}


