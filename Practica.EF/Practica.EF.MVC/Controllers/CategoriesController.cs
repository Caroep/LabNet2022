using Practica.EF.Entities;
using Practica.EF.Logic;
using Practica.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Practica.EF.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic logic = new CategoriesLogic();

        // GET: Categories
        public ActionResult Index()
        {
            List<Categories> categories = logic.GetAll();

            List<CategoriesView> categoriesView = categories.Select(c => new CategoriesView
            {
                Id = c.CategoryID,
                Name = c.CategoryName,
                Description = c.Description
            }).ToList();

            return View(categoriesView);
        }

        public ActionResult Insert()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesView categoriesView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Categories categoriesEntity = new Categories
                    {
                        CategoryName = categoriesView.Name,
                        Description = categoriesView.Description
                    };

                    logic.Add(categoriesEntity);
                    return RedirectToAction("Index");
                }

                return View(categoriesView);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("Error", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("Error", "Error");
            }
        }

        //public ActionResult Update(int id)
        //{
        //    Categories categories = new Categories();
        //    if (id != 0)
        //    {
        //      categories = logic.Search(id);
        //    }
        //    CategoriesView categoriesView = new CategoriesView
        //    {
        //        Id = categories.CategoryID,
        //        Name = categories.CategoryName,
        //        Description = categories.Description
        //    };

        //    return View(categoriesView);
        //}

        //[HttpPost]
        //public ActionResult Update(CategoriesView categoriesView)
        //{
        //    Categories categoriesEntity = new Categories
        //    {
        //        CategoryID = categoriesView.Id,
        //        CategoryName = categoriesView.Name,
        //        Description = categoriesView.Description,
        //    };

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            logic.Update(categoriesEntity);
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            return RedirectToAction("Error", "Error");

        //        }
        //    }
        //    return RedirectToAction("Index");
        //}


        public ActionResult Hibrido()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Hibrido(CategoriesView categoriesView)
        {
            Categories categoriesEntity = new Categories
            {
                CategoryID = categoriesView.Id,
                CategoryName = categoriesView.Name,
                Description = categoriesView.Description,
            };

            if (!ModelState.IsValid)
            {
                return View(categoriesView);
            }

            if (categoriesEntity.CategoryID == 0)
            {
                logic.Add(categoriesEntity);
            }
            else
            {
                try
                {
                    logic.Update(categoriesEntity);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return RedirectToAction("Error", "Error");
                }
            }
            return RedirectToAction("Index");
        }

    }

}
