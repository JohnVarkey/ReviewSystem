using ExternalReviewApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalReviewApi.ApiParser
{
    internal interface IApiParser
    {
        public string getName();
        public string getReviewId();
        public string getSource();
        public string getDescription();
        public DateTime getReviewTimestamp();
        float GetRating();
        string GetRecomendRating();
    }
}
