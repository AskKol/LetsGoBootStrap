using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoBootstrap.Models
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetContact(int? contactId, string name);
        Dictionary<int,string> SendMessage(Contact aContact);
    }
}
