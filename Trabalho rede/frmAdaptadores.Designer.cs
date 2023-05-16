namespace Trabalho_rede
{
    partial class frmAdaptadores
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
            this.dgvAdpatadores = new System.Windows.Forms.DataGridView();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdpatadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdpatadores
            // 
            this.dgvAdpatadores.AllowUserToAddRows = false;
            this.dgvAdpatadores.AllowUserToDeleteRows = false;
            this.dgvAdpatadores.AllowUserToOrderColumns = true;
            this.dgvAdpatadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdpatadores.Location = new System.Drawing.Point(12, 22);
            this.dgvAdpatadores.Name = "dgvAdpatadores";
            this.dgvAdpatadores.ReadOnly = true;
            this.dgvAdpatadores.Size = new System.Drawing.Size(511, 325);
            this.dgvAdpatadores.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(160, 374);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // frmAdaptadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.dgvAdpatadores);
            this.KeyPreview = true;
            this.Name = "frmAdaptadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdapatores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdpatadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdpatadores;
        private System.Windows.Forms.Button btnIniciar;
    }
}