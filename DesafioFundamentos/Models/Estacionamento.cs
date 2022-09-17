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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = "";
            placa = Console.ReadLine().ToUpper();
            if (veiculos.Any(x => x == placa))// Estou garantido que na lista tenha apenas Maiusculas
            {
               Console.WriteLine($"Veiculo {placa} ja lançado no sistema!");
            }
            else
            {
               veiculos.Add(placa);
               Console.WriteLine($"Veiculo {placa} adicionado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = "";
            placa = Console.ReadLine().ToUpper();
            // Verifica se o veículo existe
            if (veiculos.Any(x => x == placa))// Estou garantido que na lista tenha apenas Maiusculas
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal = 0; 
                horas = int.Parse(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora*horas);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");
            }
            else
            {
                Console.WriteLine($"Desculpe, esse veículo({placa}) não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                for (int i=0; i<veiculos.Count; i++){
                   Console.WriteLine($"N. {i+1} PLACA {veiculos[i]} |__:__|_________________|INICIAL {precoInicial:C}|HORA ADICIONAL {precoPorHora:C}|R$______________|");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
