namespace ExternalReviewApi.Models
{
    public abstract class ReviewBase : IReviewResponse
    {
        public abstract string Source { get; }
    }
}