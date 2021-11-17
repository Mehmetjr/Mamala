using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace MamaPoint.Models.Classes
{
    public class Admins
    {
        [Key]
        public int adminId { get; set; }
        [StringLength(30)]
        public string adminMail { get; set; }
        [StringLength(30)]
        public string adminName { get; set; }
        [StringLength(20)]
        public string adminSurname { get; set; }
        [StringLength(20)]
        public string adminPassword { get; set; }
    }
}