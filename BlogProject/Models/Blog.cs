using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace BlogProject.Models
{
    public class Blog
    {
        //primary keys
        public int? Id { get; set; }
        public string? BlogUserId { get; set; }



        [StringLength(40, MinimumLength = 2, ErrorMessage = "Shorten blog title")]
        public string? Name { get; set; }

        [StringLength(500, MinimumLength = 10, ErrorMessage = "Description must be between {2} and {1} characters")]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime? Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime? Updated { get; set; }

        [Display(Name = "Blog Image")]
        public byte[]? ImageDate { get; set; }

        [Display(Name = "Image Type")]
        public string? ContentType { get; set; }

        [NotMapped]
        public IFormFile? Image { get; set; }


        //nav properties
        [Display(Name = "Author")]
        public virtual BlogUser? BlogUser { get; set; }

        //ICollection because it's a parent
        public virtual ICollection<Post>? Posts { get; set;} = new HashSet<Post>();


    }
}
