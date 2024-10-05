using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInformacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto arroz = new Produto(1,"Arroz Sepé - tipo 1", 6.45);
            Produto sabao = new Produto(2,"Sabão - OMO", 12.0);
            Produto figado = new Produto(3,"Fígado - 1Kg", 34.47);

            Console.Write(figado.Relatorio());
            Console.WriteLine();
            Console.Write(arroz.Relatorio());
            Console.WriteLine();
            Console.Write(sabao.Relatorio());

            sabao.ReajusteValor(50);
            Console.WriteLine();
            Console.Write(sabao.Relatorio());

            Console.ReadKey();
        }
    }
}
