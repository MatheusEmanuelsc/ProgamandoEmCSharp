using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo.Classes
{
    public class Pagamento : IDisposable// interface para caso precise destruir o objeto
    {   


        //Modificadores de acesso 
        // private, protected, internal e public
        private DateTime DataVencimento;

        public Pagamento(DateTime dataVencimento)
        {
            this.DataVencimento=dataVencimento;
        }//Construtor

        public void Dispose()
        {
            Console.WriteLine("Finalizando objeto");
            throw new NotImplementedException();
        }//com metodo implemantado vc iniciar o objeto  com using assim ele fechar automaticamente

        //metodos
        public virtual void  Pagar(){
        }
        //Virtual permite quem um metodo possa ser sobreescrito

        public delegate void Delegando(string pago);//ao adc delegate essa função permite que outra função para implementar ela deis que assinatura seja a mesma não precisa ter nome igual
        //Para implementar
        /*
            quando vc tiver o objeto basta chamar ela ai ao inves de passar o parametro vc passa a função

            Pessoa.Delegando(FuncaoQueimplementou()); ai para usar depois e so
            Delegando("seilar);

            
        */
    }

    class PagamentoBoleto : Pagamento{
        //Herança

        public string NumeroBoleto;

        public PagamentoBoleto(DateTime dataVencimento) : base(dataVencimento)
        {
            //base para utilizar meotods ou coisas da  classe pai
            //para enviar para classe pay alhum parametro : base
        }

        public override void Pagar(){

        }//override aqui vc sobreescreveu
    }

    class PagamentoCartaoCredito:Pagamento{
        public string NumeroCartao;

        public PagamentoCartaoCredito(DateTime dataVencimento) : base(dataVencimento)
        {
        }

        public override void Pagar(){

        }//override aqui vc sobreescreveu
    } 


    public static class Seilar{
        //classe statica  os metodos tem que ser statico

        static void FalaOi(){
            Console.WriteLine("Oi");
        }

        //Não precisa instanciar
        //Use sempre quando e a mesma informação pra todos usuarios

    }


    public sealed class PodeNao{
        //sealed impede que a classe seja herdada por outros
    }

    public partial class Divide{
        //Para fazer uma classe parcial ou seja 2 classes com mesmo nome e mesmo namespace vc pode divide em ela em duas  em 2 arquivos diferente caso precise que no final sera  intepretado como apenas uma
    }

    public abstract class Abstrato 
    {//classe abstrata ou seja uma classe que não vai ser instanciada apenas herdada

    //os metodos podem ter uma implementação base
        
    }
}