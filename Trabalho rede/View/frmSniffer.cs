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
        int nrPacote = 1;

        public frmSniffer(ICaptureDevice device)
        {
            InitializeComponent();

            this.MinimumSize = this.Size;
            this.device = device;
            this.lblAdaptador.Text = this.device.Description;       
            timer.Elapsed += Timer_Elapsed;

            this.CriaCombos();
            this.montaGrid();
            this.incluiEventos();
        }


        private void montaGrid()
        {
            this.dgvPacotes.AutoGenerateColumns = false;
            dgvPacotes.Columns.AddRange(new DataGridViewColumn[]{
                                            new DataGridViewTextBoxColumn()
                                            {
                                                HeaderText = "Nr. Pacote",
                                                Name = "NrPacote",
                                                DataPropertyName = "NrPacote",
                                                Width = 100
                                            },
                                            new DataGridViewTextBoxColumn()
                                            {
                                                HeaderText = "Hora",
                                                Name = "Hora",
                                                DataPropertyName = "Hora",
                                                DefaultCellStyle = new DataGridViewCellStyle{ Format ="HH:mm:ss.fff"} ,
                                                Width = 100
                                            },
                                            new DataGridViewTextBoxColumn()
                                            {
                                                HeaderText = "Fonte",
                                                Name = "Fonte",
                                                DataPropertyName = "Fonte",
                                                Width = 120
                                            },
                                            new DataGridViewTextBoxColumn()
                                            {
                                                HeaderText = "Destino",
                                                Name = "Destino",
                                                DataPropertyName = "Destino",
                                                Width = 120
                                            },
                                            new DataGridViewTextBoxColumn()
                                            {
                                                HeaderText = "Protocolo",
                                                Name = "Protocolo",
                                                DataPropertyName = "Protocolo",
                                                Width = 100
                                            }                                           
                                            });
        }

        private void incluiEventos()
        {

            this.dgvPacotes.CellClick += dgv_Click;
            this.FormClosing += MainForm_FormClosing;
        }

        private void StopThread()
        {
            timer.Stop();
            timer.Elapsed -= Timer_Elapsed;
            thread.Abort();
            thread.Join();
         
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

                objCaptura = new CapturaPacotes(device: this.device, 
                                                protocolo: protocoloenum);

                thread = new Thread(() => objCaptura.iniciaCaptura(pacoteList: pacoteList,
                                                                   stop: inicia,
                                                                   nrPacote: ref this.nrPacote));

                thread.Start();
                timer.Start();
            }
            else
            {
                this.btnIniciarParar.Text = "Iniciar";
                inicia = false;
                //thread.Suspend();
                timer.Stop();
                //this.atualizaGrid();
            }

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            this.nrPacote = 1;
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
                    if (propInfo.GetValue(objeto) != null)
                    {
                        TreeNode node = new TreeNode(propInfo.Name.ToUpper());
                        this.montaTreeView(propInfo.GetValue(objeto), node.Nodes);
                        tv.Add(node);
                    }
                    
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
