using ExternalReviewApi.Models;

namespace ExternalReviewApi.ApiParser
{
    class FacebookParser : IApiParser
    {
        public DummyFacebookReview _Review;

        public FacebookParser(DummyFacebookReview Review)
        {
            _Review = Review;
        }

        public string getDescription()
        {
            return _Review.Text;
        }

        public string getName()
        {
            return _Review.Reviewer;
        }

        public float GetRating()
        {
            return 0;
        }

        public string GetRecomendRating()
        {
           return _Review.Recommends_Rating;
        }

        public string getReviewId()
        {
            return _Review.Id;
        }

        public DateTime getReviewTimestamp()
        {

            return _Review.DateTime;
        }

        public string getSource()
        {
            return _Review.Source;
        }
    }
}
