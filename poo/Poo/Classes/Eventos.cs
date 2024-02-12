using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo.Classes
{
    public class Eventos
    {
        //Eventos sempre sera utilizado em conjuto com delegates

        public int Assentos { get; set; }
        private int AssentosUsados=0;
        public Eventos(int assento)
        {
            Assentos = assento;
        }

        public void AssentoReservado(){
            AssentosUsados++;
            if (AssentosUsados>= Assentos)
            {
                OnEventoLotado(EventArgs.Empty);
            }else{
                Console.WriteLine("Assento reservado");
            }
        }

        public event EventHandler Eventolotado;

        protected virtual void OnEventoLotado(EventArgs e){
            EventHandler handler = Eventolotado;
            handler?.Invoke(this,e);
        }

        static void OnQuandoLotar(){
        Console.WriteLine("Lotou!!!!");
        //Ai so linkar la no program
    }
    }

    
}