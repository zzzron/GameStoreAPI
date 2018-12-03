using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreAPI.Models
{
    public class Game
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string title { get; set; }
        public string publisher { get; set; }        
        public int? release_year { get; set; }
        public decimal? price { get; set; }
        //public virtual Publisher publisher1 { get; set; }
    }
}
