namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escreva uma frase, as letras serão trocadas por outra do alfabeto X posições a frente");
                Console.Write("Frase: ");
                string frase = Console.ReadLine();
                Console.Write("quantidade de posições a frente: ");
                int posicoesAFrente = Convert.ToInt32(Console.ReadLine());
                string fraseAlterada = "";
                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == ' ')
                    {
                        fraseAlterada += " ";
                    }
                    else
                    fraseAlterada += (char)(frase[i] + posicoesAFrente);
                }
                Console.WriteLine(fraseAlterada);

                Console.ReadLine();

            }
        }
    }
}