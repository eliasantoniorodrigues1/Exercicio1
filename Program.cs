using System;

class MainClass {
    public static void Main (string[] args) {
        // Declaração de variáveis
        int n1, n2, n3, n4, n5, Soma;
        Double Media;

        // Entrada de dados
        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o terceiro número: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite o quarto número: ");
        n4 = int.Parse(Console.ReadLine());
        Console.Write("Digite o quinto número: ");
        n5 = int.Parse(Console.ReadLine());

        Soma = n1 + n2 + n3 + n4 + n5;
        Media = Soma / 5;
        // Usando interpolação de variáveis
        Console.WriteLine($"O valor da soma é {Soma} e a média é {Media}");
        Console.ReadKey();

    }
}
