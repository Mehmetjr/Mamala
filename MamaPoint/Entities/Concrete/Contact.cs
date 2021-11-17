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
    public class Contact : IEntities
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int contactId { get; set; }
        [StringLength(20)]
        public string subject { get; set; }
        [StringLength(150)]
        public string message { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int userId { get; set; }
        public virtual User User { get; set; }

        
    }
}
