namespace Ebook.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
