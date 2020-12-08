using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NETD3202Lab5_1.Models
{
    public class VideoGameContext : DbContext
    {


        //Video game context class constructor created. 
        public VideoGameContext(DbContextOptions<VideoGameContext> options) : base(options)
        {

        }
        //Sets the database for the VideoGame class. Named VideoGames.
        public DbSet<VideoGame> VideoGames { get; set; }

        //Sets another database/table for the VideoGameDetails class. Named AdditionalGameDetails.
        public DbSet<VideoGameDetails> AdditionalGameDetails { get; set; }
    }
}

