namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escreva uma frase, será contado o número de palavras");
                string frase = (Console.ReadLine()).Trim();
                string[] palavras = frase.Split(" ");
                Console.WriteLine("há " + palavras.Length + " palavras");
                Console.ReadLine();
            }
        }
    }
}