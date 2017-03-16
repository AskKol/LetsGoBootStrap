using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoBootstrap.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string AMessage { get; set; }
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
        public int MessageTypeId { get; set; }
        public virtual MessageType MessageType { get; set; }
    }
}
