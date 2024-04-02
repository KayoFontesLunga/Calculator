using System;


class Soma
{
    public static void SomaFunc()
    {
        Console.Clear();
        Console.Write("Primeiro valor: ");
        double v1;
        while (!double.TryParse(Console.ReadLine(), out v1))
        {
            Console.WriteLine("Valor inválido. Por favor, digite um valor válido.\n");
            Console.Write("Digite o valor válido: ");
        }

        Console.Write("\n");

        Console.Write("Segundo valor: ");
        double v2;
        while (!double.TryParse(Console.ReadLine(), out v2))
        {
            Console.WriteLine("Valor inválido. Por favor, digite um valor válido.\n");
            Console.Write("Digite o valor válido: ");
        }

        Console.Write("\n");

        Console.WriteLine($"O resultado da soma é: {v1 + v2}");

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Menu.MenuFunc();
    }
}