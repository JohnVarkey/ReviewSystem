using ExternalReviewApi.Models;


namespace ExternalReviewApi.ApiParser
{

    class GoogleParser : IApiParser
    {
        public DummyGoogleReview _Review;

        public GoogleParser(DummyGoogleReview Review)
        {
            _Review = Review;
        }

        public string getDescription()
        {
            return _Review.Comment;
        }

        public string? getName()
        {
            return _Review.user.DisplayName;
        }

        public float GetRating()
        {
            int rating  = (int)Enum.Parse(typeof(Rating), _Review.Rating);
            return (rating*100)/ Enum.GetNames(typeof(Rating)).Length;
        }

        public string GetRecomendRating()
        {
            return String.Empty;
        }

        public string getReviewId()
        {
            return _Review.ReviewId;
        }

        public DateTime getReviewTimestamp()
        {
            
            return _Review.CreateTime;
        }

        public string getSource()
        {
            return _Review.Source;
        }
    }
}
