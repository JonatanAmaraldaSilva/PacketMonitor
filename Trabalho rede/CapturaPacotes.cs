using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpPcap;
using SharpPcap.LibPcap;
using SharpPcap.WinpkFilter;
using PacketDotNet;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

namespace Trabalho_rede
{
    public class CapturaPacotes
    {
        private ICaptureDevice device;
        private Enums.Protocolos protocolo;
        private string filter = "";

        public ICaptureDevice Device { get => device; set => device = value; }
        public Enums.Protocolos Protocolo { get => protocolo; set => protocolo = value; }

        public CapturaPacotes(ICaptureDevice device, Enums.Protocolos protocolo)
        {
            this.Device = device;
            this.Protocolo = protocolo;
        }

        public void iniciaCaptura(List<Pacote> pacoteList, bool stop)
        {

            int readTime = 1000;
            device.Open(DeviceModes.Promiscuous, readTime);

            switch (this.Protocolo)
            {
                case Enums.Protocolos.TCP:
                    this.filter = "ip and tcp";
                    break;
                case Enums.Protocolos.UDP:
                    this.filter = "ip and udp";
                    break;

            }


            //filter = this.protocolo.ToString();
            device.Filter = filter;

            PacketCapture e;

            int nrPacote = 1;

            while (device.GetNextPacket(out e) != null || stop == false)
            {
                try
                {
                    nrPacote += 1;

                    // DateTime time = packet.PcapHeader.Date;
                    DateTime time = e.GetPacket().Timeval.Date.AddHours(-3);
                    //int len = packet.PcapHeader.PacketLength;
                    int len = e.GetPacket().PacketLength;

                    Packet p = Packet.ParsePacket(e.GetPacket().LinkLayerType, e.GetPacket().Data);

                    IPv4Packet ipv4Pacote = p.Extract<IPv4Packet>();

                    //var linkLayer = e.GetPacket().LinkLayerType;
                    string protocolo = ipv4Pacote.Protocol.ToString();
                    var sourceAddress = ipv4Pacote.SourceAddress.ToString();
                    var destinationAddress = ipv4Pacote.DestinationAddress.ToString();
                    //var TTL = ipv4Pacote.TimeToLive.ToString();
                    //var checksum = ipv4Pacote.Checksum;
                    //var ischecksum = ipv4Pacote.ValidChecksum;

                    IPv4Header ipv4 = new IPv4Header(ipv4Pacote);

                    if (protocolo == "Tcp")
                    {

                        TcpPacket tcpPacote = p.Extract<TcpPacket>();


                        var data = BitConverter.ToString(tcpPacote.BytesSegment.Bytes).Replace("-", "");

                        ipv4.Tcp = new TCP(tcpPacote.DestinationPort.ToString(), tcpPacote.SourcePort.ToString(), tcpPacote.Checksum.ToString(), data);

                        var f =tcpPacote.Flags;

                        var a = tcpPacote.HeaderData.ToString();
                        var b = tcpPacote.Acknowledgment.ToString();
                        var c = tcpPacote.Synchronize.ToString();
                        var d = tcpPacote.Urgent;
                        var i = tcpPacote.Push.ToString(); 
                        var g = tcpPacote.Reset.ToString();
                        var h = tcpPacote.Finished.ToString();
                        var v = tcpPacote.SequenceNumber.ToString();
                        var j = tcpPacote.WindowSize.ToString();
                        var t = tcpPacote.AcknowledgmentNumber.ToString();
                        pacoteList.Add(new Pacote(nrPacote, sourceAddress, destinationAddress, Enums.Protocolos.TCP, ipv4, time));
                    }
                    else if(protocolo == "Udp")
                    {

                    }


                    nrPacote += 1;

                }
                catch
                {
                }

                // Prints the time and length of each received packet



            }


        }
    }
}
