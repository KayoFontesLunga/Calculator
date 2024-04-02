using System;

class Potenciacao
{
    public static void PotenciacaoFunc()
    {
        Console.Clear();
        Console.Write("Digite o valor base: ");
        double valorBase;
        while (!double.TryParse(Console.ReadLine(), out valorBase))
        {
            Console.WriteLine("Valor inválido. Por favor, digite um valor válido.\n");
            Console.Write("Digite o valor base novamente: ");
        }

        Console.Write("\n");

        Console.Write("Digite o expoente: ");
        double valorExpoent;
        while (!double.TryParse(Console.ReadLine(), out valorExpoent))
        {
            Console.WriteLine("Valor inválido. Por favor, digite um valor válido.\n");
            Console.Write("Digite o expoente novamente: ");
        }

        Console.Write("\n");
        double result = Math.Pow(valorBase, valorExpoent);
        Console.WriteLine($"{valorBase} elevado a {valorExpoent} = {result}");

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Menu.MenuFunc();
    }
}