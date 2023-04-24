using System.ComponentModel.DataAnnotations;

namespace FrokyBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }
        public string? Rating { get; set; }
    }
}
