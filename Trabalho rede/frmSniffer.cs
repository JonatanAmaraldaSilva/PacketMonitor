using SharpPcap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;



namespace Trabalho_rede
{
    public partial class frmSniffer : Form
    {

        List<Pacote> pacoteList = new List<Pacote>();
        CapturaPacotes objCaptura;
        ICaptureDevice device;
        Thread thread;
        bool inicia = false;

        System.Timers.Timer timer = new System.Timers.Timer(1000);




        public frmSniffer(ICaptureDevice device)
        {
            InitializeComponent();
            this.device = device;
            this.lblAdaptador.Text = this.device.Description;
            this.MinimumSize = this.Size;
            timer.Elapsed += Timer_Elapsed;
            this.CriaCombos();
            dgvPacotes.CellClick += dgv_Click;

        }

        // Implementa o manipulador de eventos
        private  void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                this.atualizaGrid();
            }));
           
        }

        private void CriaCombos()
        {

            this.cmbProtocolos.DataSource = (Enums.Protocolos[])Enum.GetValues(typeof(Enums.Protocolos));
            this.cmbProtocolos.DisplayMember = "ToString";

        }

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            if (inicia == false)
            {
                this.btnIniciarParar.Text = "Parar";
                inicia = true;
                var protocoloenum = (Enums.Protocolos)Enum.Parse(typeof(Enums.Protocolos), this.cmbProtocolos.SelectedValue.ToString());
                objCaptura = new CapturaPacotes(this.device, protocoloenum);
                Thread thread = new Thread(() => objCaptura.iniciaCaptura(pacoteList, inicia));
                thread.Start();
                timer.Start();
            }
            else
            {
                this.btnIniciarParar.Text = "Iniciar";
                inicia = false;
                timer.Stop();
                //this.atualizaGrid();
            }

        }


        private void btnLimpa_Click(object sender, EventArgs e)
        {
            this.pacoteList.Clear();
        }

        private void dgv_Click(object sender, DataGridViewCellEventArgs e)
        {

            this.treeView1.Nodes.Clear();

            Pacote pacoteSel = this.pacoteList.Find(x=> x.NrPacote == Convert.ToInt32(this.dgvPacotes.CurrentRow.Cells["NrPacote"].Value));

           
            this.treeView1.Nodes.Add(string.Concat("versão: ", pacoteSel.Ipv4.Version.ToString()));
            this.treeView1.Nodes.Add(string.Concat("CabecalhoTamanho: ", pacoteSel.Ipv4.HeaderLenght.ToString()));
            this.treeView1.Nodes.Add(string.Concat("Identificação: ", pacoteSel.Ipv4.Identification.ToString()));

            this.treeView1.Nodes.Add(string.Concat("tempo de vida: ", pacoteSel.Ipv4.Ttl.ToString()));
            this.treeView1.Nodes.Add(string.Concat("checksum: ", pacoteSel.Ipv4.HeaderChecksum.ToString()));
            this.treeView1.Nodes.Add(string.Concat("endereço origem: ", pacoteSel.Ipv4.SourceIP.ToString()));
            this.treeView1.Nodes.Add(string.Concat("endereço destino: ", pacoteSel.Ipv4.DestinationIP.ToString()));
            this.treeView1.Nodes.Add(string.Concat("tamanho total: ", pacoteSel.Ipv4.TotalLength.ToString()));

            TreeNode node= new TreeNode(String.Concat("protocolo: ", "TCP"));

            node.Nodes.Add(string.Concat("porta origem: ", pacoteSel.Ipv4.Tcp.PortaOrigem.ToString()));
            node.Nodes.Add(string.Concat("porta destino: ", pacoteSel.Ipv4.Tcp.PortaDestino.ToString()));
            node.Nodes.Add(string.Concat("checksum: ", pacoteSel.Ipv4.Tcp.ChecsumTCP.ToString()));
            this.treeView1.Nodes.Add(node);
        }

            private void atualizaGrid()
        {
            // Define a origem de dados para o DataGridView
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = pacoteList;

            // Atribui a origem de dados ao DataGridView
            this.dgvPacotes.DataSource = bindingSource;
        }



    }



}
