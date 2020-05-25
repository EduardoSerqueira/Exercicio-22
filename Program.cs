using System;

namespace Exercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite uma sequencia numérica: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = Convert.ToInt32(values[j]);
                }
            }

            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
