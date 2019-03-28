using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePedagio2
{
    abstract class AbsVeiculo : IVeiculo
    {
        public virtual int Eixos { get => 2; set => throw new NotImplementedException(); }
        

        public bool ligar()
        {
            throw new NotImplementedException();
        }

        Motor motor = new Motor();
    }
}
