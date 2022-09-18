using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsCollection
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string PhoneNumber { get; set; }
        public string email { get; set; }
        public int AccountId { get; set; }
        public string Address { get; set; }
        public virtual Account Account { get; set; }
    }
}

