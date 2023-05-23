using PacketDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_rede
{
    public class IPv4Header
    {
        private IPVersion version ;
        private int headerLenght;
        private int typeofservice;
        private int dscp ;
        private int totalLength ;
        private ushort identification ;
        private bool df ;
        private bool mf ;
        private int fragmentOffset ;
        private int ttl ;
        private string protocol ;
        private ushort headerChecksum ;
        private string sourceIP ;
        private string destinationIP ;
        private TCP tcp;
        private int flags;

        private string data;

        public IPVersion Version { get => version; set => version = value; }
        public int Dscp { get => dscp; set => dscp = value; }
        
        public int TotalLength { get => totalLength; set => totalLength = value; }
        public ushort Identification { get => identification; set => identification = value; }
        public bool Df { get => df; set => df = value; }
        public bool Mf { get => mf; set => mf = value; }
        public int FragmentOffset { get => fragmentOffset; set => fragmentOffset = value; }
        public int Ttl { get => ttl; set => ttl = value; }
        public string Protocol { get => protocol; set => protocol = value; }
        public ushort HeaderChecksum { get => headerChecksum; set => headerChecksum = value; }
        public string SourceIP { get => sourceIP; set => sourceIP = value; }
        public string DestinationIP { get => destinationIP; set => destinationIP = value; }
        public int HeaderLenght { get => headerLenght; set => headerLenght = value; }
        public TCP Tcp { get => tcp; set => tcp = value; }
        public int Typeofservice { get => typeofservice; set => typeofservice = value; }
        public int Flags { get => flags; set => flags = value; }
        public string Data { get => data; set => data = value; }

        public IPv4Header(IPv4Packet ipv4Pacote)
        {

            this.Version = ipv4Pacote.Version;
            this.HeaderLenght = ipv4Pacote.HeaderLength;
            this.Typeofservice = ipv4Pacote.TypeOfService;
            this.TotalLength = ipv4Pacote.TotalLength;
            this.Identification = ipv4Pacote.Id;
            this.Flags = ipv4Pacote.FragmentFlags;
            this.FragmentOffset = ipv4Pacote.FragmentOffset;
            this.Ttl = ipv4Pacote.TimeToLive;
            this.Protocol = ipv4Pacote.Protocol.ToString();
            this.HeaderChecksum = ipv4Pacote.Checksum;
            this.SourceIP = ipv4Pacote.SourceAddress.ToString();
            this.DestinationIP = ipv4Pacote.DestinationAddress.ToString();
            this.Dscp = ipv4Pacote.DifferentiatedServices;

            this.data= BitConverter.ToString(ipv4Pacote.HeaderData).Replace("-", "");


        }
    }
}
