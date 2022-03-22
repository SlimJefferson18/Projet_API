using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_API.Models
{
    public class Population
    {
        public int Id { get; set; }
        public int NbrePopulation { get; set; }
        public int Annee { get; set; }
        public int PaysId { get; set; }
    }
}
