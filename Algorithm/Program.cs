using System;
using System.IO;
using System.Reflection;

namespace Algo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Selecione o algoritimo desejado: ");

      short counter = 1;
      
      try
      {
        foreach (string line in File.ReadLines("programs"))
        {
          Console.WriteLine($"[{counter}] {line}");
          counter++;
        }

        var response = Console.ReadLine();

        if (!short.TryParse(response, out short check) || check < 1 || check >= counter)
        {
          Console.WriteLine("Opição inválida!");
          System.Environment.Exit(1);
        }

        string algo = File.ReadLines("programs").Skip(check - 1).Take(1).First();
      
        MethodInfo? method = typeof(Program).GetMethod(algo, BindingFlags.Public | BindingFlags.Static);

        if(method != null)
        {
          method.Invoke(null, null);
        } 
        else
        {
          Console.WriteLine("Algoritimo não encontrado");
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Erro inesperado! {ex.Message}");
      }
    }

    public static void Sample()
    {
      Console.WriteLine("Hello world!");
    }
  }
}
