using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FoodContainer : IEntities
    {
        [Key]
        public int containerId { get; set; }
        public int pin { get; set; }
        [UIHint("UTCTime")]
        [DataType(DataType.DateTime)]
        public DateTime time { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        [StringLength(100)]
        public string explain { get; set; }

    }
}
