using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoBootstrap.Models
{
    public class ContactType
    {
        public int Id { get; set; }
        public UserTypes Type { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
