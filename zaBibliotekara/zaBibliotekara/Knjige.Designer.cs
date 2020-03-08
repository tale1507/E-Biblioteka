namespace zaBibliotekara
{
    partial class Knjige
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Knjige));
            this.btnNazad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPolica = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAutorID = new System.Windows.Forms.TextBox();
            this.tbAutorIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOblastKnjige = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lbpomoc = new System.Windows.Forms.Label();
            this.btnCisti = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNaslov = new System.Windows.Forms.Label();
            this.lbMestoP = new System.Windows.Forms.Label();
            this.lbOblastK = new System.Windows.Forms.Label();
            this.lbAutorID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(21, 340);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 21);
            this.btnNazad.TabIndex = 43;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(376, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 349);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KnjigaID";
            this.Column1.HeaderText = "KnjigaID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Naslov";
            this.Column2.HeaderText = "Naslov";
            this.Column2.Name = "Column2";
            this.Column2.Width = 340;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MestoPolice";
            this.Column3.HeaderText = "Mesto police";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "AutorID";
            this.Column4.HeaderText = "AutorID";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OB";
            this.Column5.HeaderText = "Oblast knjige";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Dost";
            this.Column6.HeaderText = "Dostupnost";
            this.Column6.Name = "Column6";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(252, 289);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(71, 35);
            this.btnView.TabIndex = 41;
            this.btnView.Text = "Prikaži";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(175, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 35);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(98, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 35);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(21, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 35);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Unesi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPolica
            // 
            this.tbPolica.Location = new System.Drawing.Point(171, 106);
            this.tbPolica.Name = "tbPolica";
            this.tbPolica.Size = new System.Drawing.Size(137, 20);
            this.tbPolica.TabIndex = 3;
            // 
            // tbNaziv
            // 
            this.tbNaziv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbNaziv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNaziv.Location = new System.Drawing.Point(171, 71);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(137, 20);
            this.tbNaziv.TabIndex = 2;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(171, 38);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(87, 20);
            this.tbID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mesto Polica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Naslov";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Autor ID";
            // 
            // tbAutorID
            // 
            this.tbAutorID.Enabled = false;
            this.tbAutorID.Location = new System.Drawing.Point(174, 216);
            this.tbAutorID.Name = "tbAutorID";
            this.tbAutorID.Size = new System.Drawing.Size(137, 20);
            this.tbAutorID.TabIndex = 7;
            // 
            // tbAutorIP
            // 
            this.tbAutorIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbAutorIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbAutorIP.Location = new System.Drawing.Point(174, 180);
            this.tbAutorIP.Name = "tbAutorIP";
            this.tbAutorIP.Size = new System.Drawing.Size(137, 20);
            this.tbAutorIP.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Autor";
            // 
            // tbOblastKnjige
            // 
            this.tbOblastKnjige.Location = new System.Drawing.Point(171, 144);
            this.tbOblastKnjige.Name = "tbOblastKnjige";
            this.tbOblastKnjige.Size = new System.Drawing.Size(137, 20);
            this.tbOblastKnjige.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Oblast Knjiga";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(320, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 20);
            this.button5.TabIndex = 6;
            this.button5.Text = "Check";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbpomoc
            // 
            this.lbpomoc.AutoSize = true;
            this.lbpomoc.Location = new System.Drawing.Point(320, 26);
            this.lbpomoc.Name = "lbpomoc";
            this.lbpomoc.Size = new System.Drawing.Size(0, 13);
            this.lbpomoc.TabIndex = 53;
            this.lbpomoc.Visible = false;
            // 
            // btnCisti
            // 
            this.btnCisti.Location = new System.Drawing.Point(21, 247);
            this.btnCisti.Name = "btnCisti";
            this.btnCisti.Size = new System.Drawing.Size(75, 23);
            this.btnCisti.TabIndex = 54;
            this.btnCisti.Text = "Očisti polja";
            this.btnCisti.UseVisualStyleBackColor = true;
            this.btnCisti.Click += new System.EventHandler(this.btnCisti_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(320, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 55;
            this.lbID.Visible = false;
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.Location = new System.Drawing.Point(320, 38);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(0, 13);
            this.lbNaslov.TabIndex = 56;
            this.lbNaslov.Visible = false;
            // 
            // lbMestoP
            // 
            this.lbMestoP.AutoSize = true;
            this.lbMestoP.Location = new System.Drawing.Point(320, 60);
            this.lbMestoP.Name = "lbMestoP";
            this.lbMestoP.Size = new System.Drawing.Size(0, 13);
            this.lbMestoP.TabIndex = 57;
            this.lbMestoP.Visible = false;
            // 
            // lbOblastK
            // 
            this.lbOblastK.AutoSize = true;
            this.lbOblastK.Location = new System.Drawing.Point(320, 88);
            this.lbOblastK.Name = "lbOblastK";
            this.lbOblastK.Size = new System.Drawing.Size(0, 13);
            this.lbOblastK.TabIndex = 58;
            this.lbOblastK.Visible = false;
            // 
            // lbAutorID
            // 
            this.lbAutorID.AutoSize = true;
            this.lbAutorID.Location = new System.Drawing.Point(320, 112);
            this.lbAutorID.Name = "lbAutorID";
            this.lbAutorID.Size = new System.Drawing.Size(0, 13);
            this.lbAutorID.TabIndex = 59;
            this.lbAutorID.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.Location = new System.Drawing.Point(320, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 379);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbAutorID);
            this.Controls.Add(this.lbOblastK);
            this.Controls.Add(this.lbMestoP);
            this.Controls.Add(this.lbNaslov);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnCisti);
            this.Controls.Add(this.lbpomoc);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tbOblastKnjige);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAutorIP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAutorID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPolica);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.Load += new System.EventHandler(this.Knjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPolica;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAutorID;
        private System.Windows.Forms.TextBox tbAutorIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOblastKnjige;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbpomoc;
        private System.Windows.Forms.Button btnCisti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Label lbMestoP;
        private System.Windows.Forms.Label lbOblastK;
        private System.Windows.Forms.Label lbAutorID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}