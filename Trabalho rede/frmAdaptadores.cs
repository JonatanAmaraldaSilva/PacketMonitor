using SharpPcap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // Lista de dispositivos
           devices = CaptureDeviceList.Instance;

            int count = 0;
            foreach (ICaptureDevice dev in devices)
            {
                dispositivosLst.Add(new Dispositivo(count, dev.Description));
                count += 1;

            }
            this.atualizaGrid();

        }

        private void atualizaGrid()
        {
            // Define a origem de dados para o DataGridView
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dispositivosLst;

            // Atribui a origem de dados ao DataGridView
            this.dgvAdpatadores.DataSource = bindingSource;
        }

        private void dgvPacotes_CellDoubleClick()
        {
            Dispositivo dev = dispositivosLst.Find(x => x.NrDispositivo == Convert.ToInt32(this.dgvAdpatadores.CurrentRow.Cells["NrDispositivo"].Value));
            ICaptureDevice device = devices[dev.NrDispositivo];

            var TelaSniffer = new frmSniffer(device);
            TelaSniffer.ShowDialog();


        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.dgvPacotes_CellDoubleClick();
        }
    }


}
