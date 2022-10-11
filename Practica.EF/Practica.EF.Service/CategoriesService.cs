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

		public Categories GetCategoryToId(int id)
		{
			try
			{
				return categoriesLogic.Search(id);
			}
			catch
			{
                throw new Exception("No se pudo realizar la operación solicitada");
            }
		}

        public void AddCategory(Categories category)
        {
			try
			{
				categoriesLogic.Add(category);
			}
			catch (Exception)
			{

                throw new Exception("No se pudo realizar la operación solicitada");
            }
        }

		public void DeleteCategory(int id)
		{
            try
            {
                categoriesLogic.Delete(id);
            }
            catch (Exception)
            {

                throw new Exception("No se pudo realizar la operación solicitada");
            }

        }

		public void UpdateCategory(Categories category)
		{
            try
            {
                categoriesLogic.Update(category);
            }
            catch (Exception)
            {

                throw new Exception("No se pudo realizar la operación solicitada");
            }
        }
	}
}
