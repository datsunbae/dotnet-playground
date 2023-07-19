using System.ComponentModel.DataAnnotations;
using Backend.Contants;

namespace Backend.Data
{
    public class Character
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Birthday is required")]
        public string BirthDay { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Height must be a positive value")]
        public int Height { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Width must be a positive value")]
        public int Weight { get; set; }
        public string Image { get; set; }
    }

}