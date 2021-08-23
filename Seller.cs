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
            newSeller.BillingAddress = new Address();
            Address billingAddress = newSeller.BillingAddress;

            newSeller.Id = Sellers.Count + 1;
            //pegar dados com input
            Console.WriteLine("Digite o seu nome completo ou o nome da empresa:");
            string response = Console.ReadLine();
            newSeller.Name = response;
            Console.WriteLine("O endereço de recebimento/envio de mercadorias é o mesmo de cobrança? (S/N)");
            response = Console.ReadLine();
            while (response.ToUpper() != "S" && response.ToUpper() != "N") 
            {
               Console.WriteLine("Digite S (sim) ou N (não)");
               response = Console.ReadLine();
            };

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
                bool tryParse = Int32.TryParse(Console.ReadLine(), out number);
                while (!tryParse)
                {
                    Console.WriteLine("Formato inválido, coloque só números");
                    tryParse = Int32.TryParse(Console.ReadLine(), out number); 
                };
                deliveryAddress.Number = number;
                billingAddress.Number = number;
                Console.WriteLine("CEP:");
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
                bool tryParse = Int32.TryParse(Console.ReadLine(), out number);
                while (!tryParse)
                {
                    Console.WriteLine("Formato inválido, coloque só números"); 
                    tryParse = Int32.TryParse(Console.ReadLine(), out number);
                };
                deliveryAddress.Number = number;
                Console.WriteLine("CEP:");
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
                tryParse = Int32.TryParse(Console.ReadLine(), out number);
                while (!tryParse)
                {
                    Console.WriteLine("Formato inválido, coloque só números"); 
                    tryParse = Int32.TryParse(Console.ReadLine(), out number);
                };
                billingAddress.Number = number;
                Console.WriteLine("CEP:");
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
            Console.WriteLine("Digite a sua data de nascimento ou data de criação da empresa (ex.: 08/04/2003):");
            response = Console.ReadLine();
            bool tryParseDateTime;
            DateTime birthDate;
            // do
            // {
                tryParseDateTime = DateTime.TryParseExact(response, "d/M/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out birthDate);
            //     if (!tryParseDateTime) Console.WriteLine("Insira uma data válida no formato d/M/yyyy");
            // } while (!tryParseDateTime);
            newSeller.BirthDate = birthDate;
            
            Sellers.Add(newSeller);
            Console.WriteLine("PERFIL CRIADO! Seus dados são: ");
            Console.WriteLine(newSeller);
            Console.WriteLine("Deseja mudar alguma informação? (S/N)");
            response = Console.ReadLine();
            while (response.ToUpper() != "S" && response.ToUpper() != "N") 
            {
               Console.WriteLine("Digite S (sim) ou N (não)");
               response = Console.ReadLine();
            };
            // if (response.ToUpper() == "S") ChangeDataClient(this);
            // else 
            // {
            //     Console.WriteLine("O que deseja fazer agora?");
            //     ProjectCSharp.Menu.GeneralMenuOption();
            // }
        }

        public override string ToString()
        {
            return $"Nome: {this.Name} - ID: {this.Id} - Endereço de recebimento: {this.DeliveryAddress} - Endereço de cobrança: {this.BillingAddress} - Nome de usuário: {this.Username} - Senha: {this.Password} - Data de nascimento: {this.BirthDate}";
        }
    }
}