using Geladeira;

namespace Geladeira
{
    public class Geladeira
    {
        private Andar[] andares;

        public Geladeira(int numAndares, int numContainersPorAndar, int tamanhoContainer)
        {
            andares = new Andar[numAndares];
            andares[0] = new Andar(numContainersPorAndar, tamanhoContainer, "Hortifrutis");
            andares[1] = new Andar(numContainersPorAndar, tamanhoContainer, "Laticínios e Enlatados");
            andares[2] = new Andar(numContainersPorAndar, tamanhoContainer, "Charcutaria, Carnes e Ovos");
            andares[3] = new Andar(numContainersPorAndar, tamanhoContainer, "Outros");
        }

        public Andar GetAndar(int index)
        {
            return andares[index];
        }

        public void ListarConteudo()
        {
            for (int i = 0; i < andares.Length; i++)
            {
                Console.WriteLine($"\nAndar {i}:");
                andares[i].ListarConteudo();
            }
        }
    }
}
