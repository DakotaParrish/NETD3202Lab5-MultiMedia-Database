using System;
/******************************************************************************************************************************
 * Student Name: Dakota Parrish
 * Project Name: NETD3202 Lab 5
 * Course Code: NETD3202
 * Date: December 7, 2020
 * Purpose: The purpose of this class is to be the primary table for my web application's database. It has a primary key
 * for the video game ID and allows the user to enter information for a game of their choosing. 
 * ***************************************************************************************************************************/
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NETD3202Lab5_1.Models
{
    public class VideoGame
    {
        //videoGameID variable created as an integer to hold the videoGame's ID. Also used as a primary key.
        public int videoGameID { get; set; }

        //videoGameName variable created as a string to hold the video game's title.
        public string videoGameName { get; set; }

        //videoGameRating variable created as a string to hold the video game's rating.
        public string videoGameRating { get; set; }

        //videoGameGenre variable created as a string to hold the video game's genre.
        public string videoGameGenre { get; set; }

        //videoGameRelease variable created as an integer to hold the release year of the video game.
        public int videoGameRelease { get; set; }

        //videoGamePlatform variable created as an integer to hold the platform the video game is on.
        public string videoGamePlatform { get; set; }

    }
}
