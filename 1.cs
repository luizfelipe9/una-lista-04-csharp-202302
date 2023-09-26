using System;

class Program
{
    static void Main()
    {
        double nota;

        do
        {
            Console.Write("Digite uma nota entre 0 e 10: ");
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Valor inválido. A nota deve estar entre 0 e 10.");
            }
        } while (nota < 0 || nota > 10);

        Console.WriteLine($"Você digitou a nota {nota}. Obrigado!");
    }
}
