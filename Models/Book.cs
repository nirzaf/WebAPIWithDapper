using System.ComponentModel.DataAnnotations;

namespace WebAPIWithDapper.Models
{
    public class Book
    {
        [Key] public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
    }
}