using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamaPoint.Models.Classes.Konum
{
    public class Contacts
    {
        [Key]
        public int contactId { get; set; }
        public int userId { get; set; }
        [StringLength(20)]
        public string subject { get; set; }
        [StringLength(150)]
        public string message { get; set; }
    }
}