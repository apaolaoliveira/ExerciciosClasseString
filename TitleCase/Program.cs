namespace _2NumeroDePalavras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Contador de palavras ***");
            Console.Write("\nEscreva uma frase: ");
            string frase = Console.ReadLine();

            string[] contadorPalavras = frase.Split(' ');

            Console.WriteLine($"\nHá {contadorPalavras.Length} palavras nessa frase :)");

            Console.ReadLine();
        }
    }
}