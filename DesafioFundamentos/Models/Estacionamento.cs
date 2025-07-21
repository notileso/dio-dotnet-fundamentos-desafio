namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TEST: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? veiculo = Console.ReadLine();
            if (veiculo == null || veiculo.Length == 0)
            {
                Console.WriteLine("Placa inválida");
            }
            else
            {
                veiculos.Add(veiculo.ToUpper());
                Console.WriteLine($"O veículo {veiculo} foi adicionado ao estacionamento");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string? placa = Console.ReadLine();
            if (placa == null || placa.Length == 0)
            {
                Console.WriteLine("Placa inválida");
            }
            // Verifica se o veículo existe
            else if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TEST: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TEST: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = int.TryParse(Console.ReadLine(), out int b) ? b : 0;
                if (horas == 0)
                {
                    Console.WriteLine("Quantidade de horas inválida");
                    return;
                }

                decimal valorTotal = this.precoInicial + this.precoPorHora * horas;

                // Remove a placa da lista de veículos

                // TEST: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TEST: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo}\n");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}