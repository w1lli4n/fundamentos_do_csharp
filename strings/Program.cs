using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // guid

            var id = Guid.NewGuid();
            id.ToString();

            /*
                Um inteiro de 128 bits, pseudo-aleatório e muito dificilmente haverá colisões no mesmo sistema.
            */

            Console.WriteLine(id);

            // interpolação de string

            int sampleRandomNumber = 127;
            string sampleRandomText = "The number is ";

            Console.WriteLine(sampleRandomText + sampleRandomNumber);   // Uma forma de interpolar
            
            var sampleStringFormat = string.Format("The number was {0} and now is {1}", sampleRandomNumber, sampleRandomNumber + 1);    // printf?
            Console.WriteLine(sampleStringFormat);

            Console.WriteLine($@"{sampleRandomText}
            {sampleRandomNumber}");  // a minha forma preferida

            // comparação de strings

            Console.WriteLine(sampleRandomText.CompareTo(sampleRandomText));    // strcmp. retorna 0
            Console.WriteLine(sampleRandomText.CompareTo("number"));    // strcmp. retorna 1

            Console.WriteLine($"the text contains the word 'number'? {sampleRandomText.Contains("number")}");  // retorna True
            Console.WriteLine($"the text contains the word 'Number', ignoring letters case? {sampleRandomText.Contains("Number", StringComparison.OrdinalIgnoreCase)}");  // retorna True

            // starts & ends

            Console.WriteLine($"the text starts with 'The'? {sampleRandomText.StartsWith("The")}");   // retorna True
            Console.WriteLine($"the text ends with 'is '? {sampleRandomText.EndsWith("is ")}");   // retorna True

            // Equals

            Console.WriteLine($"the text '{sampleRandomText}' is equals the text '{sampleRandomText}'? {sampleRandomText.Equals(sampleRandomText)}");   // equals compara qualquer objeto, não apenas strings   

            // indicies

            Console.WriteLine(sampleRandomText.IndexOf('m'));   // retorna o indicie do primeiro elemento igual
            Console.WriteLine(sampleRandomText.LastIndexOf('e'));   // retorna o indicie do último elemento igual
            Console.WriteLine(sampleRandomText.IndexOf('z'));   // retornar -1 se não houver

            // outros métodos

            Console.WriteLine($"to upper {sampleRandomText.ToUpper()} to lower: {sampleRandomText.ToLower()}");

            Console.WriteLine(sampleRandomText.Insert(0, "error ")); // não modifica a string
             Console.WriteLine(sampleRandomText.Remove(0, 4));   // também não modifica a string
            Console.WriteLine(sampleRandomText.Length);

            // replace, split, substring, trim

            /*
                replace: Modifcia uma string por outra,
                split: Divide a string em um array de strings utilizando como parametro de separação uma string,
                substring: uma nova string que começa em um indicie e termina e outro indicie
                trim: remove os espaços do começo e final da string
            */

            Console.WriteLine(sampleRandomText.Replace("T", "0"));  // Não modifica a string
            
            var splitedText = sampleRandomText.Split(" ");  // Não modifica a string
            Console.WriteLine(splitedText[0]);

            Console.WriteLine(sampleRandomText.Substring(0, sampleRandomText.LastIndexOf('m'))); // Não modifica a string
            
            string notTrimmedString = " a b c ";
            Console.WriteLine(notTrimmedString.Trim()); // Não modifica a string

            // string builder

            var texto = new StringBuilder();    // Um construtor de string. Desta forma, sempre que a string for alterada, não será criada uma nova cópia em memória.

            texto.Append("The first line\n");
            texto.Append("The second line\n");
            texto.Append("The thirdy line");

            Console.WriteLine(texto);
        }
    }
}