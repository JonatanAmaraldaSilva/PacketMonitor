namespace Trabalho_rede
{
    partial class frmSniffer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPacotes = new System.Windows.Forms.DataGridView();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblAdaptador = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.lblProtocolos = new System.Windows.Forms.Label();
            this.cmbProtocolos = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacotes)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPacotes
            // 
            this.dgvPacotes.AllowUserToAddRows = false;
            this.dgvPacotes.AllowUserToDeleteRows = false;
            this.dgvPacotes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvPacotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacotes.Location = new System.Drawing.Point(12, 98);
            this.dgvPacotes.Name = "dgvPacotes";
            this.dgvPacotes.ReadOnly = true;
            this.dgvPacotes.RowHeadersVisible = false;
            this.dgvPacotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacotes.Size = new System.Drawing.Size(796, 273);
            this.dgvPacotes.TabIndex = 0;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblAdaptador);
            this.grpFiltros.Controls.Add(this.btnLimpa);
            this.grpFiltros.Controls.Add(this.btnIniciarParar);
            this.grpFiltros.Controls.Add(this.lblProtocolos);
            this.grpFiltros.Controls.Add(this.cmbProtocolos);
            this.grpFiltros.Location = new System.Drawing.Point(12, 4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(796, 77);
            this.grpFiltros.TabIndex = 1;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // lblAdaptador
            // 
            this.lblAdaptador.AutoSize = true;
            this.lblAdaptador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaptador.ForeColor = System.Drawing.Color.Gold;
            this.lblAdaptador.Location = new System.Drawing.Point(376, 36);
            this.lblAdaptador.Name = "lblAdaptador";
            this.lblAdaptador.Size = new System.Drawing.Size(106, 24);
            this.lblAdaptador.TabIndex = 4;
            this.lblAdaptador.Text = "Adaptador";
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(223, 39);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 3;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Location = new System.Drawing.Point(142, 39);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarParar.TabIndex = 2;
            this.btnIniciarParar.Text = "Inicia";
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
            // 
            // lblProtocolos
            // 
            this.lblProtocolos.AutoSize = true;
            this.lblProtocolos.Location = new System.Drawing.Point(12, 23);
            this.lblProtocolos.Name = "lblProtocolos";
            this.lblProtocolos.Size = new System.Drawing.Size(55, 13);
            this.lblProtocolos.TabIndex = 1;
            this.lblProtocolos.Text = "Protocolo:";
            // 
            // cmbProtocolos
            // 
            this.cmbProtocolos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocolos.FormattingEnabled = true;
            this.cmbProtocolos.Location = new System.Drawing.Point(15, 39);
            this.cmbProtocolos.Name = "cmbProtocolos";
            this.cmbProtocolos.Size = new System.Drawing.Size(121, 21);
            this.cmbProtocolos.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 392);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(445, 212);
            this.treeView1.TabIndex = 2;
            // 
            // frmSniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(842, 616);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.dgvPacotes);
            this.Name = "frmSniffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sniffer Rede";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacotes)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacotes;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblProtocolos;
        private System.Windows.Forms.ComboBox cmbProtocolos;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnIniciarParar;
        private System.Windows.Forms.Label lblAdaptador;
    }
}

