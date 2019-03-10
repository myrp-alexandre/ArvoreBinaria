using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ArvoreBinaria.Arvores;

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

        public Node ProcurarERetornar(IProcurarERetornar procura, long procurado)
        {
            return procura.ProcurarERetornar(Raiz, procurado);
        }

        public void Listar(IListar listagem)
        {
            listagem.Listar(Raiz);
        }

        private List<Node> BuscarFilhosNode(Node raizNode)
        {
            List<Node> filhos = new List<Node>();
            filhos = AdicionarFilhos(raizNode, filhos);
            return filhos;
        }

        private List<Node> AdicionarFilhos(Node raiz, List<Node> jaLidos)
        {
            if (raiz.Esquerda == null && raiz.Direita == null)
            {
                jaLidos.Add(raiz);
            }
            if (raiz.Esquerda != null)
            {
                jaLidos = AdicionarFilhos(raiz.Esquerda, jaLidos);
            }
            if (raiz.Direita != null)
            {
                jaLidos = AdicionarFilhos(raiz.Direita, jaLidos);
            }

            return jaLidos;
        }

        public void RemoverNode(long numero)
        {
            var node = ProcurarERetornar(new EmProfundidade(), numero);
            if (node == null)
            {
                Console.WriteLine("Não encontrado node");
                return;
            }

            if (node.Esquerda == null && node.Direita == null) //Nao tem filhos, so deleta
            {
                if (node.Pai.Esquerda == node)
                {
                    node.Pai.Esquerda = null;
                }
                else if (node.Pai.Direita == node)
                {
                    node.Pai.Direita = null;
                }

                return;
            }

            if (node.Esquerda == null || node.Direita == null) // tem um dos filhos, faz a substituição
            {
                var filho = node.Esquerda ?? node.Direita;

                if (node.Pai.Esquerda == node)
                {
                    node.Pai.Esquerda = filho;
                }
                else
                {
                    node.Pai.Direita = filho;
                }

                return;
            }

            var filhos = BuscarFilhosNode(node.Direita);
            var filhoTrocar = filhos.OrderBy(x => x.Valor).First();
            node.Valor = filhoTrocar.Valor;
            if (filhoTrocar.Pai.Esquerda == filhoTrocar)
            {
                filhoTrocar.Pai.Esquerda = null;
            }
            else
            {
                filhoTrocar.Pai.Direita = null;
            }
        }
    }
}