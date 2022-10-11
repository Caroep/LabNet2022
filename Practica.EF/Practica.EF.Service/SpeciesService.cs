using Practica.EF.Entities.DTOs;
using Practica.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Service
{
    public class SpeciesService
    {
        public async Task<List<SpeciesDTO>> ListSpecies()
        {
            SpeciesLogic speciesLogic = new SpeciesLogic();
            try
            {
                return await speciesLogic.ListSpecies();
            }
            catch (Exception)
            {

                throw new Exception("Error");
            }
        }   
    }
}
