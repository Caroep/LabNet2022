using Practica.EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Practica.EF.WebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        CategoriesService categoriesService = new CategoriesService();

        // GET: api/Categories

        public IHttpActionResult GetCategories()
        {
            try
            {
                var listCategories = categoriesService.GetCategories();
                return Ok(listCategories);
            }
            catch (Exception ex)
            {

                return Content(HttpStatusCode.BadRequest, ex);
            }
        }


       
    }
}