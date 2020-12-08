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
