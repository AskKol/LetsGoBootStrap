using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoBootstrap.Models
{
    public class FakeContactRepository : IContactRepository
    {
        public IEnumerable<Contact> GetContact(int? contactId, string name)
        {
            return new List<Contact>()
            {
                new Contact()
                {
                    FirstName="Test firstname",
                    LastName="Test lastname",
                    County="Derbyshire",
                    Country="United Kingdom",
                    Email="askkol@gmail.com",
                    AddressLine1="74 Crompton street",
                    AddressLine2="",
                    PhoneNumber="01283648735",
                    PhoneNumber2="",
                    PostCode="De1 INy"
                }
            };
        }
    }
}
