using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_rede
{
    public class TCP
    {

        private string portaDestino;
        private string portaOrigem;
        private string checsumTCP;
        private string data;

        public string PortaDestino { get => portaDestino; set => portaDestino = value; }
        public string PortaOrigem { get => portaOrigem; set => portaOrigem = value; }
        public string ChecsumTCP { get => checsumTCP; set => checsumTCP = value; }
        public string Data { get => data; set => data = value; }

        public TCP(string portaDestino, string portaOrigem, string checsumTCP, string data)
        {
            this.PortaDestino = portaDestino;
            this.PortaOrigem = portaOrigem;
            this.ChecsumTCP = checsumTCP;
            this.Data = data;


        }


    }
}
