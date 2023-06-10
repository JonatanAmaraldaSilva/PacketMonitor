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
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms.VisualStyles;

namespace Trabalho_rede
{
    public class CapturaPacotes
    {
        private ICaptureDevice device;
        private Enums.Protocolos protocolo;
        private string filter = "";

        public ICaptureDevice Device { get => device; set => device = value; }
        public Enums.Protocolos Protocolo { get => protocolo; set => protocolo = value; }
        public string Filter { get => retornaFiltro(); }


        private string retornaFiltro()
        {
            switch (this.Protocolo)
            {
                case Enums.Protocolos.TCP:
                    return "ip and tcp";
                case Enums.Protocolos.UDP:
                    return "ip and udp";
                default:
                     return "";

            }
        }

        public CapturaPacotes(ICaptureDevice device, Enums.Protocolos protocolo)
        {
            this.Device = device;
            this.Protocolo = protocolo;
        }

        public void iniciaCaptura(List<Pacote> pacoteList, bool stop)
        {

            int readTime = 1000;
            device.Open(DeviceModes.Promiscuous, readTime);

            //filter = this.protocolo.ToString();
            device.Filter = this.Filter;

            PacketCapture e;

            int nrPacote = 1;

            while (device.GetNextPacket(out e) != null || stop == false)
            {
                try
                {
                    Packet pacote = Packet.ParsePacket(e.GetPacket().LinkLayerType, e.GetPacket().Data);
                    IPv4Packet ipv4Pacote = pacote.Extract<IPv4Packet>();

                    pacoteList.Add(new Pacote(nrPacote: nrPacote,
                                              pacote: pacote,
                                              hora: e.GetPacket().Timeval.Date.AddHours(-3),
                                              protocolo: (Enums.Protocolos)Enum.Parse(typeof(Enums.Protocolos), ipv4Pacote.Protocol.ToString().ToUpper()))); ;


                    nrPacote += 1;

                }
                catch
                {
                }

            }


        }
    }
}
