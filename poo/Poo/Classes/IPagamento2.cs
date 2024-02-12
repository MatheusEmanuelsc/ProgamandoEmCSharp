using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo.Classes
{
    public interface IPagamento2
    {//isso e uma interface
    //e uma boa pratica utilizar I no nome da interface

        DateTime Vencimento { get; set; }//não se coloca se vai ser publica privada quem define e quem ira implementar

        void Pagar(double valor);
        
    }
}