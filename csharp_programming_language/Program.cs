// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace CsharpProgrammingLanguage{
    class Program{
        static void Main(string[] args){
            
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
           
            if(sampleNull != null){
                Console.WriteLine($"sampleNull não é mais nula: {sampleNull}.");
            } else {
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
        }
    }
}


