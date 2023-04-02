using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace _05MetodosString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*** Métodos String ***");
            
            Console.WriteLine("\nDigite uma frase, como [Bom dia, Gostaria de uma xícara de café?]: ");
            string frase = Console.ReadLine();

            while (true)
            {
                string opcaoEscolhida = MostraMenu(frase);

                if (opcaoEscolhida == "1")
                    Console.WriteLine($"\n{frase.ToUpper()}");

                else if (opcaoEscolhida == "2")
                    Console.WriteLine($"\n{frase.ToLower()}");

                else if (opcaoEscolhida == "3")
                    Console.WriteLine($"\nEssa frase possui {frase.Replace(" ", "").Length} caracteres!");

                else if (opcaoEscolhida == "4")
                    Console.WriteLine($"\nA primeira palavra da frase é: \"{frase.Remove(frase.IndexOf(" "))}\"");

                else if (opcaoEscolhida == "5")
                    Console.WriteLine($"\nA última palavra dessa frase é: \"{frase.Substring(frase.LastIndexOf(" ") + 1)}\"");

                else if (opcaoEscolhida == "6")
                    ObterNovaFrase(ref frase);

                else if (opcaoEscolhida == "S" || opcaoEscolhida == "s")
                    break;

                Console.ReadLine();
            }
        }

        private static void ObterNovaFrase(ref string frase)
        {
            Console.WriteLine("\nDigite uma nova frase: ");
            string novaFrase = Console.ReadLine();

            frase = novaFrase;
        }

        private static string MostraMenu(string frase)
        {
            Console.Clear();

            Console.WriteLine(frase);
            
            Console.WriteLine("\nEscolha dentre as opções abaixo: ");
            Console.WriteLine("[1] Imprimir em letras maiúsculas.");
            Console.WriteLine("[2] Imprimir em letras minúsculas.");
            Console.WriteLine("[3] Imprimir a quantidade de caracteres.");
            Console.WriteLine("[4] Imprimir apenas a primeira palavra.");
            Console.WriteLine("[5] Imprimir apenas a última palavra.");
            Console.WriteLine("[6] Redefinir frase.");
            Console.WriteLine("[S] Para Sair.");

            string opcaoEscolhida = Console.ReadLine();

            return opcaoEscolhida;
        }
    }
}