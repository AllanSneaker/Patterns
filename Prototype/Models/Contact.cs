using System;

namespace Prototype.Models
{
    [Serializable]
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address WorkAddress { get; set; }
    }
}
