using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePedagio2
{
    class Program
    {
        static string select;
        static int x = 1;
        static void Main(string[] args)
        {
            
            Carro carro = new Carro();
            Onibus onibus = new Onibus();
            Moto moto = new Moto();
            CobrarPed c = new CobrarPed();

            Console.WriteLine("O valor de pedagio do veiculo selecionado e: R$" + c.Cobrar(carro) + ".00 ");
            Console.ReadKey();


            /*Console.WriteLine("Digite o veiculo que deseja consultar");
            select = Console.ReadLine();
            if (select == "carro")
            {
                Console.WriteLine("O valor de pedagio do veiculo selecionado e: R$" + c.Cobrar(carro) + ".00 ");
                Console.ReadKey();
            }

            if (select == "moto")
            {
                Console.WriteLine("O valor de pedagio do veiculo selecionado e: R$" + c.Cobrar(moto) + ".00 ");
                Console.ReadKey();
            }

            if (select == "onibus")
            {
                Console.WriteLine("O valor de pedagio do veiculo selecionado e: R$" + c.Cobrar(onibus) + ".00 ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("ERRO Veiculo inexistente");
                Console.ReadKey();
            }*/






        }
    }
}
