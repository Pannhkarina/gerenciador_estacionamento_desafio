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
        public void AdicionarVeiculos()
        {

            Console.WriteLine("Informe placa do veículo: ");
            string placa = Console.ReadLine();

            veiculos.Add(placa);

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

            string placaVeiculo = null;

            foreach (var item in veiculos) 
            {
                if(veiculos.Contains(placa))
                {
                    placaVeiculo = item;
                    break;
                }
            }

            if(placaVeiculo != null)
            {
                veiculos.Remove(placaVeiculo);
                Console.WriteLine($"Veiculo {placa} removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Nenhum veiculo encontrado.");
            }
          
            
            ListarVeiculos();

        }


    }
}
 