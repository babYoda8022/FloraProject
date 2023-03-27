using Flora.Floras;

namespace Dev
{
    public partial class SistemDevTest
    {

        private List<StandardFlora> _standardFlora = new List<StandardFlora>();
        private List<NormalFlora> _normalFlora = new List<NormalFlora>();
        private List<RareFlora> _rareFlora = new List<RareFlora>();
        private List<SuperRareFlora> _superRareFlora = new List<SuperRareFlora>();
        public enum EnumFlora
        {
            Standard = 0,
            Normal = 1,
            Rare = 2,
            SuperRare = 3,
        }

        public void Start()
        {
            Console.WriteLine("Bem vindo ao projeto Flora (Dev)");
            Thread.Sleep(1500);
            Console.Clear();
            bool exit = false;
            do{
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine("[1] - Criar Standard Flora");
                Console.WriteLine("[2] - Criar Normal Flora");
                Console.WriteLine("[3] - Criar Rare Flora");
                Console.WriteLine("[4] - Criar Super Rare Flora");
                Console.WriteLine("[5] - Carregar Flora salva");
                Console.WriteLine("[6] - Ver lista de Floras salvas");
                Console.WriteLine("[0] - Sair");
                Console.Write("Opção: ");
                string keyPress = Console.ReadLine();
                switch (keyPress)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        Console.Clear();
                        CreateFlora<StandardFlora>(EnumFlora.Standard);
                        break;
                    case "2":
                        CreateFlora<NormalFlora>(EnumFlora.Normal);
                        break;
                    case "3":
                        CreateFlora<RareFlora>(EnumFlora.Rare);
                        break;
                    case "4":
                        CreateFlora<SuperRareFlora>(EnumFlora.SuperRare);
                        break;
                    case "5":
                        Console.Clear();
                        SelectSaveFlora();
                        break;
                    case "6":
                        Console.Clear();
                        ListFlora();
                        break;
                    default:
                        Console.WriteLine($"A opção {keyPress} não existe");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            }while(!exit);
        }
    
    }
}
