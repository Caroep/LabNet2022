using Practica.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic
{
    public class CategoriesLogic:BaseLogic,IABMLogic<Categories>
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public int Tamanio()
        {
            return context.Categories.ToList().Count();
        }

        public void Add(Categories newCategorie)
        {
            context.Categories.Add(newCategorie);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var categorieAEliminar = context.Categories.Find(id);
            if(categorieAEliminar != null)
            {
                context.Categories.Remove(categorieAEliminar);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("ERROR: EL ID SELECCIONADO ES NULO");
                Console.WriteLine(" ");
            }
        }
        
        public void Update(Categories categorie)
        {
            var categorieUpdate = context.Categories.Find(categorie.CategoryID);
            if (categorieUpdate != null)
            {
                categorieUpdate.CategoryName = categorie.CategoryName;
                categorieUpdate.Description = categorie.Description;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("ERROR: EL ID SELECCIONADO ES NULO");
                Console.WriteLine(" ");
            }
        }
    }
}
