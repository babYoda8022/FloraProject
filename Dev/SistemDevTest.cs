using Flora.Base;
using Flora.Floras;
using Flower.Enumerator;
using Flower.Flowers;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Dev
{
    public class SistemDevTest
    {

        private List<StandardFlora> _standardFlora;
        private List<NormalFlora> _normaFlora;
        private List<RareFlora> _rareFlora;
        private List<SuperRareFlora> _superRareFlora;

        public void Start()
        {
            Console.WriteLine("Bem vindo ao projeto Flora (Dev)");
            Thread.Sleep(1500);
            Console.Clear();
            bool exit = false;
            do{
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine("[1] - Standard Flora");
                Console.WriteLine("[2] - Normal Flora");
                Console.WriteLine("[3] - Rare Flora");
                Console.WriteLine("[4] - Super Rare Flora");
                Console.WriteLine("[5] - Ver lista de Floras salvas");
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
                    case "5":
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
            StandardFlora standardFlora = new(name, life);
            Thread.Sleep(2000);
            Console.Clear();
            bool exit = false;
            do
            {
                Console.WriteLine($"Flora name: {standardFlora.Name}");
                Console.WriteLine($"Flora life: {standardFlora.Life}");
                Console.WriteLine($"Flora max life: {standardFlora.MaxLife}");
                Console.WriteLine($"Flora mood: {standardFlora.Mood}");
                Console.WriteLine($"Flora personality: {standardFlora.Personality}");
                Console.WriteLine($"Flora life circle: {standardFlora.LifeCycle}");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine("[1] - Adicionar Vida");
                Console.WriteLine("[2] - Remover Vida");
                Console.WriteLine("[3] - Adicionar Flora points");
                Console.WriteLine("[0] - Sair");
                Console.Write("Opção: ");
                string keyPress = Console.ReadLine();
                switch (keyPress)
                {
                    case "0":
                        Console.WriteLine("Deseja salvar sua Flora?");
                        Console.WriteLine("[1] - Sim");
                        Console.WriteLine("[0] - Não");
                        Console.Write("Opção: ");
                        keyPress = Console.ReadLine();
                        switch (keyPress) 
                        {
                            case "1":
                                Thread.Sleep(2000);
                                Console.WriteLine("Salvando sua Flora, aguarde...");
                                Thread.Sleep(2000);
                                Console.WriteLine("Sua Flora foi salva!");
                                _standardFlora.Add(standardFlora);
                                exit = true;
                                Console.Clear();
                                break;
                            case "0":
                                exit = true;
                                break;
                            default:
                                Console.WriteLine($"A opção {keyPress} não existe");
                                Thread.Sleep(1500);
                                Console.Clear();
                                break;
                        }
                        break;
                    case "1":
                        Thread.Sleep(2000);
                        Console.Write("Quanto de vida deseja adicionar? :");
                        int addLife = int.Parse(Console.ReadLine());
                        standardFlora.AddLife(addLife);
                        Thread.Sleep(2000);
                        Console.WriteLine($"Foram adicionados {addLife} pontos de vida");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case "2":
                        Thread.Sleep(2000);
                        Console.Write("Quanto de vida deseja remover? : ");
                        int removeLife = int.Parse(Console.ReadLine());
                        standardFlora.RemoveLife(removeLife);
                        Thread.Sleep(2000);
                        Console.WriteLine($"Foram removidos {removeLife} pontos de vida");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case "3":
                        Thread.Sleep(2000);
                        Console.Clear();
                        string[] attributes = new string[] {"Power", "Run", "Fly", "Swim", "Stamina"};
                        List<string> points = new List<string>();
                        for(int i = 0; i < 5; i++)
                        {
                            Console.Write($"Quantos pontos deseja adicionar de {attributes[i]}? : ");
                            points.Add(Console.ReadLine());
                            Thread.Sleep(1000);
                        }
                        if (points.Count == 5 )
                        {
                            PowerFlower _powerFLora = new(int.Parse(points[0]), EnumFlowerColor.Red);
                            RunFlower _runFLora = new(int.Parse(points[1]), EnumFlowerColor.Green);
                            FlyFlower _flyFLora = new(int.Parse(points[2]), EnumFlowerColor.Dark);
                            SwimFlower _swimFLora = new(int.Parse(points[3]), EnumFlowerColor.Blue);
                            StaminaFlower _staminaFLora = new(int.Parse(points[4]), EnumFlowerColor.None);

                            standardFlora.SetPowerPoints(_powerFLora.PowerFlowerPoint);
                            standardFlora.SetRunPoints(_runFLora.RunFlowerPoint);
                            standardFlora.SetFlyPoints(_flyFLora.FlyFlowerPoint);
                            standardFlora.SetSwinPoints(_swimFLora.SwimFlowerPoint);
                            standardFlora.SetStaminaPoints(_staminaFLora.StaminaFlowerPoint);
                            Thread.Sleep(2000);
                            Console.WriteLine("Os pontos foram adicionados");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Está faltando pontos a serem adicionados");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    default:
                        Console.WriteLine($"A opção {keyPress} não existe");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            } while (!exit);
        }

    }
}
