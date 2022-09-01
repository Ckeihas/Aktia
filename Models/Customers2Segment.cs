using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AktiaHaastattelu.Models
{
    public class Customers2Segment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SegmentId { get; set; }

        [Required]
        public Customers Customers { get; set; }
    }
}
