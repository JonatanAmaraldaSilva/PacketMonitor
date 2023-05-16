using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Trabalho_rede
{
    public class Pacote
    {

  
        private int nrPacote;
        private string fonte;
        private string destino;
        private Enums.Protocolos protocolo ;
        private IPv4Header ipv4;

        public int NrPacote { get => nrPacote; set => nrPacote = value; }
        public string Fonte { get => fonte; set => fonte = value; }
        public string Destino { get => destino; set => destino = value; }
        public Enums.Protocolos Protocolo { get => protocolo; set => protocolo = value; }
        public IPv4Header Ipv4 { get => ipv4; set => ipv4 = value; }

        public Pacote(int nrPacote, string fonte, string destino, Enums.Protocolos protocolo, IPv4Header ipv4)
        {
            this.nrPacote = nrPacote;
            this.fonte = fonte;
            this.destino = destino;
            this.protocolo = protocolo;
            this.ipv4 = ipv4;
        }
    }
}
