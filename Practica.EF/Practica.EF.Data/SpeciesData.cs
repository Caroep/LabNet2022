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
            var speciesList = species.results.Select(s => new SpeciesDTO
            {
                Classification = s.Classification,
                Designation = s.Designation,
                Name = s.Name,
                Homeworld = s.Homeworld,
                Language = s.Language
            }).Take(5).ToList();

            return speciesList;
        }
    }
}
