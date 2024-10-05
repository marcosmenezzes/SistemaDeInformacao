using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInformacao
{
    internal class Produto
    {
        int id;
        string descricao;
        public double Valor;

        public int Id { get => id; set => id = value; }

        public Produto(int id, string descricao, double valor)
        {
            this.id = id;
            this.descricao = descricao;
            Valor = valor;
        }

        public void ReajusteValor(double valor)
        {
            Valor = valor * (valor / 100);
        }

        public string Relatorio()
        {
            return "Produto: " + descricao + "\nValor: " + Valor;
        }
    }
}
