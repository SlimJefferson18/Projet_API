using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_API.Models
{
    public class Pays
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public ICollection <Population> ListePopulation { get; set; }

        public Pays() 
        {
            ListePopulation = new List<Population>();
        }
    }
}
