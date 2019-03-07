using System;

namespace ArvoreBinaria.Arvores
{
    public class EmOrdem : IListar, IProcurar
    {
        public void Listar(Node raiz)
        {
            if (raiz == null)
            {
                return;
            }

            Listar(raiz.Esquerda);
            Console.WriteLine(raiz.Valor);
            Listar(raiz.Direita);
        }

        public bool Procurar(Node raiz, long procurado)
        {
            if (raiz == null)
            {
                return false;
            }

            if (Procurar(raiz.Esquerda, procurado))
            {
                return true;
            }

            if (raiz.Valor == procurado)
            {
                Console.WriteLine("achou!");
                return true;
            }

            if (Procurar(raiz.Direita, procurado))
            {
                return true;
            }

            return false;
        }
    }
}