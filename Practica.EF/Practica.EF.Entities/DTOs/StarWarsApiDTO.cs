using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Entities.DTOs
{
    public class StarWarsApiDTO
    {
        public int count{ get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<SpeciesDTO> results { get; set; }
    }
}
