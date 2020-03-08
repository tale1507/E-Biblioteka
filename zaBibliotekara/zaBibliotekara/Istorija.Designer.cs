namespace zaBibliotekara
{
    partial class Istorija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Istorija));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Aktivnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeBibliotekara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrezimeBibliotekara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aktivnost,
            this.Vreme,
            this.Datum,
            this.ImeBibliotekara,
            this.PrezimeBibliotekara});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 601);
            this.dataGridView1.TabIndex = 0;
            // 
            // Aktivnost
            // 
            this.Aktivnost.DataPropertyName = "Aktivnost";
            this.Aktivnost.Frozen = true;
            this.Aktivnost.HeaderText = "Aktivnost";
            this.Aktivnost.Name = "Aktivnost";
            this.Aktivnost.ReadOnly = true;
            this.Aktivnost.Width = 650;
            // 
            // Vreme
            // 
            this.Vreme.DataPropertyName = "Vreme";
            this.Vreme.Frozen = true;
            this.Vreme.HeaderText = "Vreme";
            this.Vreme.Name = "Vreme";
            this.Vreme.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.Frozen = true;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // ImeBibliotekara
            // 
            this.ImeBibliotekara.DataPropertyName = "ImeBibliotekara";
            this.ImeBibliotekara.Frozen = true;
            this.ImeBibliotekara.HeaderText = "Ime";
            this.ImeBibliotekara.Name = "ImeBibliotekara";
            this.ImeBibliotekara.ReadOnly = true;
            // 
            // PrezimeBibliotekara
            // 
            this.PrezimeBibliotekara.DataPropertyName = "PrezimeBibliotekara";
            this.PrezimeBibliotekara.Frozen = true;
            this.PrezimeBibliotekara.HeaderText = "Prezime";
            this.PrezimeBibliotekara.Name = "PrezimeBibliotekara";
            this.PrezimeBibliotekara.ReadOnly = true;
            // 
            // Istorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 601);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Istorija";
            this.Text = "Istorija";
            this.Load += new System.EventHandler(this.Istorija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktivnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vreme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeBibliotekara;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrezimeBibliotekara;
    }
}