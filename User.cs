using System;

namespace ProjectCSharp
{
    public class User
    {
        // public User(int id, string name, Address deliveryAddress, Address billingAddress, string username, string password, DateTime birthDate)
        // {
        //     Id = id;
        //     Name = name;
        //     DeliveryAddress = deliveryAddress;
        //     BillingAddress = billingAddress;
        //     Username = username;
        //     Password = password;
        //     BirthDate = birthDate;
        // }
        public int Id { get; set; }

        public string Name { get; set; }

        public Address DeliveryAddress { get; set; }

        public Address BillingAddress { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime BirthDate { get; set; }

        

    }
}