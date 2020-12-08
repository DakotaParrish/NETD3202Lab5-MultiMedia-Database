/******************************************************************************************************************************
 * Student Name: Dakota Parrish
 * Project Name: NETD3202 Lab 5
 * Course Code: NETD3202
 * Date: December 7, 2020
 * Purpose: The purpose of this class is to be the second table in my database. This class includes the foreign key for the game ID.
 * This class allows the user to enter a game description for a specific game added to the database.
 * ***************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NETD3202Lab5_1.Models
{
    public class VideoGameDetails
    {
        //Primary key videoGameID created as an integer.
        [Key]
        public int videoGameID { get; set; }

        //Foreign key VideoGame referencing the videoGameID from the VideoGame class.
        public VideoGame VideoGame { get; set; }

        //videoGameDescription variable used to hold the video game's description.
        public string videoGameDescription { get; set; }
    }
}
