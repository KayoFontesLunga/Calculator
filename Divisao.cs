using System;
class Divisao
{
    public static void DivFunc()
    {
        Console.Clear();
        Console.Write("Digite o primerio valor: ");
        double v1;
        while (!double.TryParse(Console.ReadLine(), out v1))
        {
            Console.WriteLine("Opção inválido. Por favor, digite um valor válido.\n");
            Console.Write("Digite o valor válido: ");
        }

        Console.Write("\n");

        Console.Write("Digite o segundo valor: ");
        double v2;
        while (!double.TryParse(Console.ReadLine(), out v2) || v2 == 0)
        {
            Console.WriteLine("Valor inválido ou divisão por 0. Por favor, digite um valor válido.\n");
            Console.Write("Digite o valor válido: ");
        }

        Console.Write("\n");

        Console.WriteLine($"O resultado da divisão é: {v1 / v2}");

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Menu.MenuFunc();
    }

}