using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamaPoint.Models.Classes
{
    public class Supporter
    {
        [Key]
        public int supporterId { get; set; }
        [StringLength(50)]
        public string SupporterImage { get; set; }
        [StringLength(50)]
        public string supporterName { get; set; }

    }
}