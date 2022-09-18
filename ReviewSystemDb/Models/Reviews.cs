using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsCollection
{
    public class Review
    {
        public DateTime EntryTimestamp { get; set; } = DateTime.UtcNow;
        [Key]
        public int Id { get; set; }
        [Required]
        public string ExternalReviewId { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public DateTime ReviewTimestamp { get; set; }
        public int LocationId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Source { get; set; }
        [Required]
        public float Rating{ get; set; }
        public string? RecommendRating  { get; set; }
        public virtual Location Location { get; set; }
    }
}

