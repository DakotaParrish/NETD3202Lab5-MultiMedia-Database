using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NETD3202Lab5_1.Models
{
    public class VideoGame
    {
        //
        public int videoGameID { get; set; }

        //
        public string videoGameName { get; set; }

        //
        public string videoGameRating { get; set; }

        //
        public string videoGameGenre { get; set; }

        //
        public int videoGameRelease { get; set; }

        //
        public string videoGamePlatform { get; set; }

    }
}
