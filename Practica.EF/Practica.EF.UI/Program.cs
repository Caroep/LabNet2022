using Practica.EF.Entities;
using Practica.EF.Logic;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Practica.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.mostrarOpciones();
        }
    }
}

        
