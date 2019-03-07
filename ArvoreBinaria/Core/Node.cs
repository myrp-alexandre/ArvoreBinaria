using System;

namespace ArvoreBinaria
{
    public class Node
    {
        public long Valor { get; set; }
        public Node Esquerda { get; set; }//menor
        public Node Direita { get; set; }//maior

        public Node(long novoValor)
        {
            Valor = novoValor;
        }

        public bool Insere(long valorNovo)
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
                        Esquerda = new Node(valorNovo);
                        Console.WriteLine("Inserido " + valorNovo + " a esquerda!");
                    }
                    else
                    {
                        return Esquerda.Insere(valorNovo);
                    }
                }
                else
                {
                    if (Direita == null)
                    {
                        Direita = new Node(valorNovo);
                        Console.WriteLine("Inserido " + valorNovo + " a direita!");
                    }
                    else
                    {
                        return Direita.Insere(valorNovo);
                    }
                }
            }

            return false;
        }
    }
}