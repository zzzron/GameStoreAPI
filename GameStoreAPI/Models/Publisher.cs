using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreAPI.Models
{
    public class Publisher
    {
        public Publisher()
        {
            games = new HashSet<Game>();
        }

        //public virtual ICollection<Game> games { get; set; }

        [Key]
        public int id { get; set; }
          
        [Required]
        public string name { get; set; }
        public string hq_country { get; set; }
        public int founding_year { get; set; }
        

    }
}
