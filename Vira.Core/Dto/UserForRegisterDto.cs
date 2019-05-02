using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vira.Core.Dto
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "پسورد 4-8 کاراکتر")]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
       
    }
}
