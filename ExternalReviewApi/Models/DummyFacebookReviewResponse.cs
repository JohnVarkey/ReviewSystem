using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalReviewApi.Models
{
    public class DummyFacebookReview : ReviewBase
    {
        public override string Source { get; } = "Facebook";
        public string Text { get; set; }
        public string Reviewer { get; set; }
        public string Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Rating { get; set; }
        public string Recommends_Rating { get; set; }

    }
}
