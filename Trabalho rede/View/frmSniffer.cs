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
using System.CodeDom;
using System.Reflection;

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

            this.montaTreeView(pacoteSel.Ipv4,this.treeView1.Nodes);
          
        }

        static bool IsPropriedadeSimples(PropertyInfo propriedade)
        {
            return propriedade.PropertyType.IsPrimitive || propriedade.PropertyType == typeof(string);
        }

        private void montaTreeView(object objeto, TreeNodeCollection tv)
        {
            foreach (PropertyInfo propInfo in objeto.GetType().GetProperties())
            {
                if (!IsPropriedadeSimples(propInfo))
                {                  
                    TreeNode node = new TreeNode(propInfo.Name.ToUpper());
                    this.montaTreeView(propInfo.GetValue(objeto), node.Nodes);
                    tv.Add(node);
                }
                else
                {
                    tv.Add(string.Format("{0}: {1}", propInfo.Name, propInfo.GetValue(objeto)));
                }     
            }
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
