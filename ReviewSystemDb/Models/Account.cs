using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsCollection
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string PhoneNmber { get; set; }
        public virtual IEnumerable<Location> Locations { get; set; }
    }
}
