using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Reply : Comments
    {
        [Required]
        public Comments ReplyComments { get; set; }
        // I feel like somthing isn't right here - no Key.. what would the key be? OG post that we're commenting on? 
    }
}
