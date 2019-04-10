using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Client
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public string Birthday { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Nationality { get; set; }
        public string PlaceBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Active { get; set; }

        public virtual IList<ClientAddress> Addresses { get; set; }
        public virtual IList<ClientEmail> Emails { get; set; }
        public virtual IList<ClientPhone> Phones { get; set; }
    }
}
