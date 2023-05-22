using Projecto2023.Entities.Exeption;
using Projecto2023.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Curse
{
    class Cadastro
    {
        static void Main(string[] arsgs)
        {
            int x = 1;
            List<Atendimento> atendimentos = new List<Atendimento>();
            Medico medico = new Medico();

            try
            {
                while (x > 0)
                {
                    Console.WriteLine("------- *Cadastro* ---------");
                    Console.WriteLine("");
                    Console.WriteLine("1-Atendimento:");
                    Console.WriteLine("2-Sair:");
                    Console.WriteLine("3-Relátorio:");
                    Console.WriteLine("");
                    Console.Write("Choice a option please...");
                    int Choice = int.Parse(Console.ReadLine());
                    if (Choice == 1)
                    {
                        int y = 1;
                        while (y > 0)
                        {
                            Console.WriteLine("Atendimento");
                            Console.WriteLine("");
                            Console.WriteLine("1-Pessoa");
                            Console.WriteLine("2-Animais");
                            Console.WriteLine("3-Medico");
                            Console.WriteLine("4-Sair.");
                            Console.Write("Choice a option:");
                            int choiceA = int.Parse(Console.ReadLine());
                            switch (choiceA)
                            {
                                case 1:
                                    Console.WriteLine("Pessoa:");
                                    Console.WriteLine("");
                                    Console.Write("Quantas pessoas serão cadastradas:");
                                    int qt = int.Parse(Console.ReadLine());
                                    for (int i = 1; i <= qt; i++)
                                    {
                                        Console.Write($"{i} # pessoa:");
                                        Console.WriteLine();
                                        Console.Write("Name:");
                                        string name = Console.ReadLine();
                                        Console.Write("Sex:");
                                        string sexo = Console.ReadLine();
                                        Console.Write("Email:");
                                        string email = Console.ReadLine();
                                        Console.Write("Day Birthday:(dd/mm/yyy):");
                                        DateTime data = DateTime.Parse(Console.ReadLine());
                                        Console.Write("Number Phone:");
                                        string numberphone = Console.ReadLine();
                                        Console.Write("TypeOfsick:");
                                        string type = Console.ReadLine();
                                        Pessoa pessoa = new Pessoa(name, sexo, email, numberphone, type, data);
                                        atendimentos.Add(pessoa);
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("Animais");
                                    Console.WriteLine("");
                                    Console.Write("How many animals will be registered ?:");
                                    int n = int.Parse(Console.ReadLine());
                                    for (int i = 1; i <= n; i++)
                                    {
                                        Console.WriteLine($"{i} animal:");
                                        Console.WriteLine();
                                        Console.Write("Name animal:");
                                        string name = Console.ReadLine();
                                        Console.Write("Sex  animal:");
                                        string sexo = Console.ReadLine();
                                        Console.Write("Date Animal (dd/mm/yyyy):");
                                        DateTime data = DateTime.Parse(Console.ReadLine());
                                        Console.Write("TypeOfsick:");
                                        string type = Console.ReadLine();
                                        Console.Write("Peso:");
                                        double peso = double.Parse(Console.ReadLine());
                                        Animals animals = new Animals(name,sexo,type,data,peso);
                                        atendimentos.Add(animals);
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Medico");
                                    Console.WriteLine("");
                                    Console.Write("Name of department:");
                                    string department = Console.ReadLine();
                                    Console.Write("Name of doctor:");
                                    string nome = Console.ReadLine();
                                    Console.Write("Sex:");
                                    string sex = Console.ReadLine();
                                    medico = new Medico(nome, sex, department);
                                    break;

                                case 4:

                                    Console.WriteLine("Deseja continuar [0-finish/1-Continuar]:");
                                    int finish = int.Parse(Console.ReadLine());
                                    if (finish == 1)
                                    {
                                        y = y + 1;

                                    }
                                    else if (finish == 0)
                                    {
                                        y = y - 500;
                                    }
                                    break;


                                default:
                                    Console.WriteLine("['error']");
                                    break;
                            }
                        }
                    }



                    else if (Choice == 3)
                    {
                        Console.WriteLine("Relatory:");
                        Console.WriteLine();
                        Console.WriteLine("Choice a option to impress the relatory..?");
                        Console.WriteLine("1-Person.");
                        Console.WriteLine("2-Animals.");
                        Console.WriteLine("3-Medic.");
                        Console.WriteLine("");
                        int op = int.Parse(Console.ReadLine());
                        switch (op)
                        {
                            case 1:
                                foreach (Atendimento item in atendimentos)
                                {
                                    if (item != null)
                                    {
                                        Console.WriteLine("Type Person");
                                        Console.WriteLine();
                                        Console.WriteLine($"Nome:{item.Nome}");
                                        Console.WriteLine($"Sexo:{item.Sexo}");
                                        Console.WriteLine($"Date of register:{item.Time()}");
                                        Console.WriteLine($"TypeOfSick:{item.TipoDoenca}");
                                        Console.WriteLine($"Email:{item.Email}");
                                        Console.WriteLine($"PhoneNumber:{item.NumberPhone}");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        if (item == null)
                                        {
                                            Console.WriteLine("['The relatory is null.']");
                                        }
                                    }
                                }
                                break;

                            case 2:

                                foreach (Atendimento item in atendimentos)
                                {
                                    if (item != null)
                                    {
                                        Console.WriteLine("Type animal");
                                        Console.WriteLine();
                                        Console.WriteLine($"Nome:{item.Nome}");
                                        Console.WriteLine($"Sexo:{item.Sexo}");
                                        Console.WriteLine($"TypeOfSick:{item.TipoDoenca}");
                                        Console.WriteLine($"Date of register:{item.Time()}");
                                        Console.WriteLine();

                                    }
                                    else
                                    {
                                        if (item == null)
                                        {
                                            Console.WriteLine("['The relatory is null.']");
                                        }
                                    }
                                }
                                break;
                            case 3:
                                {
                                    
                                        Console.WriteLine("Medic");
                                        Console.WriteLine();
                                        Console.WriteLine($"Nome:{medico.Nome}");
                                        Console.WriteLine($"Sexo:{medico.Sexo}");
                                        Console.WriteLine($"department:{medico.Department}");
                                   

                                }
                                break;
                            default:
                                Console.WriteLine("erro");
                                break;
                        }
                    }

                    else if (Choice == 2)
                    {
                        Console.WriteLine("Deseja continuar:[1-Continuar/2-Terminar]:");
                        int over = int.Parse(Console.ReadLine());
                        if (over == 1)
                        {
                            x = x + 1;
                        }
                        else if (over == 2)
                        {
                            x = x - 200;
                        }

                    }  
                    


                  
                }
            }
            catch (DomainException e)
            {
                Console.WriteLine($"['ERROR'] message {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"['ERROR'] message {e.Message}");
            }
        }
    }
}
