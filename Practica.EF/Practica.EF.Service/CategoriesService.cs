using Practica.EF.Entities;
using Practica.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Service
{
    public class CategoriesService : ICategoriesService
    {
		CategoriesLogic categoriesLogic = new CategoriesLogic();
        public List<Categories> GetCategories()
        {
			try
			{
				return categoriesLogic.GetAll();
			}
			catch (Exception)
			{

				throw new Exception("No se pudo realizar la operación solicitada");
			}
        }
    }
}
