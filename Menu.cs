using System;

namespace ProjectCSharp
{
    public static class Menu
    {
        public static void GeneralMenuOption() {
            string _option = GeneralMenu();
            int _optionInt;
            bool _optionToInt = Int32.TryParse(_option, out _optionInt);
            if (_optionToInt) Option(_optionInt);
            else Option(0);
        }
        
        public static string GeneralMenu() {
            Console.WriteLine("Bem vindo ao sistema de marketplace");
            Console.WriteLine("Digite o número da opção desejada");
            Console.WriteLine("1 - Cadastrar novo vendedor");
            Console.WriteLine("2 - Cadastrar novo cliente");
            Console.WriteLine("3 - Buscar vendedor");
            Console.WriteLine("4 - Buscar cliente");
            Console.WriteLine("5 - Atualizar dados vendedor");
            Console.WriteLine("6 - Atualizar dados cliente");
            Console.WriteLine("7 - Deletar dados vendedor");
            Console.WriteLine("8 - Deletar dados cliente");
            Console.WriteLine("9 - Deletar cliente");
            Console.WriteLine("10 - Deletar vendedor");
            Console.WriteLine("11 - Sair");
            Console.Write("Opção: ");
            return Console.ReadLine();
        }

        public static void Option(int _option) {
            switch(_option) {
                case 1:
                ProjectCSharp.Seller.CreateSeller();
                break;
                case 2:
                ProjectCSharp.Client.CreateClient();
                break;
                case 3:
                //ProjectCSharp.Seller.SearchSeller();
                break;
                case 4:
                //ProjectCSharp.Seller.SearchClient();
                break;
                case 5:
                //ProjectCSharp.Seller.UpdateDataSeller();
                break;
                case 6:
                //ProjectCSharp.Seller.UpdateDataClient();
                break;
                case 7:
                //ProjectCSharp.Seller.DeleteDataSeller();
                break;
                case 8:
                //ProjectCSharp.Seller.DeleteDataClient();
                break;
                case 9:
                //ProjectCSharp.Seller.DeleteSeller();
                break;
                case 10:
                //ProjectCSharp.Seller.DeleteClient();
                break;
                case 11:
                break;
                default:
                Console.WriteLine("Opção inválida, tente novamente mais tarde");
                break;
            }
        }
    }
}