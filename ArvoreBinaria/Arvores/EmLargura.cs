using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace ArvoreBinaria.Arvores
{
    public class EmLargura : IListar, IProcurar
    {
        public void Listar(Node raiz)
        {
            if (raiz == null)
            {
                return;
            }

            var itens = new Queue<Node>();
            itens.Enqueue(raiz);
            while (itens.Count > 0)
            {
                var node = itens.Dequeue();
                Console.WriteLine(node.Valor);
                if (node.Esquerda != null)
                {
                    itens.Enqueue(node.Esquerda);
                }
                if (node.Direita != null)
                {
                    itens.Enqueue(node.Direita);
                }
            }
        }

        public bool Procurar(Node raiz, long procurado)
        {
            throw new NotImplementedException();
        }
    }
}