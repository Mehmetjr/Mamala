using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamaPoint.Models.Classes
{
    public class Request
    {
        [Key]
        public int requestId { get; set; }
        public int userId { get; set; }
        [StringLength(20)]
        public string userLatitude { get; set; }
        [StringLength(20)]
        public string userLongtitude { get; set; }
        [StringLength(15)]
        public string request { get; set; }
    }
}