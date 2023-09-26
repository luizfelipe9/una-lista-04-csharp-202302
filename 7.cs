using System;

class Program
{
    static void Main()
    {
        int numerosPares = 0;
        int numerosImpares = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Digite o {i}º número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                numerosPares++;
            }
            else
            {
                numerosImpares++;
            }
        }

        Console.WriteLine($"Quantidade de números pares: {numerosPares}");
        Console.WriteLine($"Quantidade de números ímpares: {numerosImpares}");
    }
}
