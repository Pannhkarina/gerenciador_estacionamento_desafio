using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace gerenciador_estacionamento.Models
{
    public class Estacionamento
    {
        List<string> veiculos = new();
        int veiculoId = 1;
        public void AdicionarVeiculos()
        {

            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe placa do veículo: ");
            string placa = Console.ReadLine();

            veiculos.Add($"{veiculoId} | {nome} | {placa} ");
            veiculoId++;
        }

        public void ListarVeiculos() 
        {
            if (veiculos.Any())
            {
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item + "\n");
                }

            }
            else { Console.WriteLine("Nenhum foi veiculo cadastrado."); }
        
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Informe a placa do carro que deseja remover: ");
            string placa = Console.ReadLine();

            if (veiculos.Remove(placa))
            {
                Console.WriteLine($"Veiculo com placa {placa} removido com sucesso!");
            }
            else { Console.WriteLine($"Placa {placa} não encontrada."); }
           
       
        }


    }
}
 