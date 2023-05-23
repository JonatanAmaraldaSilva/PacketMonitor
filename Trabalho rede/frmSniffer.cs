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

            this.incluiEventos();
        }

        private void incluiEventos()
        {

            this.dgvPacotes.CellClick += dgv_Click;
            this.FormClosing += MainForm_FormClosing;
        }

        private void StopThread()
        {
            thread.Suspend();
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.StopThread();
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
                //this.pacoteList.Clear();
                this.btnIniciarParar.Text = "Parar";
                inicia = true;
                var protocoloenum = (Enums.Protocolos)Enum.Parse(typeof(Enums.Protocolos), this.cmbProtocolos.SelectedValue.ToString());
                objCaptura = new CapturaPacotes(this.device, protocoloenum);
                thread = new Thread(() => objCaptura.iniciaCaptura(pacoteList, inicia));
                thread.Start();
                timer.Start();
            }
            else
            {
                this.btnIniciarParar.Text = "Iniciar";
                inicia = false;
                thread.Suspend();
                timer.Stop();
                //this.atualizaGrid();
            }

        }


        private void btnLimpa_Click(object sender, EventArgs e)
        {
            this.pacoteList.Clear();
            this.atualizaGrid();
        }

        private void dgv_Click(object sender, DataGridViewCellEventArgs e)
        {

            this.treeView1.Nodes.Clear();

            Pacote pacoteSel = this.pacoteList.Find(x=> x.NrPacote == Convert.ToInt32(this.dgvPacotes.CurrentRow.Cells["NrPacote"].Value));

           
            this.treeView1.Nodes.Add(string.Concat("Versão: ", pacoteSel.Ipv4.Version.ToString()));
            this.treeView1.Nodes.Add(string.Concat("Cabeçalho tamanho: ", pacoteSel.Ipv4.HeaderLenght.ToString()));
            this.treeView1.Nodes.Add(string.Concat("Tipo de serviço: ", pacoteSel.Ipv4.Typeofservice.ToString()));
            this.treeView1.Nodes.Add(string.Concat("Tamanho total: ", pacoteSel.Ipv4.TotalLength.ToString()));

            this.treeView1.Nodes.Add(string.Concat("Identificação: ", pacoteSel.Ipv4.Identification.ToString()));
            this.treeView1.Nodes.Add(string.Concat("Flags: ", pacoteSel.Ipv4.Flags.ToString()));
            this.treeView1.Nodes.Add(string.Concat("Fragment Offset: ", pacoteSel.Ipv4.FragmentOffset.ToString()));
            this.treeView1.Nodes.Add(string.Concat("Time to live: ", pacoteSel.Ipv4.Ttl.ToString()));

            TreeNode node;

            if (pacoteSel.Ipv4.Tcp is null == false)
            {
                node = new TreeNode(String.Concat("protocolo: ", "TCP"));
            }
            else
            {
                node = new TreeNode(String.Concat("protocolo: ", "UDP"));
            }

            node.Nodes.Add(string.Concat("porta origem: ", pacoteSel.Ipv4.Tcp.PortaOrigem.ToString()));
            node.Nodes.Add(string.Concat("porta destino: ", pacoteSel.Ipv4.Tcp.PortaDestino.ToString()));
            node.Nodes.Add(string.Concat("checksum: ", pacoteSel.Ipv4.Tcp.ChecsumTCP.ToString()));
            this.treeView1.Nodes.Add(node);

            this.treeView1.Nodes.Add(string.Concat("HeaderCheckSum: ", pacoteSel.Ipv4.HeaderChecksum.ToString()));
            this.treeView1.Nodes.Add(string.Concat("Endereço origem: ", pacoteSel.Ipv4.SourceIP.ToString()));
            this.treeView1.Nodes.Add(string.Concat("Endereço destino: ", pacoteSel.Ipv4.DestinationIP.ToString()));


            this.txtData.Text = pacoteSel.Ipv4.Data;
            //this.txtData.Text = pacoteSel.Ipv4.Tcp.Data;

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
