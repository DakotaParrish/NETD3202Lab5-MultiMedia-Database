using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NETD3202Lab5_1.Models
{
    public class VideoGameContext : DbContext
    {


        //
        public VideoGameContext(DbContextOptions<VideoGameContext> options) : base(options)
        {

        }
        //
        public DbSet<VideoGame> VideoGames { get; set; }

        //
        public DbSet<VideoGameDetails> AdditionalGameDetails { get; set; }
    }
}

