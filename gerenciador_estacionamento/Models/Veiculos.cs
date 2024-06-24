using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciador_estacionamento.Models
{
    public class Veiculos : IEquatable<Veiculos>
    {
        public int IdVeiculo { get; set; }
        public string ModeloVeiculo { get; set; }
        public string Placa { get; set; }

        public override string ToString()
        {
            return "ID:" + IdVeiculo + " Nome" + ModeloVeiculo + " Placa" + Placa;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Veiculos objAsPart = obj as Veiculos;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return IdVeiculo.GetHashCode();
        }
        public bool Equals(Veiculos other)
        {
            if (other == null) return false;
            return (this.IdVeiculo.Equals(other.IdVeiculo));
        }
    }
}
