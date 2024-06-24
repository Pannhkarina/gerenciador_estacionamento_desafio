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
        List<Veiculos> veiculos = new();
        int idVeiculo = 1;
        public void AdicionarVeiculos()
        {

            Console.WriteLine("Informe o modelo do veiculo: ");
            string modeloVeiculo = Console.ReadLine();
            Console.WriteLine("Informe o placa do veiculo: ");
            string placa = Console.ReadLine();

            veiculos.Add(new Veiculos()
            {

                IdVeiculo = idVeiculo,
                ModeloVeiculo = modeloVeiculo,
                Placa = placa

            });

            idVeiculo++;
        }

        public void ListarVeiculos() 
        {
            if (veiculos.Any())
            {
                Console.WriteLine();

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }

            }
            else { Console.WriteLine("Nenhum foi veiculo cadastrado."); }
        
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Informe o id do carro que deseja remover: ");
            int veiculoId = Convert.ToInt32(Console.ReadLine());

            veiculos.Remove(new Veiculos()
            {
                IdVeiculo = veiculoId,

            });

            ListarVeiculos();

        }


    }
}
 