using System;
using System.Security;

namespace ProjectCSharp
{
    public abstract class User
    {
        //repensar modificadores de acesso
        public int Id { get; set; }

        public string Name { get; set; }

        public Address DeliveryAddress { get; set; }

        public Address BillingAddress { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime BirthDate { get; set; } 

    }
}