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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSniffer));
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
            this.dgvPacotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvPacotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacotes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacotes.Location = new System.Drawing.Point(12, 92);
            this.dgvPacotes.Name = "dgvPacotes";
            this.dgvPacotes.ReadOnly = true;
            this.dgvPacotes.RowHeadersVisible = false;
            this.dgvPacotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacotes.Size = new System.Drawing.Size(623, 388);
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
            this.grpFiltros.Size = new System.Drawing.Size(1017, 77);
            this.grpFiltros.TabIndex = 1;
            this.grpFiltros.TabStop = false;
            // 
            // lblAdaptador
            // 
            this.lblAdaptador.AutoSize = true;
            this.lblAdaptador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lblAdaptador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaptador.ForeColor = System.Drawing.Color.LightGray;
            this.lblAdaptador.Location = new System.Drawing.Point(155, 37);
            this.lblAdaptador.Name = "lblAdaptador";
            this.lblAdaptador.Size = new System.Drawing.Size(106, 24);
            this.lblAdaptador.TabIndex = 4;
            this.lblAdaptador.Text = "Adaptador";
            // 
            // btnLimpa
            // 
            this.btnLimpa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(58)))));
            this.btnLimpa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(58)))));
            this.btnLimpa.FlatAppearance.BorderSize = 0;
            this.btnLimpa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(58)))));
            this.btnLimpa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(58)))));
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpa.Location = new System.Drawing.Point(939, 31);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(72, 30);
            this.btnLimpa.TabIndex = 3;
            this.btnLimpa.Text = "LIMPA";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnIniciarParar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnIniciarParar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnIniciarParar.FlatAppearance.BorderSize = 0;
            this.btnIniciarParar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnIniciarParar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnIniciarParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarParar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnIniciarParar.Location = new System.Drawing.Point(865, 31);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(68, 30);
            this.btnIniciarParar.TabIndex = 2;
            this.btnIniciarParar.Text = "INICIA";
            this.btnIniciarParar.UseVisualStyleBackColor = false;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
            // 
            // lblProtocolos
            // 
            this.lblProtocolos.AutoSize = true;
            this.lblProtocolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtocolos.Location = new System.Drawing.Point(12, 16);
            this.lblProtocolos.Name = "lblProtocolos";
            this.lblProtocolos.Size = new System.Drawing.Size(80, 20);
            this.lblProtocolos.TabIndex = 1;
            this.lblProtocolos.Text = "Protocolo:";
            // 
            // cmbProtocolos
            // 
            this.cmbProtocolos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbProtocolos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocolos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProtocolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProtocolos.ForeColor = System.Drawing.Color.White;
            this.cmbProtocolos.FormattingEnabled = true;
            this.cmbProtocolos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbProtocolos.Location = new System.Drawing.Point(15, 39);
            this.cmbProtocolos.Name = "cmbProtocolos";
            this.cmbProtocolos.Size = new System.Drawing.Size(121, 24);
            this.cmbProtocolos.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.Location = new System.Drawing.Point(650, 92);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(379, 388);
            this.treeView1.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(12, 492);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(1017, 105);
            this.txtData.TabIndex = 3;
            // 
            // frmSniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1041, 609);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.dgvPacotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

