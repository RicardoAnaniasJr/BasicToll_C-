using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePedagio2
{
    interface IVeiculo
    {

        int Eixos { get; set; }
        bool ligar();
        
    }
}
