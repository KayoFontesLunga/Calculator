using System;
class Radiciacao
{
    public static void RadiciacaoFunc()
    {
        Console.Clear();
        Console.Write("Digite o valor: ");
        double valor;
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Valor inválido. Por favor, digite um valor válido.\n");
            Console.Write("Digite o valor base novamente: ");
        }
        double result = Math.Sqrt(valor);
        Console.WriteLine($"\nA raiz quadrada de {valor} é {result}");

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Menu.MenuFunc();
    }
}