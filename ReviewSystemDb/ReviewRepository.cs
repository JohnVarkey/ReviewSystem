
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewsCollection;

namespace ReviewsCollection
{
    public class ReviewRepository : IReviewRepository
    {
        private ReviewDbContext _dbContext { get; set; }
        public ReviewRepository(ReviewDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Review> GetReviews(int AccountId)
        {
            var locations = _dbContext.Locations.Where(x => x.AccountId == AccountId).ToList();
            List<Review> reviews = new List<Review>();
            foreach (var location in locations)
            {
                var LocReviews = _dbContext.Reviews.Where(r => r.LocationId == location.LocationID).ToList();
                foreach (var review in LocReviews)
                {
                    reviews.Add(review);
                }
            }
            return reviews;
        }

        public IEnumerable<Review> GetReviewsLoc(IEnumerable<int> LocationIds, int AccountId)
        {
            List<Review> reviews = new List<Review>();
            foreach (var location in LocationIds)
            {
                var LocReviews = (_dbContext.Reviews.Where(r => r.LocationId == location).ToList().Take(15));
                foreach (var locreview in LocReviews)
                {
                    reviews.Add(locreview);
                }
            }
            return reviews;
        }

        public void AddReview(Review review)
        {
            _dbContext.Reviews.Add(review);
            _dbContext.SaveChanges();
        }
    }
}
