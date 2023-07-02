namespace HealthyFoodWebApplication.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Author { get; set; } = null!;
        public string PublishingDate { get; set; } = null!;
    }
}
