using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Entities.Concrete
{
    public class Admin : IEntities
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
 