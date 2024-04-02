using System;
class Menu
{
    public static void MenuFunc()
    {
        Console.Clear();
        Console.WriteLine("Escolha a opção da operação aritimética:\n1- Soma.\n2- Subtração.\n3- Divisão.\n4- Multiplicação.\n5- Potenciação.\n6- Radiciação\n7- Logaritimação\n8- Sair.\n");
        Console.Write("Digite o valor referente á opção: ");
        int opcao;
        while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 8)
        {
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida (1 a 8).\n");
            Console.Write("Digite o valor referente à opção: ");
        }
        switch (opcao)
        {
            case 1: Soma.SomaFunc(); break;
            case 2: Subtracao.SubFunc(); break;
            case 3: Divisao.DivFunc(); break;
            case 4: Multiplicacao.MultFunc(); break;
            case 5: Potenciacao.PotenciacaoFunc(); break;
            case 6: Radiciacao.RadiciacaoFunc(); break;
            case 7: Logaritimacao.LogFunc(); break;
            case 8: Finalizacao.FinalizacaoFunc(); System.Environment.Exit(0); break;
            default: MenuFunc(); break;
        }
    }
}