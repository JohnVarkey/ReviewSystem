namespace ReviewsCollection
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetReviewsLoc(IEnumerable<int> LocationIds, int AccountId);
        IEnumerable<Review> GetReviews(int AccountId);
        void AddReview(Review review);
    }
}
