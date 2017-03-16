using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LetsGoBootstrap.Models
{
    public class Contact
    {
        [RegularExpression(@"^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*)$",
        ErrorMessage ="Please enter a valid name.")]
        [Required]
        [MaxLength(25,
        ErrorMessage ="Sorry, but you have exceed the maximum allowed length for a first name.")]
        public string FirstName { get; set; }
        [RegularExpression(@"^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*)$",
        ErrorMessage = "Please enter a valid name.")]
        [Required]
        [MaxLength(25,
        ErrorMessage = "Sorry, but you have exceed the maximum allowed length for a last name.")]
        public string LastName { get; set; }

        [EmailAddress][Required]
        public string Email { get; set; }
        [Phone][Required]
        public string PhoneNumber { get; set; }
        [Phone]
        public string PhoneNumber2 { get; set; }
        [RegularExpression(@"/([a-z]{1,2}[0-9]{1,2})([a-z]{1,2})?(\W)?([0-9]{1,2}[a-z]{2})?/ig",ErrorMessage ="Please enter a valid post code.")]
        public string PostCode { get; set; }
        [MaxLength(50,ErrorMessage = "Sorry, but you have exceed the maximum allowed length for this field.")]
        public string AddressLine1 { get; set; }
        [MaxLength(50, ErrorMessage = "Sorry, but you have exceed the maximum allowed length for this field.")]
        public string AddressLine2 { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public List<Message> Message { get; set; }
        public int ContactTypeId { get; set; }

        public virtual ContactType ContactType { get; set; }
        //[MaxLength(250, 
        //ErrorMessage = "Sorry, but you have exceed the maximum allowed length for this field.")]
        //public string Message { get; set; }

    }
}
