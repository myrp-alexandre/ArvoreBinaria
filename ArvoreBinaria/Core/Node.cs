using System;

namespace ArvoreBinaria
{
    public class Node
    {
        public long Valor { get; set; }
        public Node Esquerda { get; set; }//menor
        public Node Direita { get; set; }//maior
        public Node Pai { get; set; }

        public Node(long novoValor)
        {
            Valor = novoValor;
            Pai = null;
        }

        public Node(long novoValor, Node pai)
        {
            Valor = novoValor;
            Pai = pai;
        }

        public bool Insere(long valorNovo, Node Pai)
        {
            if (valorNovo == Valor)
            {
                Console.WriteLine("Valor ja informado!");
            }
            else
            {
                if (valorNovo < Valor)
                {
                    if (Esquerda == null)
                    {
                        Esquerda = new Node(valorNovo, Pai);
                        Console.WriteLine("Inserido " + valorNovo + " a esquerda!");
                    }
                    else
                    {
                        return Esquerda.Insere(valorNovo, Esquerda);
                    }
                }
                else
                {
                    if (Direita == null)
                    {
                        Direita = new Node(valorNovo, Pai);
                        Console.WriteLine("Inserido " + valorNovo + " a direita!");
                    }
                    else
                    {
                        return Direita.Insere(valorNovo, Direita);
                    }
                }
            }

            return false;
        }
    }
}