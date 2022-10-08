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

        public void Add(Categories newCategorie)
        {
            context.Categories.Add(newCategorie);
            context.SaveChanges();
        }

        public Boolean Delete(int id)
        {
            var categorieAEliminar = context.Categories.Find(id);
            if(categorieAEliminar != null)
            {
                context.Categories.Remove(categorieAEliminar);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
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
        }

        public Categories Search(int id)
        {
            var categorie = context.Categories.Find(id);
            return categorie;
        }

      
    }
}
