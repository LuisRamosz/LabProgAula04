using System;

class Calculadora
{
    static void Menu() //static = estático   void = não retorna nada
    {
        Console.WriteLine("Informe a operação desejada");
        Console.WriteLine("1- Adição");
        Console.WriteLine("2- Subtração");
        Console.WriteLine("3- Multiplicação");
        Console.WriteLine("4- Divisão");

        Console.WriteLine("Digite a operação escolhida: ");
        int escolha = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o número 1:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o número 2:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado;

        switch (escolha)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"O resultado da soma é: {resultado}");
                break;

            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"O resultado da subtração é: {resultado}");
                break;

            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                break;

            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"O resultado da divisão é: {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Não é possível dividir por 0");
                }
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}