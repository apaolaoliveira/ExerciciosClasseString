using System.Runtime.CompilerServices;

namespace _06EstadosECidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listaCidadesEstados = ObterCidadesEstados();
            
            string opcaoescolhida = Menu();

            if(opcaoescolhida == "1")
                CidadesAgrupadasPrimeiraLetra(listaCidadesEstados);

            else if (opcaoescolhida == "2")
                CidadesAgrupadasPorEstado(listaCidadesEstados);

            Console.ReadLine();
        }

        private static string Menu()
        {
            Console.WriteLine("*** Cidades e Estados do Brasil ***");
            Console.WriteLine("\nEscolha uma das opções abaixo: ");
            Console.WriteLine("[1] Mostrar cidades agrupadas pela primeira letra.");
            Console.WriteLine("[2] Mostrar cidades agrupadas por estado.");
            string opcaoEscolhida = Console.ReadLine();

            return opcaoEscolhida;
        }

        private static void CidadesAgrupadasPorEstado(string[] listaCidadesEstados)
        {
            Console.Clear();

            string[] estados = new string[]
            {
                "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal",
                "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
                "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro",
                "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina",
                "São Paulo", "Sergipe", "Tocantins"
            };

            for (int i = 0; i < estados.Length; i++)
            {
                string estado = estados[i];

                Console.WriteLine($"\nCidades do estado: {estado}.\n");

                for (int x = 0; x < listaCidadesEstados.Length; x++)
                {
                    if (listaCidadesEstados[x] != null && listaCidadesEstados[x].Contains(estado))
                    {
                        int posicaoInicioEstado = listaCidadesEstados[x].IndexOf(";");
                        string cidadeSemEstado = listaCidadesEstados[x].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t" + cidadeSemEstado);
                    }
                }
            }
        }

        private static void CidadesAgrupadasPrimeiraLetra(string[] listaCidadesEstados)
        {
            Console.Clear();

            char[] alfabeto = new char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            for (int i = 0; i < alfabeto.Length; i++)
            {
                Console.WriteLine($"\nCidades com a letra {alfabeto[i]}.\n");

                for (int x = 0; x < listaCidadesEstados.Length; x++)
                {
                    char primeiraLetra = alfabeto[i];

                    if (listaCidadesEstados[x] != null && listaCidadesEstados[x].StartsWith(primeiraLetra))
                    {
                        int posicaoInicioEstado = listaCidadesEstados[x].IndexOf(";");
                        string cidadeSemEstado = listaCidadesEstados[x].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t" + cidadeSemEstado);
                    }
                }
            }
        }

        private static string[] ObterCidadesEstados()
        {
            const int POSICAO_CIDADE = 2;
            const int POSICAO_ESTADO = 3;

            string arquivo = File.ReadAllText(@"C:\Users\paola\source\repos\ExerciciosClasseString\Cidades.csv"); //Lembre-se de substituir aqui o caminho do arquivo no seu computador

            string[] linhas = arquivo.Split("\r\n");

            string[] listaCidadesEstados = new string[linhas.Length];

            int j = 0;
            for (int i = 1; i < linhas.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(linhas[i]))
                {
                    string[] colunas = linhas[i].Split(";");
                    listaCidadesEstados[j] = $"{colunas[POSICAO_CIDADE]};{colunas[POSICAO_ESTADO]}";
                    j++;
                }
            }
            return listaCidadesEstados;
        }
    }
}