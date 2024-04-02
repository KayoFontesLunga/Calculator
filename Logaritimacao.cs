using System;
class Logaritimacao
{
    public static void LogFunc()
    {
        Console.Clear();
        Console.WriteLine("1- Logaritimo na base 10.");
        Console.WriteLine("2- Logaritimo natural(base e).");
        Console.WriteLine("3- Logaritimo em base personalizada.");
        Console.Write("\nEscolha uma opção (1/2/3): ");
        int opcao;
        while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
        {
            Console.WriteLine("\nOpção invalida. Porfavor escolha 1, 2 oui 3");
            Console.Write("\nEscolha uma opção (1/2/3): ");
        }
        Console.Write("\nDigite um valor para calcular o logaritimo: ");
        double valor;
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Valor inválido. Por favor, digite um valor válido.\n");
            Console.Write("Digite o valor novamente: ");
        }
        double result = 0;
        switch (opcao)
        {
            case 1:
                result = Math.Log10(valor);
                Console.WriteLine($"\nO logaritimo na base 10 de {valor} é {result}"); break;
            case 2:
                result = Math.Log(valor);
                Console.WriteLine($"\nO logaritimo natural de {valor} é {result}"); break;
            case 3:
                Console.WriteLine("\nDigite a base pra calcular o logaritimo: ");
                double baseLog;
                while (!double.TryParse(Console.ReadLine(), out baseLog))
                {
                    Console.WriteLine("\nBase inválida. Por favor, digite um valor positivo para a base.\n");
                    Console.Write("\nDigite a base novamente: ");
                }
                result = Math.Log(valor, baseLog);
                Console.WriteLine($"\nO logaritimo na base {baseLog} de {valor} é {result}");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Menu.MenuFunc();
    }
}