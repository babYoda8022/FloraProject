using Flora.Base;
using Flora.Floras;
using System.Text.RegularExpressions;

namespace Dev
{
    public class SistemDevTest
    {

        private StandardFlora _standardFlora;
        private NormalFlora _normaFlora;
        private RareFlora _rareFlora;
        private SuperRareFlora _superRareFlora;

        public void Start()
        {
            Console.WriteLine("Bem vindo ao projeto Flora (Dev)");
            Thread.Sleep(1500);
            Console.Clear();
            bool exit = false;
            do{
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine("[0] - Sair");
                Console.WriteLine("[1] - Standard Flora");
                Console.WriteLine("[2] - Normal Flora");
                Console.WriteLine("[3] - Rare Flora");
                Console.WriteLine("[4] - Super Rare Flora");

                string keyPress = Console.ReadLine();
                switch (keyPress)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        Console.Clear();
                        StandardFlora();
                        break;
                    case "2":
                        exit = true;
                        break;
                    case "3":
                        exit = true;
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine($"A opção {keyPress} não existe");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            }while(!exit);
        }

        private void StandardFlora()
        {
            Console.Write("Qual o nome da sua Flora: ");
            string name = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine();

            Console.Write("Quanto de vida sua Flora tem: ");
            int life = int.Parse(Console.ReadLine());
            Thread.Sleep(2000);

            Console.WriteLine();
            Console.WriteLine("Criando sua Flora, aguarde...");
            _standardFlora = new(name, life);
            Thread.Sleep(2000);
            Console.Clear();

            
        }

    }
}
