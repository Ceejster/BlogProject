using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogProject.Models
{
    public class BlogUser : IdentityUser
    {
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} characters long")]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} characters long")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        public byte[]? ImageData { get; set; }
        public string? ContentType { get; set; }

        public string? FacebookUrl { get; set; }
        public string? InstagramUrl { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }

        }

        //nav properties - collections of blogs+posts+comments
        public virtual ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        //public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
