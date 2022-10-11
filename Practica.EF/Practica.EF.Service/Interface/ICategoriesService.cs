using Practica.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Service
{
    public interface ICategoriesService
    {
        List<Categories> GetCategories();
        Categories GetCategoryToId(int id);
        void AddCategory(Categories category);
        void DeleteCategory(int id);
        void UpdateCategory(Categories category);

    }
}
