using PacketDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_rede.MOdel
{
    public class UDP
    {
        private string sourcePort;
        private string destinationPort;
        private ushort checkSum;
        private int headerLength;
        private bool checkSumUDP;
        private string data;

        public string SourcePort { get => sourcePort; set => sourcePort = value; }
        public string DestinationPort { get => destinationPort; set => destinationPort = value; }
        public ushort CheckSum { get => checkSum; set => checkSum = value; }
        public int HeaderLength { get => headerLength; set => headerLength = value; }
        public bool CheckSumUDP { get => checkSumUDP; set => checkSumUDP = value; }
        public string Data { get => data; set => data = value; }

        public UDP(UdpPacket pacoteUDP)
        {
            this.SourcePort = pacoteUDP.SourcePort.ToString();
            this.DestinationPort = pacoteUDP.DestinationPort.ToString();
            this.CheckSum = pacoteUDP.Checksum;
            this.HeaderLength = pacoteUDP.HeaderData.Length;
            this.CheckSumUDP = pacoteUDP.ValidUdpChecksum;
            this.Data = BitConverter.ToString(pacoteUDP.BytesSegment.Bytes).Replace("-", "");
        }
    }
}
