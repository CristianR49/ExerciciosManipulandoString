namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escreva uma frase, será realizada operações de processamento de texto para essa frase");
                Console.Write("Frase:");
                string frase = Console.ReadLine();
                string fraseLetrasMaiusculas = "";
                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == ' ')
                    {
                        fraseLetrasMaiusculas += " ";
                    }
                    else
                        fraseLetrasMaiusculas += Convert.ToString(frase[i]).ToUpper();
                }
                Console.WriteLine("\n" + fraseLetrasMaiusculas);

                string fraseLetrasMinusculas = "";
                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == ' ')
                    {
                        fraseLetrasMinusculas += " ";
                    }
                    else
                        fraseLetrasMinusculas += Convert.ToString(frase[i]).ToLower();
                }
                Console.WriteLine("\n" + fraseLetrasMinusculas);

                int quantidadeDeCaracteres = 0;
                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] != ' ')
                    {
                        quantidadeDeCaracteres++;
                    }
                }
                Console.WriteLine("\nhá " + quantidadeDeCaracteres + " caracteres");

                string[] palavrasSeparadas = frase.Split(' ');
                Console.WriteLine("\na primeira palavra é \"" + palavrasSeparadas[0] + "\"");

                Console.WriteLine("\na última palavra é \"" + palavrasSeparadas[palavrasSeparadas.Length - 1] + "\"");
                Console.ReadLine();
            }
        }
    }
}