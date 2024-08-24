namespace Geladeira
{
    public class Andar
    {
        private Container[] containers;
        public string Tipo { get; private set; }

        public Andar(int numContainers, int tamanhoContainer, string tipo)
        {
            containers = new Container[numContainers];
            Tipo = tipo;
            for (int i = 0; i < numContainers; i++)
            {
                containers[i] = new Container(tamanhoContainer);
            }
        }

        public Container GetContainer(int index)
        {
            return containers[index];
        }

        public void ListarConteudo()
        {
            Console.WriteLine($"Tipo de itens: {Tipo}");
            for (int i = 0; i < containers.Length; i++)
            {
                Console.WriteLine($"Container {i}:");
                containers[i].ListarItens();
            }
        }
    }
}
