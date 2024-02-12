using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo.Classes
{
    public class Genericos<T>//criando generico
    where T: Pessoa//isso limita o tipo que pode serno generico

    {// ai na hora que fo instanciar ponha no final <> e o tipo que vc deseja
    //para utilizar mais de um generico bastar virgula e adc na hora da instaciação em todos eles

    
        public void Save(T t){

        }
    }

    public class Pessoa{}

    public class Pagamento{}
    public class Inscricao{}
}