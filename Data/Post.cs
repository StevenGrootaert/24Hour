using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string PostTitle { get; set; }

        [Required]
        public string PostText { get; set; }

        //[Required]
        ///public User PostAuthor { get; set; }  // I feel like if we tied the owner ID to the Post we can generate the author without this... 

        /* I feel like these would be good to have but not in the prompt... 
         * [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
        */

    }
}
