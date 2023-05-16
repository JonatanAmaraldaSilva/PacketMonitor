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

namespace Trabalho_rede
{
    public class CapturaPacotes
    {
        private ICaptureDevice device;
        private Enums.Protocolos protocolo;

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

            string filter = "";
            //filter = this.protocolo.ToString();
            device.Filter = filter;

            PacketCapture e;

            int nrPacote = 0;

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

                    var linkLayer = e.GetPacket().LinkLayerType;
                    string protocolo = ipv4Pacote.Protocol.ToString();
                    var sourceAddress = ipv4Pacote.SourceAddress.ToString();
                    var destinationAddress = ipv4Pacote.DestinationAddress.ToString();
                    var TTL = ipv4Pacote.TimeToLive.ToString();
                    var checksum = ipv4Pacote.Checksum;
                    var ischecksum = ipv4Pacote.ValidChecksum;

                    if (protocolo == "Tcp")
                    {
                        IPv4Header ipv4 = new IPv4Header();
                        ipv4.Protocol = protocolo;
                        ipv4.TotalLength = ipv4Pacote.TotalLength;
                        ipv4.Dscp = ipv4Pacote.DifferentiatedServices;
                        ipv4.Version = ipv4Pacote.Version;
                        ipv4.HeaderChecksum = ipv4Pacote.Checksum;
                        ipv4.HeaderLenght = ipv4Pacote.HeaderLength;
                        ipv4.Identification = ipv4Pacote.Id;
                        ipv4.Ttl = ipv4Pacote.TimeToLive;
                        ipv4.FragmentOffset = ipv4.FragmentOffset;
                        ipv4.SourceIP = ipv4.SourceIP;
                        ipv4.DestinationIP = ipv4.DestinationIP;

                        TcpPacket tcpPacote = p.Extract<TcpPacket>();

                        ipv4.Tcp = new TCP(tcpPacote.DestinationPort.ToString(),tcpPacote.SourcePort.ToString(), tcpPacote.Checksum.ToString());

                        pacoteList.Add(new Pacote(nrPacote, sourceAddress, destinationAddress, Enums.Protocolos.TCP, ipv4));
                    }



                    var portaDestino = "";
                    var portaOrigem = "";
                    var checsumTCP = "";

                    if (protocolo == "Tcp")
                    {
                        TcpPacket tcpPacote = p.Extract<TcpPacket>();

                        portaDestino = tcpPacote.DestinationPort.ToString();
                        portaOrigem = tcpPacote.SourcePort.ToString();
                        checsumTCP = tcpPacote.Checksum.ToString();

                    }

                }
                catch 
                { 
                }

                // Prints the time and length of each received packet
              


            }


        }
    }
}
