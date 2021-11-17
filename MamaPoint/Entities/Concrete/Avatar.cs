using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Avatar : IEntities
    {
        [Key]
        public int avatarId { get; set; }
        [StringLength(50)]
        public string avatarImage { get; set; }
    }
}
