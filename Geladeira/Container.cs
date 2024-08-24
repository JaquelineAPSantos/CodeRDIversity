using Geladeira;

namespace Geladeira
{
    public class Container
    {
        private Item[] posicoes;

        public Container(int tamanho)
        {
            posicoes = new Item[tamanho];
        }

        public bool AdicionarItem(int posicao, Item item)
        {
            if (posicoes[posicao] == null)
            {
                posicoes[posicao] = item;
                return true;
            }
            else
            {
                Console.WriteLine($"A posição {posicao} já está ocupada.");
                return false;
            }
        }

        public bool RemoverItem(int posicao)
        {
            if (posicoes[posicao] != null)
            {
                posicoes[posicao] = null;
                return true;
            }
            else
            {
                Console.WriteLine($"A posição {posicao} já está vazia.");
                return false;
            }
        }

        public void AdicionarItens(Item[] itens)
        {
            for (int i = 0; i < posicoes.Length; i++)
            {
                if (posicoes[i] == null && i < itens.Length)
                {
                    posicoes[i] = itens[i];
                }
                else if (i >= itens.Length)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"A posição {i} já está ocupada.");
                }
            }
        }

        public void RemoverTodosItens()
        {
            for (int i = 0; i < posicoes.Length; i++)
            {
                if (posicoes[i] != null)
                {
                    posicoes[i] = null;
                }
                else
                {
                    Console.WriteLine($"A posição {i} já está vazia.");
                }
            }
        }

        public void ListarItens()
        {
            for (int i = 0; i < posicoes.Length; i++)
            {
                if (posicoes[i] != null)
                {
                    Console.WriteLine($"Posição {i}: {posicoes[i].Nome}");
                }
                else
                {
                    Console.WriteLine($"Posição {i}: Vazio");
                }
            }
        }
    }
}

