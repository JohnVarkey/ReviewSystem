using ReviewsCollection;
using ExternalReviewApi.Api;
using ExternalReviewApi.ApiParser;
using ExternalReviewApi.Models;

namespace ExternalReviewApi
{
    public class program
    {
        private static readonly ReviewDbContext _dbcontext = new ReviewDbContext();
        private static readonly IReviewRepository reviewRepository = new ReviewRepository(_dbcontext);

        public static async Task Main()
        {
            //Google Reviews
            GetGoogleReviews();
            //Facebook Reviews
            GetFacebookReviews();
            _dbcontext.SaveChanges();

        }


        public static async void GetFacebookReviews() {
            DummyFacebookApi facebookReviewsApi = new DummyFacebookApi();
            var facebookReviews = await facebookReviewsApi.GetReviews();
            Parallel.ForEach(facebookReviews, reviewItem =>
            {
                IApiParser parser = new FacebookParser(reviewItem);
                reviewRepository.AddReview(
                new Review
                {
                    ExternalReviewId = parser.getReviewId(),
                    Name = parser.getName(),
                    EntryTimestamp = DateTime.UtcNow,
                    ReviewTimestamp = parser.getReviewTimestamp(),
                    LocationId = 1,//From batch job,
                    Description = parser.getDescription(),
                    Rating = parser.GetRating(),
                    Source = parser.getSource(),//From batch job
                    RecommendRating = parser.GetRecomendRating()
                });

            });
        }

        public static  async void GetGoogleReviews() {
            DummyGoogleApi googleReviewsApi = new DummyGoogleApi();
            var googleReviews = await googleReviewsApi.GetReviews();
            Parallel.ForEach(googleReviews, reviewItem =>
            {
                IApiParser parser = new GoogleParser(reviewItem);
                reviewRepository.AddReview(
                new Review
                {
                    ExternalReviewId = parser.getReviewId(),
                    Name = parser.getName(),
                    EntryTimestamp = DateTime.UtcNow,
                    ReviewTimestamp = parser.getReviewTimestamp(),
                    LocationId = 1,//From batch job,
                    Description = parser.getDescription(),
                    Rating = parser.GetRating(),
                    Source = parser.getSource(),//From batch job
                    RecommendRating = parser.GetRecomendRating()
                });

            });
        }
    }
}
