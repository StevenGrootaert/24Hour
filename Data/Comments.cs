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

        [Required]
        //public User CommentAuthor { get; set; } // why is this error?

        public string Author { get; set; }

        [Required]
        public Post CommentedPost { get; set; }
    }
}
