using System;
using System.Collections;
using System.Collections.Generic;

namespace ArvoreBinaria
{
    public class ArvoreBinaria
    {
        private Node Raiz { get; set; }
        private IListar Metodo;
        private long Profundidade { get; set; }

        public bool Insere(long newValue)
        {
            if (Raiz == null)
            {
                Console.WriteLine(newValue + " é a raiz da arvore!");
                Raiz = new Node(newValue);
                return true;
            }
            else
            {
                return Raiz.Insere(newValue, Raiz);
            }
        }

        public void Procurar(IProcurar procura)
        {
            Console.WriteLine("Qual número você deseja procurar?");
            var procurado = Console.ReadLine();
            procura.Procurar(Raiz, long.Parse(procurado));
        }

        public void Listar(IListar listagem)
        {
            listagem.Listar(Raiz);
        }
    }
}