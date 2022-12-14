using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calculadora simples
             
            //obetendo dado de entrada 

            Inicio:
            Console.Clear();

            Console.Write("Digite o primeiro numero para operacao matematica ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero para operacao matematica ");
            double num2 = double.Parse(Console.ReadLine());
            

            Console.Write("\nescolha a operação (+ , - , x ou / : ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;
            // calculos
            switch (op) 
            {
                default:
                    Console.WriteLine("operando inválido");
                    Console.ReadKey();
                    goto Inicio;

                case '+': 
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é " + resultado);
                    break;
                case 'x':
                case 'X':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é " + resultado);
                    break;
                case '/':
                case ':':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por zero");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é " + resultado);
                    }
                    break;
                    
            }
            Console.WriteLine("Continuar calculando ? ( S ou N ) ");
            string opcao = Console.ReadLine();
            if (opcao == "S" || opcao == "s")
            { 
                goto Inicio;

                
            }
            
            Console.ReadKey();

        }
    }
}
