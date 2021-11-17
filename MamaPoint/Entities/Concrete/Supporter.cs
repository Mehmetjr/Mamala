using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entities.Concrete
{
    public class Supporter : IEntities
    {
        [Key]
        public int supporterId { get; set; }
        [StringLength(50)]
        [DisplayName("Upload File")]
        public string SupporterImage { get; set; }
        [StringLength(50)]
        public string supporterName { get; set; }

    }
}
