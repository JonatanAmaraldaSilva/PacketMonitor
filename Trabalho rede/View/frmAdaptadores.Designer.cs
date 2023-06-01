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
            this.dgvAdaptadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdaptadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdaptadores
            // 
            this.dgvAdaptadores.AllowUserToAddRows = false;
            this.dgvAdaptadores.AllowUserToDeleteRows = false;
            this.dgvAdaptadores.AllowUserToOrderColumns = true;
            this.dgvAdaptadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdaptadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdaptadores.Location = new System.Drawing.Point(12, 22);
            this.dgvAdaptadores.Name = "dgvAdaptadores";
            this.dgvAdaptadores.ReadOnly = true;
            this.dgvAdaptadores.RowHeadersVisible = false;
            this.dgvAdaptadores.Size = new System.Drawing.Size(545, 325);
            this.dgvAdaptadores.TabIndex = 0;
            // 
            // frmAdaptadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 363);
            this.Controls.Add(this.dgvAdaptadores);
            this.KeyPreview = true;
            this.Name = "frmAdaptadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdapatores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdaptadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdaptadores;
    }
}