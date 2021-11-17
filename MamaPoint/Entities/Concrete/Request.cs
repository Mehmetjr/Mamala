using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Request : IEntities
    {
        [Key]
        public int requestId { get; set; }
        [StringLength(20)]
        public string userLatitude { get; set; }
        [StringLength(20)]
        public string userLongtitude { get; set; }
        [StringLength(15)]
        public string request { get; set; }

        public int userId { get; set; }
        public virtual User User { get; set; }
    }
}
