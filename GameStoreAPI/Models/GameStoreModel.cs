using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStoreAPI.Models;

namespace GameStoreAPI.Models
{
    public class GameStoreModel : DbContext
    {
        public GameStoreModel(DbContextOptions<GameStoreModel> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
    }
}
