using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjectCSharp
{
    public class Client : User
    {

        protected static List<Client> Clients = new List<Client>();

        public override string ToString()
        {
            return $"Nome: {this.Name} - ID: {this.Id} - Endereço de recebimento: {this.DeliveryAddress} - Endereço de cobrança: {this.BillingAddress} - Nome de usuário: {this.Username} - Senha: {this.Password} - Data de nascimento: {this.BirthDate}";
        }
    }
}