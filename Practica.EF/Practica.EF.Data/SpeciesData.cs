using Newtonsoft.Json;
using Practica.EF.Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Practica.EF.Data
{
    public class SpeciesData
    {
        public async Task<List<SpeciesDTO>> ListSpecies()
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("https://swapi.dev/api/species/");
            var species = JsonConvert.DeserializeObject<StarWarsApiDTO>(json);
            var speciesList = species.species.Select(s => new SpeciesDTO
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

            }).Take(5).ToList();

            return speciesList;
        }
    }
}
