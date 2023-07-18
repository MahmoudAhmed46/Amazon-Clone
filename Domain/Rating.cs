using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Domain
{
    public enum Star
    {
        oneStar=1,
        twoStar,
        threeStar,
        fourStar,
        fiveStar,
    }
    public class Rating
    {
        public int id { get; set; }
        public Star Star { get; set; }
        public string Review { get; set; }
        public virtual ICollection<ProductRating> ProductRatings { get; set; } =
         new HashSet<ProductRating>();
    }
}
