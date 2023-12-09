using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Book Title")]
        [StringLength(maximumLength:20, MinimumLength = 2, ErrorMessage ="The title length should be between 2 and 20.")]
        public string Title { get; set; }
        public string Genre { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(1, Double.MaxValue)]
        public decimal Price { get; set; }
        [Display(Name ="Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
    }
}
