using System.ComponentModel.DataAnnotations;
using Backend.Contants;

namespace Backend.Models.Character
{
    public class CharacterResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Birthday { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Image { get; set; }
    }
}