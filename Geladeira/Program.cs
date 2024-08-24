namespace Geladeira
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Geladeira geladeira = new Geladeira(4, 2, 4);

            bool rodando = true;
            while (rodando)
            {
                Console.WriteLine("\nMenu da Geladeira:");
                Console.WriteLine("1. Adicionar item");
                Console.WriteLine("2. Remover item");
                Console.WriteLine("3. Listar conteúdo da geladeira");
                Console.WriteLine("4. Sair");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarItem(geladeira);
                        break;
                    case "2":
                        RemoverItem(geladeira);
                        break;
                    case "3":
                        geladeira.ListarConteudo();
                        break;
                    case "4":
                        rodando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarItem(Geladeira geladeira)
        {
            int andar = SolicitarInput("andar", 0, 3, [
        "Andar 0 - Hortifrutis",
        "Andar 1 - Laticínios e Enlatados",
        "Andar 2 - Charcutaria, Carnes e Ovos",
        "Andar 3 - Outros"
    ]);

            int container = SolicitarInput("container", 0, 1, null);

            int posicao = SolicitarInput("posição", 0, 3, null);

            Console.Write("Digite o nome do item: ");
            string nomeItem = Console.ReadLine();

            if (geladeira.GetAndar(andar).GetContainer(container).AdicionarItem(posicao, new Item(nomeItem)))
            {
                
                Console.WriteLine($"O item {nomeItem} adicionado com sucesso ao Andar {andar}, Container {container}, Posição {posicao}.");
            }
            else
            {
                Console.WriteLine("Não foi possível adicionar o item.");
            }
        }


        static void RemoverItem(Geladeira geladeira)
        {
            int andar = SolicitarInput("andar", 0, 3, new string[] {
                "Andar 0 - Hortifrutis",
                "Andar 1 - Laticínios e Enlatados",
                "Andar 2 - Charcutaria, Carnes e Ovos",
                "Andar 3 - Outros"
            });

            int container = SolicitarInput("container", 0, 1, null);

            int posicao = SolicitarInput("posição", 0, 3, null);

            if (!geladeira.GetAndar(andar).GetContainer(container).RemoverItem(posicao))
            {
                Console.WriteLine("Não foi possível remover o item.");
            }
        }

        static int SolicitarInput(string nome, int min, int max, string[]? opcoes)
        {
            int valor;
            while (true)
            {
                if (opcoes != null)
                {
                    Console.WriteLine($"Escolha o {nome}:");
                    foreach (string opcao in opcoes)
                    {
                        Console.WriteLine(opcao);
                    }
                }
                else
                {
                    Console.Write($"Digite o {nome} ({min}-{max}): ");
                }

                string input = Console.ReadLine();

                if (int.TryParse(input, out valor) && valor >= min && valor <= max)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine($"Entrada inválida. Por favor, digite um número entre {min} e {max}.");
                }
            }
            return valor;
        }
    }
}
