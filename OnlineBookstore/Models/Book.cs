using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Models
{
    //this establishes the model for the DB. All of the fields are required except for the author
    //middle name (because not all authors have that)
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirst { get; set; }

        public string AuthorMiddle { get; set; }

        [Required]
        public string AuthorLast { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{3}-[0-9]{10}$")]
        public string ISBN { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Price { get; set; }
        [Required]
        public int Page { get; set; }

    }
}