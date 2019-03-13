using ArvoreBinaria.Arvores;
using System;

namespace ArvoreBinaria
{
    internal class Program
    {
        private static ArvoreBinaria Arvore { get; set; }

        private static void Main(string[] args)
        {
            Arvore = new ArvoreBinaria();

            //while (true)
            //{
            //    Console.WriteLine("Informe o Valor! Informe N para parar!");
            //    var comando = Console.ReadLine();
            //    if (comando.ToUpper() == "N")
            //    {
            //        break;
            //    }

            //    Arvore.Insere(long.Parse(comando));
            //    Console.Clear();
            //}

            Arvore.Insere(5);
            Arvore.Insere(3);
            Arvore.Insere(4);
            Arvore.Insere(7);
            Arvore.Insere(6);
            Arvore.Insere(17);
            Arvore.Insere(12);

            Arvore.Listar(new EmLargura());
            Console.WriteLine("---------------------");
            Arvore.RemoverNode(7);
            Console.WriteLine("---------------------");

            Arvore.Listar(new EmLargura());

            Console.ReadKey();
        }
    }
}