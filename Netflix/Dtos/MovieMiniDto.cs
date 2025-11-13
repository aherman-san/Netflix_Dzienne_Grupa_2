namespace Netflix.Dtos
{
    public class MovieMiniDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string PosterUrl => $"https://placehold.co/400x600?text={Title}";
    }
}
