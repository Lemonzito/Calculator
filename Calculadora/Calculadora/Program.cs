using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Calculadora";
            Console.WriteLine("***************************************Calculadora***************************************");

            double num1 = 0, num2 = 0, prod, num;
            string operador, valorEscolhido;
            bool isNumeroInteiro;

            Console.WriteLine("Digite o primeiro valor:");
            valorEscolhido= Console.ReadLine();

            isNumeroInteiro = double.TryParse(valorEscolhido, out num);
            if (isNumeroInteiro)
            {
                num1 = Math.Round(double.Parse(valorEscolhido), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido:");
            }

            Console.WriteLine("Digite a operação (' / | + | * | - | %(MOD)'):");
            operador = Console.ReadLine();

            Console.WriteLine("Digite o segundo valor:");
            valorEscolhido = Console.ReadLine();

            isNumeroInteiro = double.TryParse(valorEscolhido, out num);
            if (isNumeroInteiro)
            {
                num2 = Math.Round(double.Parse(valorEscolhido), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido:");
            }

            switch (operador)
            {
                case "+":
                    prod = Math.Round(num1 + num2, 4);
                    Console.WriteLine($"{ num1 } { '+' } { num2 } = {prod}");
                    break;
                case "-":
                    prod = Math.Round(num1 - num2, 4);
                    Console.WriteLine($"{ num1 } { '-' } { num2 } = {prod}");
                    break;
                case "*":
                    prod = Math.Round(num1 * num2, 4);
                    Console.WriteLine($"{ num1 } { '*' } { num2 } = {prod}");
                    break;
                case "/":
                    prod = Math.Round(num1 / num2, 4);
                    Console.WriteLine($"{num1} { '/' } {num2} = {prod}");
                    break;
                case "%":
                    prod = Math.Round(num1 % num2, 4);
                    Console.WriteLine($"{ num1 } { '%' } { num2 } = {prod}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida");
                    break;
            }

            Console.ReadKey();


        }
    }
    
}