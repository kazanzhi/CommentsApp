namespace backend.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public Comment Parent { get; set; }
        public ICollection<Comment> Replies { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public int? FileSize { get; set; }
    }
}
