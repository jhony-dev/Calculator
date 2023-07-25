using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divição \n");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            switch (operacao)
            {
                case 1:
                    {
                        result = Adicao(num1, num2);
                        break;
                    }

                case 2:
                    {
                        result = Subtracao(num1, num2);
                        break;
                    }

                case 3:
                    {
                        result = Multiplicacao(num1, num2);
                        break;
                    }

                case 4:
                    {
                        result = Divisao(num1, num2);
                        break;
                    }
                default:
                    Console.WriteLine("Número invalido!");
                    break;
            }

            Console.WriteLine("O resultado da operação com os números {0} + {1} = {2}", num1, num2, result);
            Console.ReadLine();
        }



        public static int Adicao(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }
        public static int Subtracao(int n1, int n2)
        {
            int result = n1 - n2;
            return result;
        }
        public static int Multiplicacao(int n1, int n2)
        {
            int result = n1 * n2;
            return result;
        }
        public static int Divisao(int n1, int n2)
        {
            int result = n1 / n2;
            return result;
        }
    }
    }
}
