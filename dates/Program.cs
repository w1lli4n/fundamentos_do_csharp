using System;
using System.Globalization;

namespace Dates
{
  class Program
  {
    static void Main(string[] args)
    {
      // DateTime é um struct para utilizar datas no dotnet
      // Inicia em 0001/01/01, 00:00
      var date = new DateTime();

      // Now passa a data e horario atual
      var currentDate = DateTime.Now;

      Console.WriteLine($"DateTime: {date}; DateTime.Now: {currentDate}");

      // Pode-se também passar uma data especifica
      var specialDate = new DateTime(2022, 7, 11, 18, 0, 0, 0);

      Console.WriteLine($"A special date, {specialDate.DayOfWeek}: {specialDate}"); // Alguns métodos

      var formatedDate = new DateTime();

      // String.Format nos da diversar opções para a formatação de datas
      Console.WriteLine($"{String.Format("{0:dd/MM/yy}", formatedDate)}");

      Console.WriteLine($"{String.Format("{0:t}", formatedDate)}"); // shortcut para tempo
      Console.WriteLine($"{String.Format("{0:d}", formatedDate)}"); // shortcut para data
      Console.WriteLine($"{String.Format("{0:r}", formatedDate)}"); // shortcut para data padrão
      Console.WriteLine($"{String.Format("{0:u}", formatedDate)}"); // shortcut para universal

      Console.WriteLine($"{String.Format("{0:r}", specialDate.AddDays(-3))}"); // Add*, adiciona a quantidade a data.

      var nowDate = DateTime.Now;

      if (nowDate == DateTime.Now)
      {
        Console.WriteLine("Nunca serei exibido :(");
      }
      else if (nowDate.Date == DateTime.Now.Date)
      {
        Console.WriteLine("DateTime abriga até mesmo milisegundos!");
      }

      // Pode-se utilizar o próprio sistema operacional para formatar correntamente as datas

      var pt = new CultureInfo("pt-PT");
      var de = new CultureInfo("de-DE");
      var currentCulture = CultureInfo.CurrentCulture;

      Console.WriteLine($"{specialDate.ToString("d", pt)}, {specialDate.ToString("d", de)}, {specialDate.ToString("d", currentCulture)}");

      var timeSpan = new TimeSpan();
      Console.WriteLine(timeSpan);
      
      var otherTimeSpan = new TimeSpan(1, 3, 7);
      Console.WriteLine(otherTimeSpan);

      var milisecondTimeSpan = new TimeSpan(1);
      Console.WriteLine(milisecondTimeSpan);

      Console.WriteLine(otherTimeSpan - milisecondTimeSpan);  // TimeSpan facilita a matematica com horas
    
      Console.WriteLine(DateTime.DaysInMounth(2004, 2));  // Mostra quantos dias teve fevereiro em 2004
    }
  }
}
