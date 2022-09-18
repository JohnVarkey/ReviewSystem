using ReviewsCollection;
using ExternalReviewApi.Api;
using ExternalReviewApi.ApiParser;

namespace ExternalReviewApi
{
    public class program
    {
        public static async Task Main()
        {
            IReviewRepository reviewRepository = new ReviewRepository(new ReviewDbContext());
            
            //Google Reviews
            DummyGoogleApi googleReviewsApi = new DummyGoogleApi();
            var googleReviews = await googleReviewsApi.GetReviews();
            foreach (var reviewItem in googleReviews)
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

            }

            //Facebook Reviews
            DummyFacebookApi facebookReviewsApi = new DummyFacebookApi();
            var facebookReviews = await facebookReviewsApi.GetReviews();
            foreach (var reviewItem in facebookReviews)
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

            }
        }
    }
}
