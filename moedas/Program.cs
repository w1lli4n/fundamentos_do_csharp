using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        // decimal é o ideal paara moedas
        decimal valor = 112939.997m;

        Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))); // C de currency. Ele arredonda quando o valor passa de três casa decimais

        Console.WriteLine($"valor real: {valor}; valor arredondado: {Math.Round(valor)}; valor arredondado pra cima: {Math.Ceiling(valor)}; valor arredondado pra baixo: {Math.Floor(valor)}");
    }
}