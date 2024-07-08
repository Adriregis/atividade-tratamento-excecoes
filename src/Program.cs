class Program
{
    static void Main()
    {
        Average avgCalculator = new Average();

        int[] numeros = { 10, 20, 30 };
        try
        {
            int media = avgCalculator.CalcularMedia(numeros.Length, numeros);
            Console.WriteLine($"A média é: {media}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao calcular a média: {ex.Message}");
        }

        int[] numerosVazios = { };
        try
        {
            int mediaVazia = avgCalculator.CalcularMedia(0, numerosVazios);
            Console.WriteLine($"A média é: {mediaVazia}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao calcular a média: {ex.Message}");
        }

        int[] numerosNulos = null;
        try
        {
            int mediaNula = avgCalculator.CalcularMedia(1, numerosNulos);
            Console.WriteLine($"A média é: {mediaNula}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao calcular a média: {ex.Message}");
        }
    }
}