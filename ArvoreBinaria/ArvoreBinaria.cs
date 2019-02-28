using System;

namespace ArvoreBinaria
{
    public class ArvoreBinaria
    {
        private Node Raiz { get; set; }
        private IPercorre Metodo;
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
                return Raiz.Insere(newValue);
            }
        }

        public void Percorrer(long valorProcurado)
        {
            Profundidade = 0;
            var achado = Procurar(Raiz, valorProcurado);
            if (!achado)
            {
                Console.WriteLine("Não encontrado!");
            }
        }

        private bool Procurar(Node nodeAtual, long valorProcurado)
        {
            Profundidade++;
            if (nodeAtual.Valor == valorProcurado)
            {
                Console.WriteLine("Encontrado na profundidade " + Profundidade);
                return true;
            }
            else
            {
                if (valorProcurado < nodeAtual.Valor)
                {
                    if (Procurar(nodeAtual.Esquerda, valorProcurado))
                    {
                        return true;
                    }
                }
                else
                {
                    if (Procurar(nodeAtual.Direita, valorProcurado))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}