using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace step247.Models
{
    public class QuoteModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string HadDUI { get; set; }
        public int NumberOfTickets { get; set; }
        public string Coverage { get; set; }
        public decimal Quote1 { get; set; }
    }
}