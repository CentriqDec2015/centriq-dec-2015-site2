using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace centriq_dec_2015_site2.Models
{
    public class ContactViewModel
    {
        public int ContactViewModelID { get; set; }

        [Required(ErrorMessage = "*Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,}$", ErrorMessage = "Please enter a valid email. Ex: you@yourdomain.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Required")]

        public string Subject { get; set; }

     
        [UIHint("MultilineText")]
        [Required(ErrorMessage = "*Required")]
        [StringLength(500, ErrorMessage = "Please limit your response to no more than 500 characters")]
        public string Message { get; set; }





    }
}