using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            // pede as informações para o usuario
            // https://economia.uol.com.br/cotacoes/cambio/
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você ira comprar? ");
            double CDolar = double.Parse(Console.ReadLine());

            // calcula o valor a ser pago e mostra para o usuario
            double ValorPago = cotacao * CDolar;
            Console.WriteLine($"Valor a ser pago em reais = ${ValorPago} ");

            // calculo para valor total com IOF
            // https://blog.nubank.com.br/qual-valor-do-iof/
            double IOF = 4.08;
            double IOFC = ValorPago * 4.08 / 100;
            double ValorTotal = ValorPago + IOFC;

            // mostra os valores do IOF e adiciona no valor de compra das moedas
            Console.WriteLine($"Valor a ser pago de IOF = {IOF}% ");
            Console.WriteLine("ATENÇÃO: VALOR DE IOF PARA PESSOA FISICA DE SETEMBRO DE 2021");
            Console.WriteLine($"Valor total da compra com IOF = ${ValorTotal} ");
            Console.ReadKey();
        }
    }
}