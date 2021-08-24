using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectCSharp
{
    public class Seller : User
    {
        protected static List<Seller> Sellers = new List<Seller>();
        public static void SearchSeller(string username)
        {
            Sellers.FirstOrDefault(seller => seller.Username == username);
        }

        public override string ToString()
        {
            return $"Nome: {this.Name} - ID: {this.Id} - Endereço de recebimento: {this.DeliveryAddress} - Endereço de cobrança: {this.BillingAddress} - Nome de usuário: {this.Username} - Senha: {this.Password} - Data de nascimento: {this.BirthDate}";
        }
    }
}