using Practica.EF.Data;
using Practica.EF.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic
{
    public class SpeciesLogic
    {
        SpeciesData datos = new SpeciesData();
        public async Task<List<SpeciesDTO>> ListSpecies()
        {
            try
            {
                var specie = await datos.ListSpecies();
                var spdto = specie.Select(s => new SpeciesDTO
                {
                    AverageHeight = s.AverageHeight,
                    Classification = s.Classification,
                    AverageLifespan = s.AverageLifespan,
                    HairColors = s.HairColors,
                    EyeColors = s.EyeColors,
                    Designation = s.Designation,
                    Name = s.Name,
                    Created = s.Created,
                    Edited = s.Edited,
                    Films = s.Films,
                    Homeworld = s.Homeworld,
                    Language = s.Language,
                    People = s.People,
                    SkinColors = s.SkinColors,
                    Url = s.Url 
                }).ToList();
                return spdto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
