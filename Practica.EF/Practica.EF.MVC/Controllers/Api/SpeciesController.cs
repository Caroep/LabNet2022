using Practica.EF.Entities.DTOs;
using Practica.EF.Logic;
using Practica.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Practica.EF.MVC.Controllers.Api
{
    public class SpeciesController : Controller
    {
        SpeciesLogic speciesLogic = new SpeciesLogic(); 
        // GET: api/Species
        public async Task<ActionResult> Index()
        {
            var specie = await speciesLogic.ListSpecies();
            var list = specie.Select(s => new SpeciesView
            {
                Classification = s.Classification,
                Language = s.Language,
                Homeworld = s.Homeworld,
                Designation = s.Designation,
                Name = s.Name   
               
            }).ToList();

            return View(list);
        }
    }
}