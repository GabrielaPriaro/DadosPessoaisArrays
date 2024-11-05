//Utilizando Arrays:
//Problema "dados_pessoas"
//Tem-se um conjunto de dados contendo a altura e o gênero (M, F) de N pessoas. Fazer um programa
//que calcule e escreva a maior e a menor altura do grupo, a média de altura das mulheres, e o número de homens. 

using System.Globalization;

namespace DadosPessoaisArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, quantMulheres = 0, quantHomens = 0;
            double somaAlturaMulheres = 0, mediaAlturaMulheres = 0;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double[] altura = new double[n];
            string[] genero = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Altura da {i + 1}a pessoa: ");
                altura[i] = double.Parse(Console.ReadLine(), CI);

                Console.Write($"Genero da {i + 1}a pessoa: ");
                genero[i] = Console.ReadLine();

                Console.WriteLine();
            }

            double menorAltura = altura[0];
            double maiorAltura = altura[0];

            for (int i = 0; i < n; i++)
            {
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
                if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (genero[i] == "F")
                {
                    quantMulheres++;
                    somaAlturaMulheres += altura[i];
                }
                else
                {
                    quantHomens++;
                }
            }

            if (quantMulheres > 0)
            {
                mediaAlturaMulheres = somaAlturaMulheres / quantMulheres;
            }

            Console.WriteLine($"Menor altura = {menorAltura.ToString("F2", CI)}");
            Console.WriteLine($"Maior altura = {maiorAltura.ToString("F2", CI)}");
            Console.WriteLine($"Media das alturas das mulheres = {mediaAlturaMulheres.ToString("F2", CI)}");
            Console.WriteLine($"Numero de homens = {quantHomens}");
        }
    }
}
