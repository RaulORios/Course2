﻿using System;
using System.Globalization;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {

            //___________________________________________________________________________________________//

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //string[] s = Console.ReadLine().Split(' ');
            //string a = s[0];
            //string b = s[1];
            //string c = s[2];

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //___________________________________________________________________________________________//

            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            //Console.WriteLine("VocÊ digitou: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));

            //___________________________________________________________________________________________//


            string nome = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu nome completo: ");
            Console.WriteLine(nome);
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            Console.WriteLine(n);
            Console.WriteLine("Entre com o preço do produto: ");
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Entre com seu ultimo nome, idade e altura");
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();

        }
    }
}
