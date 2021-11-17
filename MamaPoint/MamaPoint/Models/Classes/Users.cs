using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamaPoint.Models.Classes
{
    public class Users
    {
        [Key]
        public int userId { get; set; }
        [StringLength(20)]
        public string userMail { get; set; }
        [StringLength(20)]
        public string password { get; set; }
        [StringLength(30)]
        public string userName { get; set; }
        [StringLength(20)]
        public string userSurname { get; set; }
        public int point { get; set; }
    }
}