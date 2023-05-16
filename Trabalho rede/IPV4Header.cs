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
        private byte ihl ;
        private int dscp ;
        private int totalLength ;
        private ushort identification ;
        private bool df ;
        private bool mf ;
        private ushort fragmentOffset ;
        private int ttl ;
        private string protocol ;
        private ushort headerChecksum ;
        private uint sourceIP ;
        private uint destinationIP ;
        private int headerLenght ;
        private TCP tcp;
       

        public IPVersion Version { get => version; set => version = value; }
        public byte Ihl { get => ihl; set => ihl = value; }
        public int Dscp { get => dscp; set => dscp = value; }
        public int TotalLength { get => totalLength; set => totalLength = value; }
        public ushort Identification { get => identification; set => identification = value; }
        public bool Df { get => df; set => df = value; }
        public bool Mf { get => mf; set => mf = value; }
        public ushort FragmentOffset { get => fragmentOffset; set => fragmentOffset = value; }
        public int Ttl { get => ttl; set => ttl = value; }
        public string Protocol { get => protocol; set => protocol = value; }
        public ushort HeaderChecksum { get => headerChecksum; set => headerChecksum = value; }
        public uint SourceIP { get => sourceIP; set => sourceIP = value; }
        public uint DestinationIP { get => destinationIP; set => destinationIP = value; }
        public int HeaderLenght { get => headerLenght; set => headerLenght = value; }
        public TCP Tcp { get => tcp; set => tcp = value; }

        public IPv4Header()
        {

        }
    }
}
