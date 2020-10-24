using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string CommentText { get; set; }

        //public User CommentAuthor { get; set; } // why is this error?
        [Required]
        public Guid Author { get; set; }

        [Required]
        public Post CommentedPost { get; set; }
    }
}
