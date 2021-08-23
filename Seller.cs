using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjectCSharp
{
    public class Seller : User
    {
        // public Seller(int id, string name, Address deliveryAddress, Address billingAddress, string username, string password, DateTime birthDate) : base(id, name, deliveryAddress, billingAddress, username, password, birthDate)
        // {
        // }

        private static List<Seller> Sellers = new List<Seller>();

        public static void CreateSeller()
        {

            Seller newSeller = new Seller();
            newSeller.DeliveryAddress = new Address();
            Address deliveryAddress = newSeller.DeliveryAddress;
            Address billingAddress = newSeller.BillingAddress;

            newSeller.Id = Sellers.Count + 1;
            //pegar dados com input
            Console.WriteLine("Digite o seu nome completo ou o nome da empresa:");
            string response = Console.ReadLine();
            newSeller.Name = response;
            Console.WriteLine("O endereço de recebimento/envio de mercadorias é o mesmo de cobrança? (S/N)");
            response = Console.ReadLine();
            do 
            {
               Console.WriteLine("Digite S (sim) ou N (não)"); 
            } while (response.ToUpper() != "S" || response.ToUpper() != "N");

            if (response.ToUpper() == "S") {
                Console.WriteLine("Digite o seu endereço:");
                Console.WriteLine("Endereço:");
                response = Console.ReadLine();
                deliveryAddress.FirstAddress = response;
                billingAddress.FirstAddress = response;
                Console.WriteLine("Complemento:");
                response = Console.ReadLine();
                deliveryAddress.SecondAddress = response;
                billingAddress.SecondAddress = response;
                Console.WriteLine("Número:");
                int number;
                var tryParse = Int32.TryParse(Console.ReadLine(), out number);
                do 
                {
                    Console.WriteLine("Formato inválido, coloque só números"); 
                } while (!tryParse);
                deliveryAddress.Number = number;
                billingAddress.Number = number;
                Console.WriteLine("CPF/CNPJ:");
                response = Console.ReadLine();
                deliveryAddress.ZipCode = response;
                billingAddress.ZipCode = response;
                Console.WriteLine("Cidade:");
                response = Console.ReadLine();
                deliveryAddress.City = char.ToUpper(response[0]) + response.Substring(1);
                billingAddress.City = char.ToUpper(response[0]) + response.Substring(1);
                Console.WriteLine("Estado:");
                response = Console.ReadLine();
                deliveryAddress.State = char.ToUpper(response[0]) + response.Substring(1);
                billingAddress.State = char.ToUpper(response[0]) + response.Substring(1);
                Console.WriteLine("País:");
                response = Console.ReadLine();
                deliveryAddress.Country = char.ToUpper(response[0]) + response.Substring(1);
                billingAddress.Country = char.ToUpper(response[0]) + response.Substring(1);
            } else if (response.ToUpper() == "N") {
                //DeliveryAddress
                Console.WriteLine("Digite o seu endereço de RECEBIMENTO:");
                Console.WriteLine("Endereço:");
                response = Console.ReadLine();
                deliveryAddress.FirstAddress = response;
                Console.WriteLine("Complemento:");
                response = Console.ReadLine();
                deliveryAddress.SecondAddress = response;
                Console.WriteLine("Número:");
                int number;
                var tryParse = Int32.TryParse(Console.ReadLine(), out number);
                do 
                {
                    Console.WriteLine("Formato inválido, coloque só números"); 
                } while (!tryParse);
                deliveryAddress.Number = number;
                Console.WriteLine("CPF:");
                response = Console.ReadLine();
                deliveryAddress.ZipCode = response;
                Console.WriteLine("Cidade:");
                response = Console.ReadLine();
                deliveryAddress.City = char.ToUpper(response[0]) + response.Substring(1);
                Console.WriteLine("Estado:");
                response = Console.ReadLine();
                deliveryAddress.State = char.ToUpper(response[0]) + response.Substring(1);
                Console.WriteLine("País:");
                response = Console.ReadLine();
                deliveryAddress.Country = char.ToUpper(response[0]) + response.Substring(1);
                //BillingAddress
                Console.WriteLine("Agora, digite o seu endereço de COBRANÇA:");
                Console.WriteLine("Endereço:");
                response = Console.ReadLine();
                billingAddress.FirstAddress = response;
                Console.WriteLine("Complemento:");
                response = Console.ReadLine();
                billingAddress.SecondAddress = response;
                Console.WriteLine("Número:");
                int numberBilling;
                var tryParseBilling = Int32.TryParse(Console.ReadLine(), out numberBilling);
                do 
                {
                    Console.WriteLine("Formato inválido, coloque só números"); 
                } while (!tryParseBilling);
                billingAddress.Number = numberBilling;
                Console.WriteLine("CPF:");
                response = Console.ReadLine();
                billingAddress.ZipCode = response;
                Console.WriteLine("Cidade:");
                response = Console.ReadLine();
                billingAddress.City = char.ToUpper(response[0]) + response.Substring(1);
                Console.WriteLine("Estado:");
                response = Console.ReadLine();
                billingAddress.State = char.ToUpper(response[0]) + response.Substring(1);
                Console.WriteLine("País:");
                response = Console.ReadLine();
                billingAddress.Country = char.ToUpper(response[0]) + response.Substring(1);
            }

            Console.WriteLine("Digite o seu nome de usuário:");
            response = Console.ReadLine();
            newSeller.Username = response;
            Console.WriteLine("Digite a sua senha:");
            response = Console.ReadLine();
            newSeller.Password = response;
            Console.WriteLine("Digite a sua data de nascimento ou data de criação da empresa:");
            response = Console.ReadLine();
            DateTime birthDate;
            var tryParseDateTime = DateTime.TryParseExact(response, "d/M/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out birthDate);
            newSeller.BirthDate = birthDate;
            
            Sellers.Add(newSeller);
        }

        public override string ToString()
        {
            return $"{this.Name} - ID: {this.Id}";
        }
    }
}