using System;

namespace ArvoreBinaria
{
    internal class Program
    {
        private static ArvoreBinaria Arvore { get; set; }

        private static void Main(string[] args)
        {
            Arvore = new ArvoreBinaria();

            while (true)
            {
                Console.WriteLine("Informe o Valor! Informe N para parar!");
                var comando = Console.ReadLine();
                if (comando.ToUpper() == "N")
                {
                    break;
                }

                Arvore.Insere(long.Parse(comando));
            }
            Console.Clear();
            Console.WriteLine("Qual número você deseja procurar?");
            var procurado = Console.ReadLine();
            Arvore.Percorrer(long.Parse(procurado));

            Console.ReadKey();
        }
    }
}