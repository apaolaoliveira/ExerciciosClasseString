namespace _01TitleCase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*** Title Case ***");
            Console.WriteLine("\nDigite uma frase: ");
            string frase = Console.ReadLine();

            ConverterParaTitleCase(frase);
        }

        private static void ConverterParaTitleCase(string frase)
        {
            string[] palavrasSeparadas = frase.Split(' ');

            for (int i = 0; i < palavrasSeparadas.Length; i++)
            {
                char[] letrasDasPalavras = palavrasSeparadas[i].ToCharArray();

                char primeiraLetra = letrasDasPalavras[0]; //Não conseguimos usar o .ToUpper aqui, pois o char se refere mais a tabela ASCII do que String

                letrasDasPalavras[0] = primeiraLetra > 96 ? Convert.ToChar(primeiraLetra - 32) : letrasDasPalavras[0];

                palavrasSeparadas[i] = new string(letrasDasPalavras);
            }

            string fraseTitleCase = string.Join(" ", palavrasSeparadas);

            Console.WriteLine($"\nSua frase formatada é: \n{fraseTitleCase}");

            Console.ReadLine();
        }
    }
}