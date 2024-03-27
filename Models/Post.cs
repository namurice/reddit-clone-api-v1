using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reddit.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public int  Upvotes { get; set; } = 0;
        public int Downvotes { get; set; } = 0;
        [ForeignKey("Community")]
        public int CommunityId { get; set; }
        public virtual Community Community { get; set; }
        
    }
}
