namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Será lido o arquivo cidades.csv e apresentado as cidades agrupadas pela primeira letra ou pelo estado que pertence.");
                Console.WriteLine("(1) - Pela primeira letra\n(2) - Pelo estado\nSelecione como será agrupado:");
                string opcaoDeAgrupamento = Console.ReadLine();
                string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string municipios = File.ReadAllText(@"C:\Users\crist\source\repos\ExerciciosManipulandoString\Exercicio06\cidades.csv");
                string municipiosLegendaRemovida = municipios.Remove(0, 59);
                string[] municipiosSeparados = municipiosLegendaRemovida.Split("\n");

                //agrupando pela letra
                if (opcaoDeAgrupamento == "1")
                {
                    for (int i = 0; i < alfabeto.Length; i++)
                    {
                        Console.WriteLine("\n" +
                            "\n" + alfabeto[i] + ":");
                        for (int j = 1; j < municipiosSeparados.Length; j++)
                        {
                            string[] InfosDosMunicipiosSeparadas = municipiosSeparados[j].Split(";");
                            int posicaoDaLetraDoAlfabetoEm = InfosDosMunicipiosSeparadas[2].IndexOf(alfabeto[i], StringComparison.OrdinalIgnoreCase);
                            if (posicaoDaLetraDoAlfabetoEm == 0)
                            {
                                Console.Write(InfosDosMunicipiosSeparadas[2]);
                                if (j != municipiosSeparados.Length - 1)
                                {
                                    Console.Write(", ");
                                }
                            }
                        }
                    }
                    
                }
                //agrupado pelo estado a que pertence
                if (opcaoDeAgrupamento == "2")
                {
                    for (int i = 1; i < municipiosSeparados.Length; i++)
                    {
                        string[] InfosDosMunicipiosSeparadas = municipiosSeparados[i].Split(";");
                        string estadoAComparar;
                        if (InfosDosMunicipiosSeparadas[3] != "")
                        {
                            estadoAComparar = InfosDosMunicipiosSeparadas[3];
                            Console.WriteLine("\n\n" + estadoAComparar.Trim() + ": "); ;
                            for (int j = 1; j < municipiosSeparados.Length; j++)
                            {

                                InfosDosMunicipiosSeparadas = municipiosSeparados[j].Split(";");
                                if (estadoAComparar == InfosDosMunicipiosSeparadas[3])
                                {
                                    Console.Write(InfosDosMunicipiosSeparadas[2] + ", ");
                                    municipiosSeparados[j] = ";;;;;;";


                                }
                            }
                        }
                    }
                }
                Console.ReadLine();
            }
            //1º; 3550308; São Paulo; São Paulo; 12 396 372

            /*agrupado pelo estado que pertence;
        1º; 3550308; São Paulo; São Paulo; 12 396 372
            array bloco 3.. if cada estado?

                pegar um estado e comparar com todos os outros? e escrever o estado..
            mas e para não acontecer novamente? apagar o array?*/



        }
    }
}