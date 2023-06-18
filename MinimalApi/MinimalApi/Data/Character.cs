namespace MinimalApi.Data
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Height { get; set; }
        public string Power { get; set; } = string.Empty;
        public int Blood { get; set; }
        public DateTime Birthday { get; set; }
    }
}
