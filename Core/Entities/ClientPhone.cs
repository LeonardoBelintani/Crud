using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ClientPhone
    {
        public string Id { get; set; }
        public string IdClient { get; set; }
        public char Type { get; set; }
        public string Prefix { get; set; }
        public string Number { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Active { get; set; }

        public Client Client { get; set; }
    }
}
