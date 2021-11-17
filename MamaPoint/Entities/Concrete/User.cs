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
    public class User : IEntities
    {
        [HiddenInput(DisplayValue = false)]
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
        public ICollection<Request> Requests { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
