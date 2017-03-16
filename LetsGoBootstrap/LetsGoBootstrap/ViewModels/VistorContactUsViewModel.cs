using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LetsGoBootstrap.ViewModels
{
    public class VistorContactUsViewModel
    {

        [RegularExpression(@"^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*)$",
        ErrorMessage = "Please enter a valid name.")]
        [Required][Display(Name ="First name")]
        [MaxLength(25,
        ErrorMessage = "Sorry, but you have exceed the maximum allowed length for a first name.")]
        public string FirstName { get; set; }
        [RegularExpression(@"^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*)$",
        ErrorMessage = "Please enter a valid name.")]
        [Required][Display(Name ="Last name")]
        [MaxLength(25,
        ErrorMessage = "Sorry, but you have exceed the maximum allowed length for a last name.")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(250,
       ErrorMessage = "Sorry, but you have exceed the maximum allowed length for this field.")]
        public string Message { get; set; }
    }
}
