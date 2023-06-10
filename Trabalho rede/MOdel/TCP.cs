using PacketDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_rede
{
    public class TCP
    {
        private string sourcePort;
        private string destinationPort;
        private uint sequenceNumber;
        private uint acknowledgmentNumber;
        private int headerLength;
        private FlagsTCP flags;
        private ushort windowSize;
        private ushort checkSum;
        private int urgentPointer;
        private string options;
        private string data;

        public string SourcePort { get => sourcePort; set => sourcePort = value; }
        public string DestinationPort { get => destinationPort; set => destinationPort = value; }
        public uint SequenceNumber { get => sequenceNumber; set => sequenceNumber = value; }
        public uint AcknowledgmentNumber { get => acknowledgmentNumber; set => acknowledgmentNumber = value; }
        public int HeaderLength { get => headerLength; set => headerLength = value; }
        public FlagsTCP Flags { get => flags; set => flags = value; }
        public ushort WindowSize { get => windowSize; set => windowSize = value; }
        public ushort CheckSum { get => checkSum; set => checkSum = value; }
        public int UrgentPointer { get => urgentPointer; set => urgentPointer = value; }
        public string Options { get => options; set => options = value; }
        public string Data { get => data; set => data = value; }

        public TCP(TcpPacket pacoteTCP)
        {

            this.SourcePort = pacoteTCP.SourcePort.ToString();
            this.DestinationPort = pacoteTCP.DestinationPort.ToString();
            this.SequenceNumber = pacoteTCP.SequenceNumber;
            this.acknowledgmentNumber = pacoteTCP.AcknowledgmentNumber;
            this.HeaderLength = pacoteTCP.HeaderData.Length;
            this.Flags = new FlagsTCP(pacoteTCP);
            this.WindowSize = pacoteTCP.WindowSize;
            this.CheckSum = pacoteTCP.Checksum;
            this.UrgentPointer = pacoteTCP.UrgentPointer;
            this.Options = BitConverter.ToString(pacoteTCP.OptionsSegment.Bytes).Replace("-", "");
            this.Data = BitConverter.ToString(pacoteTCP.BytesSegment.Bytes).Replace("-", "");
        }

        public class FlagsTCP
        {

            private bool urgent;
            private bool acknowledgment;
            private bool push;
            private bool reset;
            private bool synchronize;
            private bool finished;

            public bool Urgent { get => urgent; set => urgent = value; }
            public bool Acknowledgment { get => acknowledgment; set => acknowledgment = value; }
            public bool Push { get => push; set => push = value; }
            public bool Reset { get => reset; set => reset = value; }
            public bool Synchronize { get => synchronize; set => synchronize = value; }
            public bool Finished { get => finished; set => finished = value; }

            public FlagsTCP(TcpPacket pacoteTCP)
            {
                this.Urgent = pacoteTCP.Urgent;
                this.Acknowledgment = pacoteTCP.Acknowledgment;
                this.Push = pacoteTCP.Push;
                this.Reset = pacoteTCP.Reset;
                this.Synchronize = pacoteTCP.Synchronize;
                this.Finished = pacoteTCP.Finished;
            }
        }
    }
}
