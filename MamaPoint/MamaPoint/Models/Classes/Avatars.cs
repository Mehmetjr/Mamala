using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamaPoint.Models.Classes
{
    public class Avatars
    {
        [Key]
        public int avatarId { get; set; }
        [StringLength(50)]
        public string avatarImage { get; set; }
    }
}