using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models
{
    public class Tag
    {
        //primary keys
        public int? Id { get; set; }
        public int? PostId { get; set; }
        public string? BlogUserId { get; set; }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} characters long")]
        public string Text { get; set; }


        //nav properties
        public virtual Post Post { get; set; }
        public virtual BlogUser BlogUser { get; set; }

    }
}
