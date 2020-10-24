﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class User  // I think this is the IdentityModels.cs that we move into the Data layer from the WebAPI layer. 
                // There's an AccountController in the WebAPI that handles the login in passwords and the AccountBindingModel. 
                // I think there's a way to change the username so it's not the email address. 
                // I feel like that's handeled in the AccountBindingModel or IdentityModel with the Application User class and or the information is already there with IdentityUser
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string UserPassword { get; set; }
    }
    
}
