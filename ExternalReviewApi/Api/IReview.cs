using ExternalReviewApi.Models;

namespace ExternalReviewApi
{
    public interface IReview
    {
        string Path { get; set; }

        Task GetReviews();
    }
}