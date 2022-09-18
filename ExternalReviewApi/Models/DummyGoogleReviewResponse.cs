using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalReviewApi.Models
{
    public enum Rating
    {
        STAR_RATING_UNSPECIFIED,
        ONE,
        TWO,
        THREE,
        FOUR,
        FIVE
    }
    public class DummyGoogleReview : ReviewBase
    {
        public string ReviewId { get; set; }
        public override string Source { get; } = "Google";
        public DateTime CreateTime { get; set; }
        public User user { get; set; }
        public string Rating { get; set; }
        public string Comment { get; set; }
    }


    public class User
    {
        public string? DisplayName { get; set; }
        public bool IsAnonymous { get; set; }
    }

}
