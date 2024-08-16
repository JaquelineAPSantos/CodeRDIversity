using System;

namespace GeladeiraIoT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializa a geladeira
            string[,,] geladeira = new string[3, 2, 4];

            // Adiciona os itens em cada andar, container e posição
            // Andar 0 - Hortifrutis
            geladeira[0, 0, 0] = "Maçã";
            geladeira[0, 0, 1] = "Banana";
            geladeira[0, 1, 0] = "Tomate";
            geladeira[0, 1, 1] = "Alface";

            // Andar 1 - Laticínios e Enlatados
            geladeira[1, 0, 0] = "Leite";
            geladeira[1, 0, 1] = "Queijo";
            geladeira[1, 1, 0] = "Feijão Enlatado";
            geladeira[1, 1, 1] = "Milho Enlatado";

            // Andar 2 - Charcutaria, Carnes e Ovos
            geladeira[2, 0, 0] = "Presunto";
            geladeira[2, 0, 1] = "Salame";
            geladeira[2, 1, 0] = "Carne Bovina";
            geladeira[2, 1, 1] = "Ovos";

            // Imprime todos os itens da geladeira
            for (int andar = 0; andar < 3; andar++)
            {
                for (int container = 0; container < 2; container++)
                {
                    for (int posicao = 0; posicao < 4; posicao++)
                    {
                        if (geladeira[andar, container, posicao] != null)
                        {
                            Console.WriteLine($"Andar {andar}, Container {container}, Posição {posicao}: {geladeira[andar, container, posicao]}");
                        }
                    }
                }
            }
        }
    }
}