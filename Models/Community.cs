namespace Reddit.Models
{
    public class Community
    {
        public int CommunityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Post> Posts { get; set; }
        public IList<User> Users { get; set; }
    }
}