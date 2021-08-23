using System;

namespace ProjectCSharp
{
    public class Address
    {
        public string FirstAddress { get; set; }

        public string SecondAddress { get; set; }

        public int Number { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public override string ToString()
        {
            return $"{this.FirstAddress}, {this.SecondAddress}, {this.Number}, {this.ZipCode}, {this.City}, {this.State}, {this.Country}";
        }
    }
}