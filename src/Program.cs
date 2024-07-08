namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average calc = new Average();
            Console.WriteLine("Você quer calcular a média de quantos números?");
            int quant = int.Parse(Console.ReadLine());
            int[] vetor = new int[quant];

            try
            {
                for (int i = 0; i >= 0; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número: ");
                    int n1 = int.Parse(Console.ReadLine());

                    if (i < quant)
                    {
                        vetor[i] = n1;
                    }
                    else
                    {
                        Console.WriteLine($"Número digitado {n1} ignorado. Limite do vetor alcançado.");
                    }

                    Console.WriteLine("Quer digitar mais um número? (s/n)");
                    Console.WriteLine($"Tamanho do vetor: {quant}");
                    Console.WriteLine($"Números digitados: {i + 1}");

                    string resposta = Console.ReadLine().ToUpper();
                    if (resposta == "S")
                    {
                        continue;
                    }
                    else if (resposta == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite um valor válido (S ou N)");
                        continue;
                    }
                }

                Console.WriteLine(calc.CalcularMedia(quant, vetor));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                Console.WriteLine("Ocorreu um erro ao acessar um índice fora dos limites do vetor.");
            }
        }
    }
}