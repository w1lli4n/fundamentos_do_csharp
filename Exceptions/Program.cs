using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3 };

        try // Se ocorrer um erro dentro do bloco try, o programa muda seu curso para o bloco catch que possuir correspondecia
        {
            /*for (short i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }*/

            Salvar("");
        }
        catch (IndexOutOfRangeException ex)    // ex é do tipo exception, uma excessão generica, existem especificos como o IndexOutOfRangeException
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (MinhaException ex)
        {
            Console.WriteLine("error");
            Console.WriteLine(ex.QuandoAconteceu);
        }
        catch
        {
            Console.WriteLine(":(");
        }
        finally     // Após a excessão, o programa se volta para o bloco finally
        {
            Console.WriteLine("Sempre serei executado");
        }

    }

    private static void Salvar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            // throw new Exception("O texto não pode ser vazio");   // generico
            throw new MinhaException(DateTime.Now);
        }
    }

    public class MinhaException : Exception
    {
        public MinhaException (DateTime time)
        {
            QuandoAconteceu = time;
        }

        public DateTime QuandoAconteceu { get; set; }
    }
}