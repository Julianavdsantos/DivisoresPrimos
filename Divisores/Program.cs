using System;
using System.Collections.Generic;

public class Divisores
{
    public List<int> CalculoDoDivisor(int numero)
    {
        List<int> divisores = new List<int>();

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores.Add(i);
            }
        }

        return divisores;
    }

    public List<int> CalcularPrimos(int numero)
    {
        List<int> divisoresPrimos = new List<int>();
        List<int> divisores = CalculoDoDivisor(numero);

        foreach (int divisor in divisores)
        {
            if (Primo(divisor))
            {
                divisoresPrimos.Add(divisor);
            }
        }

        return divisoresPrimos;
    }

    private bool Primo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Informe um Numero ");
        int numero = int.Parse(Console.ReadLine());

        Divisores divisorCalculator = new Divisores();

        List<int> divisores = divisorCalculator.CalculoDoDivisor(numero);
        List<int> divisoresPrimos = divisorCalculator.CalcularPrimos(numero);

        Console.WriteLine("Divisores: " + string.Join(", ", divisores));
        Console.WriteLine("Divisores Primos: " + string.Join(", ", divisoresPrimos));
    }
}
