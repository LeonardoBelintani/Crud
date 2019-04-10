using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ClientAddress
    {
        public string Id { get; set; }
        public string IdClient { get; set; }
        public char Type { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Active { get; set; }

        public Client Client { get; set; }
    }
}
