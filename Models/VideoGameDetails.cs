using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NETD3202Lab5_1.Models
{
    public class VideoGameDetails
    {
        [Key]
        public int videoGameID { get; set; }

        public VideoGame VideoGame { get; set; }

        public string videoGameDescription { get; set; }
    }
}
