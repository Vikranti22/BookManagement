using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    //book model
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        [Range(1, 5000)]
        public int Pages { get; set; }
    }
}
