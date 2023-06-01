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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPacotes = new System.Windows.Forms.DataGridView();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblAdaptador = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.lblProtocolos = new System.Windows.Forms.Label();
            this.cmbProtocolos = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacotes)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPacotes
            // 
            this.dgvPacotes.AllowUserToAddRows = false;
            this.dgvPacotes.AllowUserToDeleteRows = false;
            this.dgvPacotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacotes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPacotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacotes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPacotes.Location = new System.Drawing.Point(12, 98);
            this.dgvPacotes.Name = "dgvPacotes";
            this.dgvPacotes.ReadOnly = true;
            this.dgvPacotes.RowHeadersVisible = false;
            this.dgvPacotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacotes.Size = new System.Drawing.Size(818, 273);
            this.dgvPacotes.TabIndex = 0;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltros.Controls.Add(this.lblAdaptador);
            this.grpFiltros.Controls.Add(this.btnLimpa);
            this.grpFiltros.Controls.Add(this.btnIniciarParar);
            this.grpFiltros.Controls.Add(this.lblProtocolos);
            this.grpFiltros.Controls.Add(this.cmbProtocolos);
            this.grpFiltros.ForeColor = System.Drawing.Color.LightGray;
            this.grpFiltros.Location = new System.Drawing.Point(12, 4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(818, 77);
            this.grpFiltros.TabIndex = 1;
            this.grpFiltros.TabStop = false;
            // 
            // lblAdaptador
            // 
            this.lblAdaptador.AutoSize = true;
            this.lblAdaptador.BackColor = System.Drawing.Color.SlateGray;
            this.lblAdaptador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaptador.ForeColor = System.Drawing.Color.LightGray;
            this.lblAdaptador.Location = new System.Drawing.Point(376, 36);
            this.lblAdaptador.Name = "lblAdaptador";
            this.lblAdaptador.Size = new System.Drawing.Size(106, 24);
            this.lblAdaptador.TabIndex = 4;
            this.lblAdaptador.Text = "Adaptador";
            // 
            // btnLimpa
            // 
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.ForeColor = System.Drawing.Color.Black;
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
            this.btnIniciarParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarParar.ForeColor = System.Drawing.Color.Black;
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
            this.lblProtocolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtocolos.Location = new System.Drawing.Point(12, 16);
            this.lblProtocolos.Name = "lblProtocolos";
            this.lblProtocolos.Size = new System.Drawing.Size(68, 16);
            this.lblProtocolos.TabIndex = 1;
            this.lblProtocolos.Text = "Protocolo:";
            // 
            // cmbProtocolos
            // 
            this.cmbProtocolos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProtocolos.ForeColor = System.Drawing.Color.Black;
            this.cmbProtocolos.FormattingEnabled = true;
            this.cmbProtocolos.Location = new System.Drawing.Point(15, 39);
            this.cmbProtocolos.Name = "cmbProtocolos";
            this.cmbProtocolos.Size = new System.Drawing.Size(121, 24);
            this.cmbProtocolos.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(12, 377);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(453, 212);
            this.treeView1.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(481, 377);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(349, 211);
            this.txtData.TabIndex = 3;
            // 
            // frmSniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(842, 616);
            this.Controls.Add(this.txtData);
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
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtData;
    }
}

