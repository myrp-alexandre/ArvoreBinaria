using System;

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

            Console.WriteLine(raiz.Valor);
        }

        public bool Procurar(Node raiz, long procurado)
        {
            throw new NotImplementedException();
        }
    }
}