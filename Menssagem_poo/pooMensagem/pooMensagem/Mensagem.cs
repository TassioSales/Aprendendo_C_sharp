using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {

        private String TextoMensagem;
        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }

        public string getTextoMensagem() 
        { 
            return this.TextoMensagem; 
        }

        public void setTextoMensagem(String valor) 
        { 
            this.TextoMensagem = valor.ToUpper();
        
        }
    }
}
