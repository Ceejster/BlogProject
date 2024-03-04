using BlogProject.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models
{
    public class Comment
    {
        //primary/foreign keys
        public int? Id { get; set; }
        public int? PostId { get; set; }
        public string? BlogUserId { get; set; }
        public string? ModeratorId { get; set; }



        [StringLength(500, MinimumLength = 1, ErrorMessage = "Comment too short")]
        [Display(Name = "Comment")]
        public string? Body { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime? Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime? Updated { get; set; }

        public DateTime? Moderated { get; set; }

        public DateTime? Deleted { get; set; }

        [StringLength(500, MinimumLength = 1, ErrorMessage = "Comment too short")]
        [Display(Name = "Moderated Comment")]
        public string? ModeratedBody { get; set; }

        public ModerationType? ModerationType { get; set; }

        //Nav properties
        public virtual Post? Post { get; set; }
        public virtual BlogUser? BlogUser { get; set; }
        public virtual BlogUser? Moderator { get; set; }


    }
}
