using System.Collections.Specialized;

namespace _03CifraDeCesar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*** Cifra de César ***");
            Console.Write("\nEscreva uma frase: ");
            string frase = Console.ReadLine();

            char[] caracteres = frase.ToCharArray();

            Console.Write("\nNúmero de posições a serem avançadas: ");
            int numeroPosicoesAvancadas = Convert.ToInt32(Console.ReadLine());

            Criptografar(frase, caracteres, numeroPosicoesAvancadas);
        }

        private static void Criptografar(string frase, char[] caracteres, int numeroPosicoesAvancadas)
        {
            for (int i = 0; i < frase.Length; i++)
            {
                caracteres[i] = Convert.ToChar(frase[i] + numeroPosicoesAvancadas);
            }

            Console.Write("\nSua frase criptografada fica: ");
            Console.Write(caracteres);
            Console.ReadLine();
        }
    }
}