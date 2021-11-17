using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamaPoint.Models.Classes
{
    public class FoodContainers
    {
        [Key]
        public int containerId { get; set; }
        public int pin { get; set; }
        public int time { get; set; }
        [StringLength(15)]
        public string color { get; set; }
        [StringLength(20)]
        public string Lat { get; set; }
        [StringLength(20)]
        public string Long { get; set; }
        [StringLength(100)]
        public string explain { get; set; }

    }
}