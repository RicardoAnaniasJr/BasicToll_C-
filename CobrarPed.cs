using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePedagio2
{
    class CobrarPed 
    {
        public double Preco;
        
        public double Result;

        public double Cobrar(IVeiculo v)
        {
            Preco = 4;
            Result = Preco * v.Eixos;
            return Result;

            
        }
        public CobrarPed() { }

    }
}
