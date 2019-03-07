using System;

namespace ArvoreBinaria.Arvores
{
    public class EmProfundidade : IListar, IProcurar
    {
        public void Listar(Node raiz)
        {
            if (raiz == null)
            {
                return;
            }

            Console.WriteLine(raiz.Valor);
            Listar(raiz.Esquerda);
            Listar(raiz.Direita);
        }

        public bool Procurar(Node raiz, long procurado)
        {
            if (raiz == null)
            {
                return false;
            }

            if (raiz.Valor == procurado)
            {
                Console.WriteLine("Encontrado");
                return true;
            }

            if (Procurar(raiz.Esquerda, procurado))
            {
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