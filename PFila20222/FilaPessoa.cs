using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFila20222
{
    internal class FilaPessoa
    {
        public Pessoa HEAD { get; set; }
        public Pessoa TAIL { get; set; }

        public FilaPessoa()
        {
            HEAD = TAIL = null;
        }

        public void Push(Pessoa aux)
        {
            if (Vazia())
                HEAD = TAIL = aux;
            else
            {
                TAIL.Proximo = aux;
                TAIL = aux;
            }
            Console.WriteLine("Inserido com sucesso!");
            Console.ReadKey();
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível remover! Fila vazia!");
                //Console.ReadKey();
            }
            else
            {
                HEAD = HEAD.Proximo;
                if (HEAD == null)
                    TAIL = null;
                Console.WriteLine("Elemento Removido!");
            }
            Console.ReadKey();
        }

        public void Print()
        {
            if (Vazia())
                Console.WriteLine("Fila Vazia!");
            else
            {
                Pessoa aux = HEAD;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }while (aux != null);
                Console.WriteLine("FIM DA IMPRESSÃO");
            }
            Console.ReadKey();
        }

        private bool Vazia()
        {
            if ((HEAD == null) && (TAIL == null))
                    return true;
            else 
                return false;
        }
    }
}
