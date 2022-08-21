using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}

    internal class Program
    {
        static void Main(string[] args)
        {

            bool escolheuSair = false; //Enquanto o usuário NÃO(!) ESCOLHER SAIR EXIBA O MENU

            while (!escolheuSair)
            {

                Console.WriteLine("Bem Vindo ao Calculator, selecione uma das opções abaixo:\n");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Divi();
                        break;
                    case Menu.Multiplicacao:
                        Multi();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                
                Console.Clear();
            }    

        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}"); //O $ + o {resultado} é o mesmo que concatenar (+ resultado)
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}"); //O $ + o {resultado} é o mesmo que concatenar (+ resultado)
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Divi()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a /(float) b;
            Console.WriteLine($"O resultado é: {resultado}"); //O $ + o {resultado} é o mesmo que concatenar (+ resultado)
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Multi()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}"); //O $ + o {resultado} é o mesmo que concatenar (+ resultado)
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de um número: ");
            Console.WriteLine("Digite o número base: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número expoente: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(a , b);
            Console.WriteLine($"O resultado é: {resultado}"); //O $ + o {resultado} é o mesmo que concatenar (+ resultado)
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um número: ");
            Console.WriteLine("Digite o número base: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a); //Square Root
            Console.WriteLine($"O resultado é: {resultado}"); //O $ + o {resultado} é o mesmo que concatenar (+ resultado)
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}
