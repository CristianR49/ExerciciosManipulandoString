namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escreva uma frase, todas as primeiras letras de cada palavra serão convertidas para caixa alta");
                string frase = Console.ReadLine();
                string[] palavras = frase.Split(" ");

                string palavraPrimeiraLetraCaixaAlta = "";
                for (int i = 0; i < palavras.Length; i++)
                {
                    string palavraComALetraQueViraraCaixaAlta = palavras[i];



                    for (int j = 0; j < palavraComALetraQueViraraCaixaAlta.Length; j++)
                    {
                        if (j == 0)
                        {
                            palavraPrimeiraLetraCaixaAlta += Convert.ToString(palavraComALetraQueViraraCaixaAlta[j]).ToUpper();
                        }
                        else
                        {
                            palavraPrimeiraLetraCaixaAlta += Convert.ToString(palavraComALetraQueViraraCaixaAlta[j]);
                        }
                    }
                    palavraPrimeiraLetraCaixaAlta += " ";
                }
                Console.WriteLine(palavraPrimeiraLetraCaixaAlta);
                Console.ReadLine();
            }
        }
    }
}