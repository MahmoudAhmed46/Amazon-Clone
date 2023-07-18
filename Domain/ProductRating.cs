using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Domain
{
    public class ProductRating
    {
        public int id { get; set; }

        [ForeignKey("rating")]
        public int rateId { get; set; }
        public Rating Rating { get; set; }
        [ForeignKey("product")]
        public int productId { get; set; }
        public Product Product { get; set; }
    }
}
