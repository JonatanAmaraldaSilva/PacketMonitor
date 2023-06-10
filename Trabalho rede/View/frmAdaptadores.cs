using SharpPcap;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Trabalho_rede
{
    public partial class frmAdaptadores : Form
    {

        List<Dispositivo> dispositivosLst = new List<Dispositivo>();
        CaptureDeviceList devices;

        public frmAdaptadores()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.dgvAdaptadores.CellDoubleClick += dataGridView1_CellDoubleClick;

            // Lista de dispositivos
            devices = CaptureDeviceList.Instance;

            int count = 0;
            foreach (ICaptureDevice dev in devices)
            {
                dispositivosLst.Add(new Dispositivo(count, dev.Description));
                count += 1;

            }

            this.criaGrid();
            this.atualizaGrid();

        }


        private void criaGrid()
        {

            dgvAdaptadores.Columns.AddRange(new DataGridViewColumn[]{
                                            new DataGridViewTextBoxColumn()
                                            {
                                                HeaderText = "Nr do Dispositivo",
                                                Name = "NrDispositivo",
                                                DataPropertyName = "NrDispositivo",
                                                Width = 70
                                            },
                                            new DataGridViewTextBoxColumn()
                                            {
                                                HeaderText = "Descrição do dispositivo",
                                                Name = "Descricao",
                                                DataPropertyName = "Descricao",
                                                Width = 471
                                            }});

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.inicia();
        }

        private void atualizaGrid()
        {
            // Define a origem de dados para o DataGridView
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dispositivosLst;

            // Atribui a origem de dados ao DataGridView
            this.dgvAdaptadores.DataSource = bindingSource;
        }

        private void inicia()
        {
            Dispositivo dev = dispositivosLst.Find(x => x.NrDispositivo == Convert.ToInt32(this.dgvAdaptadores.CurrentRow.Cells["NrDispositivo"].Value));
            ICaptureDevice device = devices[dev.NrDispositivo];

            var TelaSniffer = new frmSniffer(device);
            TelaSniffer.ShowDialog();


        }

    }


}
