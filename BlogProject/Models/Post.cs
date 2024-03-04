using BlogProject.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogProject.Models
{
    public class Post
    {
        //primary keys
        public int? Id { get; set; }

        [Display(Name = "Blog Name")]
        public int? BlogId { get; set; }
        public string? BlogUserId { get; set; }



        [StringLength(40, MinimumLength = 2, ErrorMessage = "Shorten post title")]
        public string? Title { get; set; }

        [StringLength(200, MinimumLength = 2, ErrorMessage = "Shorten abstract")]
        public string? Abstract { get; set; }

        public string? Content { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime? Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime? Updated { get; set; }

        [Display(Name = "Ready Status")]
        public ReadyStatus ReadyStatus { get; set; }

        public string? Slug { get; set; }

        [Display(Name = "Blog Image")]
        public byte[]? ImageDate { get; set; }

        [Display(Name = "Image Type")]
        public string? ContentType { get; set; }

        [NotMapped]
        public IFormFile? Image { get; set; }


        //nav propeties
        public virtual Blog? Blog { get; set; }
        public virtual BlogUser? BlogUser { get; set; }

        //ICollection because it's a parent
        public virtual ICollection<Tag> Tags {  get; set; } = new HashSet<Tag>();
        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
