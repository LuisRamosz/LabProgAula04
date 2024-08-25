// Desenvolva um jogo de adivinhação onde o programa gera um número aleatório entre 1 e 100, e o usuário tenta adivinhar. Use um laço while para continuar pedindo palpites até que o usuário acerte.

using System;

class Adivinhacao
{
    static void Jogo()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int palpite = 0;
        int tentativas = 0;

        Console.WriteLine("Tente adivinhar o número: ");

        while (palpite != numeroAleatorio)
        {
            tentativas ++;

            Console.WriteLine("Digite seu palpite: ");
            palpite = Convert.ToInt32(Console.ReadLine());

            if (palpite > numeroAleatorio)
            {
                Console.WriteLine($"Palpite muito alto, tente novamente");
            }
            else if (palpite < numeroAleatorio)
            {
                Console.WriteLine($"Palpite muito baixo, tente novamente");
            }
            else 
            {
                Console.WriteLine($"Você acertou, em {tentativas} tentativas");
            }

        }

    }

}
