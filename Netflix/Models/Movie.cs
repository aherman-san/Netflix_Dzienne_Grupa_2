namespace Netflix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int LenghtInMinutes { get; set; }
        public int ReleaseYear { get; set; }
        public int Rating { get; set; }
        public List<string> Cast { get; set; } = new List<string>();
        public string? PosterUrl { get; set; }
        public string? TrailerUrl { get; set; }
    }
}
