using Flora.Floras;
using System.Text.RegularExpressions;

namespace Dev
{
    public partial class SistemDevTest
    {
        private void LoadFlora<T>(T? load = null, int position = 0) where T : class
        {
            if (load?.GetType() == typeof(StandardFlora))
            {
                StandardFlora standardFlora = (StandardFlora)Convert.ChangeType(load, typeof(StandardFlora));
                CreateFlora(load: standardFlora, position: position);
            }
            else if (load?.GetType() == typeof(NormalFlora))
            {
                NormalFlora normalFlora = (NormalFlora)Convert.ChangeType(load, typeof(NormalFlora));
                CreateFlora(load: normalFlora, position: position);
            }
            else if (load?.GetType() == typeof(RareFlora))
            {
                RareFlora rareFlora = (RareFlora)Convert.ChangeType(load, typeof(RareFlora));
                CreateFlora(load: rareFlora, position: position);
            }
            else if (load?.GetType() == typeof(SuperRareFlora))
            {
                SuperRareFlora superRareFlora = (SuperRareFlora)Convert.ChangeType(load, typeof(SuperRareFlora));
                CreateFlora(load: superRareFlora, position: position);

            }
        }
        private void SelectSaveFlora()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Qual dos tipos de flora vai carrega?");
                Thread.Sleep(1000);
                List<dynamic> type = new() { _standardFlora, _normalFlora, _rareFlora, _superRareFlora };
                List<string> names = new() { "StandardFlora", "NormalFlora", "RareFlora", "SuperRareFlora" };
                for (int i = 0; i < type.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] - {names[i]}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("[0] - Sair");
                Thread.Sleep(500);
                Console.Write("Opção : ");
                string keyPress = Console.ReadLine();
                switch (keyPress)
                {
                    case "0":
                        Thread.Sleep(1000);
                        Console.Clear();
                        exit = true;
                        break;
                    case "1":
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (_standardFlora.Count > 0)
                        {
                            for (int i = 0; i < _standardFlora.Count; i++)
                            {
                                Console.WriteLine($"[{i}] - Nome : {_standardFlora[i].Name}, Vida : {_standardFlora[i].Life}");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine("Qual das StandardFlora deseja carregar? ");
                            Console.Write("Opção : ");
                            keyPress = Console.ReadLine();
                            if (int.Parse(keyPress) <= _standardFlora.Count || Regex.IsMatch(keyPress, @"( *)?[A-Z|a-z]{1,}?") == false)
                            {
                                LoadFlora(load: _standardFlora[int.Parse(keyPress)], int.Parse(keyPress));
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Você não tem floras salvas aqui");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    case "2":
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (_normalFlora.Count > 0)
                        {
                            for (int i = 0; i < _normalFlora.Count; i++)
                            {
                                Console.WriteLine($"[{i}] - Nome : {_normalFlora[i].Name}, Vida : {_normalFlora[i].Life}");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine("Qual das NormalFlora deseja carregar? ");
                            Console.Write("Opção : ");
                            keyPress = Console.ReadLine();
                            if (int.Parse(keyPress) <= _normalFlora.Count || Regex.IsMatch(keyPress, @"( *)?[A-Z|a-z]{1,}?") == false)
                            {
                                LoadFlora(load: _normalFlora[int.Parse(keyPress)], int.Parse(keyPress));
                            }
                            
                        }else
                            {
                                Console.WriteLine("Você não tem floras salvas aqui");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                        break;
                    case "3":
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (_rareFlora.Count > 0)
                        {
                            for (int i = 0; i < _rareFlora.Count; i++)
                            {
                                Console.WriteLine($"[{i}] - Nome : {_rareFlora[i].Name}, Vida : {_rareFlora[i].Life}");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine("Qual das RareFlora deseja carregar? ");
                            Console.Write("Opção : ");
                            keyPress = Console.ReadLine();
                            if (int.Parse(keyPress) <= _rareFlora.Count || Regex.IsMatch(keyPress, @"( *)?[A-Z|a-z]{1,}?") == false)
                            {
                                LoadFlora(load: _rareFlora[int.Parse(keyPress)], int.Parse(keyPress));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Você não tem floras salvas aqui");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    case "4":
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (_superRareFlora.Count > 0)
                        {
                            for (int i = 0; i < _superRareFlora.Count; i++)
                            {
                                Console.WriteLine($"[{i}] - Nome : {_superRareFlora[i].Name}, Vida : {_superRareFlora[i].Life}");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine("Qual das SuperRareFlora deseja carregar? ");
                            Console.Write("Opção : ");
                            keyPress = Console.ReadLine();
                            if (int.Parse(keyPress) <= _superRareFlora.Count || Regex.IsMatch(keyPress, @"( *)?[A-Z|a-z]{1,}?") == false)
                            {
                                LoadFlora(load: _superRareFlora[int.Parse(keyPress)], int.Parse(keyPress));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Você não tem floras salvas aqui");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    default:
                        Console.WriteLine("Essa opção não existe");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            } while (!exit);
        }
    }
}
