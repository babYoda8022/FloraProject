using Flora.Floras;
using Flower.Enumerator;
using Flower.Flowers;
using System.Text.RegularExpressions;

namespace Dev
{
    public partial class SistemDevTest
    {
        public void CreateFlora<T>(EnumFlora flora = EnumFlora.Standard, T? load = null, int position = 0) where T : class
        {
            dynamic? _flora = null;
            if(load is null)
            {
                Console.Write("Qual o nome da sua Flora : ");
                string name = Console.ReadLine();
                Thread.Sleep(2000);
                Console.WriteLine();

                Console.Write("Quanto de vida sua Flora tem : ");
                int life = int.Parse(Console.ReadLine());
                Thread.Sleep(2000);

                Console.WriteLine();
                Console.WriteLine("Criando sua Flora, aguarde...");

                if (flora == EnumFlora.Normal)
                {
                    _flora = new NormalFlora(name, life);
                }
                else if (flora == EnumFlora.Rare)
                {
                    _flora = new RareFlora(name, life);
                }
                else if (flora == EnumFlora.SuperRare)
                {
                    _flora = new SuperRareFlora(name, life);
                }
                else
                {
                    _flora = new StandardFlora(name, life);
                }
            }
            else
            {
                Console.Write("Seu Flora está sendo carregado, aguarde...");
                _flora = load;
            }
            Thread.Sleep(2000);
            Console.Clear();
            bool exit = false;
            do
            {
                Console.WriteLine($"Flora name : {_flora.Name}");
                Console.WriteLine($"Flora life : {_flora.Life}");
                Console.WriteLine($"Flora max life : {_flora.MaxLife}");
                Console.WriteLine($"Flora mood : {_flora.Mood}");
                Console.WriteLine($"Flora personality : {_flora.Personality}");
                Console.WriteLine($"Flora life circle : {_flora.LifeCycle}");
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
                        Console.WriteLine("");
                        Console.WriteLine("Deseja salvar sua Flora?");
                        Console.WriteLine("[1] - Sim");
                        Console.WriteLine("[0] - Não");
                        Console.Write("Opção: ");
                        keyPress = Console.ReadLine();
                        Console.WriteLine("");
                        switch (keyPress)
                        {
                            case "1":
                                Thread.Sleep(2000);
                                Console.WriteLine("Salvando sua Flora, aguarde...");
                                Thread.Sleep(2000);
                                Console.WriteLine("Sua Flora foi salva!");
                                if (load is null)
                                {
                                    if (_flora is StandardFlora)
                                    {
                                        _standardFlora.Add(_flora);
                                        exit = true;
                                        Console.Clear();
                                    }else if (_flora is NormalFlora)
                                    {
                                        _normalFlora.Add(_flora);
                                        exit = true;
                                        Console.Clear();
                                    }
                                    else if (_flora is RareFlora)
                                    {
                                        _rareFlora.Add(_flora);
                                        exit = true;
                                        Console.Clear();
                                    }
                                    else if (_flora is SuperRareFlora)
                                    {
                                        _superRareFlora.Add(_flora);
                                        exit = true;
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    if (load is StandardFlora)
                                    {
                                        _standardFlora[position] = _flora;
                                        exit = true;
                                        Console.Clear();
                                    }
                                    else if (load is NormalFlora)
                                    {
                                        _normalFlora[position] = _flora;
                                        exit = true;
                                        Console.Clear();
                                    }
                                    else if (load is RareFlora)
                                    {
                                        _rareFlora[position] = _flora;
                                        exit = true;
                                        Console.Clear();
                                    }
                                    else if (load is SuperRareFlora)
                                    {
                                        _superRareFlora[position] = _flora;
                                        exit = true;
                                        Console.Clear();
                                    }
                                }
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
                        Console.Write("Quanto de vida deseja adicionar? : ");
                        int addLife = int.Parse(Console.ReadLine());
                        _flora.AddLife(addLife);
                        Thread.Sleep(2000);
                        Console.WriteLine($"Foram adicionados {addLife} pontos de vida");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case "2":
                        Thread.Sleep(2000);
                        Console.Write("Quanto de vida deseja remover? : ");
                        int removeLife = int.Parse(Console.ReadLine());
                        _flora.RemoveLife(removeLife);
                        Thread.Sleep(2000);
                        Console.WriteLine($"Foram removidos {removeLife} pontos de vida");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case "3":
                        Thread.Sleep(2000);
                        Console.Clear();
                        string[] attributes = new string[] { "Power", "Run", "Fly", "Swim", "Stamina" };
                        List<string> points = new List<string>();
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write($"Quantos pontos deseja adicionar de {attributes[i]}? : ");
                            points.Add(Console.ReadLine());
                            Thread.Sleep(1000);
                        }
                        if (points.Count == 5)
                        {
                            PowerFlower _powerFLora = new(int.Parse(points[0]), EnumFlowerColor.Red);
                            RunFlower _runFLora = new(int.Parse(points[1]), EnumFlowerColor.Green);
                            FlyFlower _flyFLora = new(int.Parse(points[2]), EnumFlowerColor.Dark);
                            SwimFlower _swimFLora = new(int.Parse(points[3]), EnumFlowerColor.Blue);
                            StaminaFlower _staminaFLora = new(int.Parse(points[4]), EnumFlowerColor.None);

                            _flora.SetPowerPoints(_powerFLora.PowerFlowerPoint);
                            _flora.SetRunPoints(_runFLora.RunFlowerPoint);
                            _flora.SetFlyPoints(_flyFLora.FlyFlowerPoint);
                            _flora.SetSwinPoints(_swimFLora.SwimFlowerPoint);
                            _flora.SetStaminaPoints(_staminaFLora.StaminaFlowerPoint);
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
        private void ListFlora()
        {
            Console.Clear();
            Thread.Sleep(1000);

            if (_standardFlora.Count() > 0)
            {
                Console.WriteLine("----- StandardFlora -----");
                Console.WriteLine();
                for (int i = 0; i < _standardFlora.Count; i++)
                {
                    Console.WriteLine($"[{i}] - Name : {_standardFlora[i].Name}, Life : {_standardFlora[i].Life}");
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------------------");

            }
            if (_normalFlora.Count() > 0)
            {
                Console.WriteLine("----- NormalFlora -----");
                Console.WriteLine();
                for (int i = 0; i < _normalFlora.Count; i++)
                {
                    Console.WriteLine($"[{i}] - Name : {_normalFlora[i].Name}, Life : {_normalFlora[i].Life}");
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------------------");
            }
            if (_rareFlora.Count() > 0)
            {
                Console.WriteLine("----- RareFlora -----");
                Console.WriteLine();
                for (int i = 0; i < _rareFlora.Count; i++)
                {
                    Console.WriteLine($"[{i}] - Name : {_rareFlora[i].Name}, Life : {_rareFlora[i].Life}");
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------------------");
            }
            if (_superRareFlora.Count() > 0)
            {
                Console.WriteLine("----- SuperRareFlora -----");
                Console.WriteLine();
                for (int i = 0; i < _superRareFlora.Count; i++)
                {
                    Console.WriteLine($"[{i}] - Name : {_superRareFlora[i].Name}, Life : {_superRareFlora[i].Life}");
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------------------");
            }
            else
            {
                Console.WriteLine("Não existe nenhuma Flora salva");
                Thread.Sleep(2000);
                Console.Clear();
            }

        }

    }
}
