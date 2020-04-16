using System;

namespace UsandoTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("------Menu Mudança de Cor------");

            opcao = 0;
            do
            {

                Console.WriteLine("1 - Primeira Cor");
                Console.WriteLine("2 - Segunda Cor");
                Console.WriteLine("3 - Terceira Cor");
                Console.WriteLine("4 - Quarta Cor");
                Console.WriteLine("5 - Finalizar");
                Console.WriteLine("\n Digite a opção de cor desejada: ");
                opcao++;
                opcao = Convert.ToInt32(Console.ReadLine());
                
                switch (opcao)
                {
                   
                       
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Voce selecionou opção {opcao}");
                        Console.WriteLine("Sua Cor de Fundo é Cyan, e de frente Black!");
                        Console.ResetColor();
                        Console.WriteLine("\n Digite outra opção: ");
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Voce selecionou opção {opcao}");
                        Console.WriteLine("Sua Cor de Fundo é Green, e de frente Black!");
                        Console.ResetColor();
                        Console.WriteLine("\n Digite outra opção: ");
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Voce selecionou opção {opcao}");
                        Console.WriteLine("Sua Cor de Fundo é Yellow, e de frente Black!");
                        Console.ResetColor();
                        Console.WriteLine("\n Digite outra opção: ");
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Voce selecionou opção {opcao}");
                        Console.WriteLine("Sua Cor de Fundo é Blue, e de frente Black!");
                        Console.ResetColor();
                        Console.WriteLine("\n Digite outra opção: ");
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Voce selecionou opção Finalizar.Tchau!");
                        Console.ResetColor();
                        break;
                    default:
                        try
                        {
                            opcao = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Voce selecionou uma opção inválida");
                            Console.WriteLine("Apenas números são permitidos!");
                            Console.WriteLine("E que estejam entre 1 e 5. \n ");
                            Console.ResetColor();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Somente números meu senhor!");
                        }
                        
                        break;
                }
                

            } while (opcao < 5 || opcao > 5);
            Console.ReadKey();

        }
    }
}
