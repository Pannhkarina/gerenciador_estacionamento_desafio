using gerenciador_estacionamento.Models;


decimal precoPorHora;

Estacionamento estacionamento = new();



Console.WriteLine("Olá, seja bem vindo ao estacionamento Relâmpago Mcqueen!\n" +
                  "Informe o preço inicial: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Menu estacionamento 

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{

    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (opcao = Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculos(); 
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

Console.WriteLine("Quantas Horas o veiculo ficou:");
int quantidadeHoras = Convert.ToInt32(Console.ReadLine()); 

decimal total = quantidadeHoras * precoPorHora;

Console.WriteLine($"Valor total: {total}");

Console.WriteLine("O programa se encerrou");
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();











