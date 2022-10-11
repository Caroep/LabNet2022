using Practica.EF.Entities;
using Practica.EF.Service;
using Practica.EF.WebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.UI.WebControls;
using System.Web.WebSockets;

namespace Practica.EF.WebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        CategoriesService categoriesService = new CategoriesService();

        // GET: api/Categories

        public IHttpActionResult GetCategories()
        {
            List<Categories> categories = categoriesService.GetCategories();


            try
            {
                List<Categories> listCategories = categories.Select(c => new Categories
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                }).ToList();

                return Ok(listCategories);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

        // GET: api/Categories/{id}

        public IHttpActionResult GetCategorie(int id)
        {
            Categories categories = categoriesService.GetCategoryToId(id);
            try
            {
                if (categories == null)
                {
                    return Conflict();
                }
                else
                {
                    Categories category = new Categories
                    {
                        CategoryID = id,
                        CategoryName = categories.CategoryName,
                        Description = categories.Description
                    };

                    return Ok(category);
                }
            }
            catch (Exception ex)
            {

                return Content(HttpStatusCode.NotFound, ex);
            }

        }

        // POST: api/Categories
        public IHttpActionResult Add([FromBody] CategoriesRequest category)
        {
            try
            {
                Categories cat = new Categories()
                {
                    CategoryName = category.categoryName,
                    Description = category.Description
                };
                categoriesService.AddCategory(cat);
                return Content(HttpStatusCode.Created, cat);
            }
            catch (Exception ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // DELETE : api/Categories/{id}

        public IHttpActionResult Delete(int id)
        {
            try
            {
                categoriesService.DeleteCategory(id);
                return Ok(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        //PUT : api/Categories/
        [HttpPut]
        public IHttpActionResult Update([FromBody] CategoriesRequest category)
        {
            try
            {
                Categories cat = new Categories()
                {
                    CategoryID = category.idCategory,
                    CategoryName = category.categoryName,
                    Description = category.Description
                };
                categoriesService.UpdateCategory(cat);
                return Content(HttpStatusCode.OK, cat);
            }
            catch (Exception ex)
            {

                return Content(HttpStatusCode.BadRequest, ex.Message);
            }

        }
    }
}