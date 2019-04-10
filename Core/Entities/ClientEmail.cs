using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ClientEmail
    {
        public string Id { get; set; }
        public string IdClient { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Active { get; set; }

        public Client Client { get; set; }
    }
}
