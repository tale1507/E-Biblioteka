namespace zaBibliotekara
{
    partial class Autori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autori));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbpomoc = new System.Windows.Forms.Label();
            this.lbPrijava = new System.Windows.Forms.Label();
            this.btnCisti = new System.Windows.Forms.Button();
            this.lbPomocIme = new System.Windows.Forms.Label();
            this.lbPomocPrezime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(371, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(354, 259);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(169, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 35);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(92, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 35);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(15, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 35);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Unesi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(165, 122);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(137, 20);
            this.tbPrezime.TabIndex = 23;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(165, 89);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(137, 20);
            this.tbIme.TabIndex = 22;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(165, 56);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(87, 20);
            this.tbID.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(246, 307);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(71, 35);
            this.btnView.TabIndex = 29;
            this.btnView.Text = "Prikaži";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(15, 358);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 21);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbpomoc
            // 
            this.lbpomoc.AutoSize = true;
            this.lbpomoc.Location = new System.Drawing.Point(226, 208);
            this.lbpomoc.Name = "lbpomoc";
            this.lbpomoc.Size = new System.Drawing.Size(0, 13);
            this.lbpomoc.TabIndex = 32;
            this.lbpomoc.Visible = false;
            // 
            // lbPrijava
            // 
            this.lbPrijava.AutoSize = true;
            this.lbPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrijava.ForeColor = System.Drawing.Color.Red;
            this.lbPrijava.Location = new System.Drawing.Point(12, 207);
            this.lbPrijava.Name = "lbPrijava";
            this.lbPrijava.Size = new System.Drawing.Size(0, 16);
            this.lbPrijava.TabIndex = 33;
            this.lbPrijava.Visible = false;
            // 
            // btnCisti
            // 
            this.btnCisti.Location = new System.Drawing.Point(12, 159);
            this.btnCisti.Name = "btnCisti";
            this.btnCisti.Size = new System.Drawing.Size(75, 23);
            this.btnCisti.TabIndex = 34;
            this.btnCisti.Text = "Očisti Polja";
            this.btnCisti.UseVisualStyleBackColor = true;
            this.btnCisti.Click += new System.EventHandler(this.btnCisti_Click);
            // 
            // lbPomocIme
            // 
            this.lbPomocIme.AutoSize = true;
            this.lbPomocIme.Location = new System.Drawing.Point(240, 239);
            this.lbPomocIme.Name = "lbPomocIme";
            this.lbPomocIme.Size = new System.Drawing.Size(0, 13);
            this.lbPomocIme.TabIndex = 35;
            this.lbPomocIme.Visible = false;
            // 
            // lbPomocPrezime
            // 
            this.lbPomocPrezime.AutoSize = true;
            this.lbPomocPrezime.Location = new System.Drawing.Point(232, 211);
            this.lbPomocPrezime.Name = "lbPomocPrezime";
            this.lbPomocPrezime.Size = new System.Drawing.Size(0, 13);
            this.lbPomocPrezime.TabIndex = 36;
            this.lbPomocPrezime.Visible = false;
            // 
            // Autori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 392);
            this.Controls.Add(this.lbPomocPrezime);
            this.Controls.Add(this.lbPomocIme);
            this.Controls.Add(this.btnCisti);
            this.Controls.Add(this.lbPrijava);
            this.Controls.Add(this.lbpomoc);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autori";
            this.Text = "Autori";
            this.Load += new System.EventHandler(this.Autori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbpomoc;
        private System.Windows.Forms.Label lbPrijava;
        private System.Windows.Forms.Button btnCisti;
        private System.Windows.Forms.Label lbPomocIme;
        private System.Windows.Forms.Label lbPomocPrezime;
    }
}