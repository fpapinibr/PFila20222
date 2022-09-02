using System;

namespace PFila20222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaPessoa contatos = new FilaPessoa();

            contatos.Print();
            contatos.Pop();
            contatos.Push(new Pessoa("Morango", 32, "190"));
            contatos.Push(new Pessoa("Baratao", 47, "911"));
            contatos.Print();
            contatos.Pop();
            contatos.Print();
            contatos.Pop();
            contatos.Print();
        }
    }
}
