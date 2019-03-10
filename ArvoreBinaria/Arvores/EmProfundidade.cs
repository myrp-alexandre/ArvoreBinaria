using System;

namespace ArvoreBinaria.Arvores
{
    public class EmProfundidade : IListar, IProcurar, IProcurarERetornar
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

        public Node ProcurarERetornar(Node raiz, long procurado)
        {
            if (raiz == null)
            {
                return null;
            }

            if (raiz.Valor == procurado)
            {
                Console.WriteLine("Encontrado");
                return raiz;
            }

            var resultado = ProcurarERetornar(raiz.Esquerda, procurado);
            if (resultado != null)
            {
                return resultado;
            }

            resultado = ProcurarERetornar(raiz.Direita, procurado);
            if (resultado != null)
            {
                return resultado;
            }

            return null;
        }
    }
}