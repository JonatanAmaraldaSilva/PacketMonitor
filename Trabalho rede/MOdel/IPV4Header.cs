using PacketDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_rede.MOdel;

namespace Trabalho_rede
{
    public class IPv4Header
    {
        private IPVersion version ;
        private int headerLenght;
        private int typeofservice;
        private int totalPacketLength;
        private ushort identification;
        private int flags;
        private int fragmentOffset;
        private int ttl;
        private string protocol;
        private TCP tcp;
        private UDP udp;
        private ushort headerChecksum;
        private string sourceIP;
        private string destinationIP;

        private string data;

        public IPVersion Version { get => version; set => version = value; }
        public int HeaderLenght { get => headerLenght; set => headerLenght = value; }
        public int Typeofservice { get => typeofservice; set => typeofservice = value; }
        public int TotalPacketLength { get => totalPacketLength; set => totalPacketLength = value; }
        public ushort Identification { get => identification; set => identification = value; }
        public int Flags { get => flags; set => flags = value; }
        public int FragmentOffset { get => fragmentOffset; set => fragmentOffset = value; }
        public int Ttl { get => ttl; set => ttl = value; }
        public string Protocol { get => protocol; set => protocol = value.ToUpper(); }
        public TCP Tcp { get => tcp; set => tcp = value; }
      
        public ushort HeaderChecksum { get => headerChecksum; set => headerChecksum = value; }
        public string SourceIP { get => sourceIP; set => sourceIP = value; }
        public string DestinationIP { get => destinationIP; set => destinationIP = value; }
        public string Data { get => data; set => data = value; }
  
        public IPv4Header(IPv4Packet ipv4Pacote)
        {

            this.Version = ipv4Pacote.Version;
            this.HeaderLenght = ipv4Pacote.HeaderLength;
            this.Typeofservice = ipv4Pacote.TypeOfService;
            this.TotalPacketLength = ipv4Pacote.TotalPacketLength;
            this.Identification = ipv4Pacote.Id;
            this.Flags = ipv4Pacote.FragmentFlags;
            this.FragmentOffset = ipv4Pacote.FragmentOffset;
            this.Ttl = ipv4Pacote.TimeToLive;
            this.Protocol = ipv4Pacote.Protocol.ToString();
            this.trataProtocolo(ipv4Pacote);
            this.HeaderChecksum = ipv4Pacote.Checksum;   
            this.SourceIP = ipv4Pacote.SourceAddress.ToString();
            this.DestinationIP = ipv4Pacote.DestinationAddress.ToString();
            this.data= BitConverter.ToString(ipv4Pacote.HeaderData).Replace("-", "");

        }

        private void trataProtocolo(IPv4Packet ipv4Pacote)
        {
            switch (this.protocol)
            {
                case "TCP":
                    this.tcp = new TCP(ipv4Pacote.Extract<TcpPacket>());
                    break;
                case "UDP":
                    //atribuir novo objeto a this.udp
                    break;
            }
        }


    }
}
