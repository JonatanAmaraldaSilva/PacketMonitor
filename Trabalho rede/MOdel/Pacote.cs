using PacketDotNet;
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
        private DateTime hora;
        private string fonte;
        private string destino;
        private Enums.Protocolos protocolo;
        private IPv4Header ipv4;

        public int NrPacote { get => nrPacote; set => nrPacote = value; }

        public string Fonte { get => Ipv4.SourceIP; }
        public string Destino { get => Ipv4.DestinationIP; }
        public Enums.Protocolos Protocolo { get => protocolo; set => protocolo = value; }
        public IPv4Header Ipv4 { get => ipv4; set => ipv4 = value; }
        public DateTime Hora { get => hora; set => hora = value; }

        public Pacote(int nrPacote, Packet pacote, DateTime hora, Enums.Protocolos protocolo)
        {
            this.nrPacote = nrPacote;
            this.hora = hora;
            this.protocolo = protocolo;
            this.ipv4 = new IPv4Header(pacote.Extract<IPv4Packet>());
            //IPv4Packet ipv4Pacote= pacote.Extract<IPv4Packet>();
        }
    }
}
