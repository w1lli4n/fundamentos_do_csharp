// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace CsharpProgrammingLanguage
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variaveis

            int idadeDoGuri; // Estilo de declaração em C, além de utilizar camelCase :)
            idadeDoGuri = 19;
            var alturaDoGuri = 165;
            // var ano; // Errado. var pode-se apenas ser inicializada pois a mesma é inferida.
            Console.WriteLine($"Idade: {idadeDoGuri} Altura: {alturaDoGuri}.");

            // Constantes

            /// Dan Marino
            const int THE_YEAR = 1984;  // Por hora bem similar ao C

            Console.WriteLine($"The Year: {THE_YEAR}.");

            // Tipos primitivos

            // Byte

            byte sampleByte = 0b10011001;  // Um byte normal. Normalmente não é declarado assim (obvio)
            sbyte sampleSbyte = -0xF;    // O sbyte é um signed byte. Bytes podem também ser representados por decimais e hexadecimais, assim como qualquer outro inteiro

            Console.WriteLine($"Um byte binario {sampleByte} e uma byte hexadecimal {sampleSbyte}.");

            // inteiros

            short sampleShort = 16; // Inteiros de C, porém simplificados. Vantagens de ser uma linguagem pós 32 bit.
            uint sampleInt = 32;
            long sampleLong = 64;

            Console.WriteLine($"short é um inteiro de {sampleShort} bit. int é um inteiro de {sampleInt} bit. long é um inteiro de {sampleLong} bit. Podem ser unsigned :)");

            // reais

            float sampleFloat = 32f;
            double sampleDouble = 64;
            decimal sampleDecimal = 128m;

            Console.WriteLine($"float é um número real de {sampleFloat} bit. double é um número real de {sampleDouble} bit. decimal é um número real de {sampleDecimal} bit. Um inteiro não pode ser inferido para um float ou decimal, apenas para o double (o número real padrão).");

            // booleano

            bool sampleBool = true; // armazenado em 8 bit;

            Console.WriteLine($"bool == true ? {sampleBool} : {!sampleBool}.");

            // char

            char sampleChar = 'C';

            Console.WriteLine($"char é um caracter unicode de 16 bits. Segue a sintaxe do {sampleChar} :)");

            // string

            string sampleString = "Um array de char";   // Será que funciona igual a de C?

            Console.WriteLine($"{sampleString}. Necessário ver detalhes de implementação.");

            // var

            var sampleVar = "permite a inferencia do tipo em tempo de compilação";

            Console.WriteLine($"var {sampleVar}. Útil.");

            // objects

            object sampleObject = "generic";    // um generic definido em tempo de execução

            Console.WriteLine($"object é um {sampleObject}.");

            // nullable

            string? sampleNull = null;  // a interrogação adciona a a caraterisca de nulavel ao tipo

            Console.WriteLine($"sampleNull está nula: {sampleNull}");
            sampleNull = "NotNull";

            if (sampleNull != null)
            {
                Console.WriteLine($"sampleNull não é mais nula: {sampleNull}.");
            }
            else
            {
                Console.WriteLine("Null.");
            }

            // alias

            /*
                os tipos usados até aqui são apenas alias.
                int = Int32,
                long = Int64,
                string = System.String,
                e assim por diante...
            */

            // valores padrão

            /*
                todos os build in type possuem um valor padrão.
                Numeros = 0,
                bool = false,
                char = '\0',
                string = "",
                object = null
            */

            // conversão implícita

            sampleFloat = sampleLong;    // Tudo dentro dos conformes. Float contém Int

            Console.WriteLine($"Agora sampleFloat é {sampleFloat}.");

            /* No geral, é possível fazer qualquer cast de inteiros do C de forma implícita */

            // Conversão explícita

            sampleInt = (uint)sampleShort;

            // sampleInt é unsigned, logo é necessário fazer um cast explicito em tempo de execução
            // Conversão explícita truca números inteiros

            Console.WriteLine($"sampleInt agora é {sampleInt}.");

            // Parse

            /* Converte uma string ou char para um outro tipo. Verifícado em tempo de execução */

            int sampleIntParse = int.Parse("255");

            Console.WriteLine($"sampleIntParse é 0x{sampleIntParse:X} e veio da string 255.");

            // Convert

            bool sampleConvertBool = Convert.ToBoolean("True");

            Console.WriteLine($"sampleConvertBool veio da string \"True\", porém agora é {!sampleConvertBool}.");

            // Convert arredonda números inteiros

            // Operadores

            // Operadores aritimeticos

            /* 
                soma (+),
                subtração (-),
                multiplicação (*),
                divisão (/)
            */

            // Podem ser utilizados com qualquer número. Divisões reais com resultados inteiros serão arredondados. Matematica :)

            // Operadores de atribuição

            /*
                igual ( x = y),
                mais igual ( x += y || x = x + y),
                menos igual ( x -= y),
                multiplicado igual ( x *= y),
                dividido igual ( x /= y)
            */

            // Operadores de comparação

            // sempre retorna um booleano
            /*
                igual (==),
                diferente (!=),
                maior-que (>),
                menor-que (<),
                maior-ou-igual-que (>=),
                menor-ou-igual-que (<=),
            */

            // Operadores lógicos

            /*
                E (&&),
                Ou (||),
                Negação (!)
            */

            // Switch case. Basicamente o de C

            int sampleSwitch = 1;

            switch (sampleSwitch)
            {
                case 1:
                    Console.WriteLine(true);
                    break;
                case 2:
                    Console.WriteLine(false);
                    break;
                default:
                    Console.WriteLine("maybe");
                    break;
            }

            // Laços de repetição

            // For

            for (int i = 0; i < 5; i++)
            {
                System.Console.Write("+");
                for (int j = 5; j > 0; j--)
                {
                    System.Console.Write("*");
                }
            }

            // while

            bool check = true;
            while (check)
            {
                System.Console.WriteLine("true");
                check = false;
            }

            // do while

            do
            {
                System.Console.WriteLine("true?");
            } while (check);
            
            // Funções ou Métodos (POO!)

            /*
                Não pode existir métodos dentro de métodos em C#
            */

            sampleMethod("Hello world?");

            System.Console.WriteLine(fullName("Alves", "Willian", "dos Santos Almeida"));
            System.Console.WriteLine(fullName("Borges", "Gabriela"));

            // Value & references

            /*
                Todos os build in types são value types. Povoam a memória stack e são copiaveis.
                Demais tipos, como arrays e objetos povoam a memória heap e apenas copiam a referência.
            */
            int x = 25;
            int y = x;  // y é uma cópia de x, as duas variaveis são independentes

            var arr = new string[2];
            arr[0] = "ABC";
            var arr2 = arr; // arr2 é apenas uma referencia de arr
            System.Console.WriteLine($"{arr[0]} e {arr2[0]}");

            arr2[0] = "CBA";    // Uma alteração em qualquer um dos dois irá alterar o outro. Ambos apontam para o mesmo espaço de memória.
            System.Console.WriteLine($"{arr[0]} e {arr2[0]}");

            // Structs

            var mouse = new Product(1, "Mouse Gamer", 400, EImportado.Nacional);

            System.Console.WriteLine($"Id do produto {mouse.Id}\nNome do produto: {mouse.Title}\nPreço do produto: R${mouse.Price:0.##}\nPreço em dolar: ${mouse.PriceInDolar(5.70):0.##}\nOrigem: {mouse.Origem}");

        }

        static void sampleMethod(string parametro)
        {
            System.Console.WriteLine(parametro);
        }

        static string fullName(string lastName, string name, string middleName = "")
        {
            return $"{name} {middleName} {lastName}";
        }
    }

    struct Product
    {
        public Product(int id, string title, double price, EImportado origem)
        {
            Id = id;
            Title = title;
            Price = price;
            Origem = origem;
        }

        public int Id;
        public string Title;
        public double Price;
        public EImportado Origem;

        public double PriceInDolar(double dolar)
        {
            return Price / dolar;
        }
    }

    enum EImportado {   // enums de c# não são como as de rust, ou pelo menos não parece que são :(
        Nacional = 1,
        Importado = 2,
    }
}
