/******************************************************************************************************************************
 * Student Name: Dakota Parrish
 * Project Name: NETD3202 Lab 5
 * Course Code: NETD3202
 * Date: December 7, 2020
 * Purpose: The purpose of this class is to be the context class for the VideoGame class and VideoGameDetails classes. It sets
 * the database for the VideoGame and VideoGameDetails tables as well as creates a constructor for the two classes.
 * ***************************************************************************************************************************/
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

