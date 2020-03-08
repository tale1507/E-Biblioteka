namespace zaBibliotekara
{
    partial class NaCitanju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaCitanju));
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtDV = new System.Windows.Forms.DateTimePicker();
            this.dtDI = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCitalacID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKnjigaID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbpomoc = new System.Windows.Forms.Label();
            this.btnCheckCitalac = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnCisti = new System.Windows.Forms.Button();
            this.lbKID = new System.Windows.Forms.Label();
            this.lbCID = new System.Windows.Forms.Label();
            this.lbDV = new System.Windows.Forms.Label();
            this.lbDI = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOdeljenje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(24, 337);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 21);
            this.btnNazad.TabIndex = 48;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(255, 286);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(71, 35);
            this.btnView.TabIndex = 47;
            this.btnView.Text = "Prikaži";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(178, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 35);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(101, 287);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 35);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(24, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 35);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Unesi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtDV
            // 
            this.dtDV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDV.Location = new System.Drawing.Point(210, 187);
            this.dtDV.Name = "dtDV";
            this.dtDV.Size = new System.Drawing.Size(116, 20);
            this.dtDV.TabIndex = 56;
            // 
            // dtDI
            // 
            this.dtDI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDI.Location = new System.Drawing.Point(210, 142);
            this.dtDI.Name = "dtDI";
            this.dtDI.Size = new System.Drawing.Size(116, 20);
            this.dtDI.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "KnjigaID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "ČitalacID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Datum Iznajmljivanja";
            // 
            // tbCitalacID
            // 
            this.tbCitalacID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCitalacID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCitalacID.Location = new System.Drawing.Point(210, 98);
            this.tbCitalacID.Name = "tbCitalacID";
            this.tbCitalacID.Size = new System.Drawing.Size(116, 20);
            this.tbCitalacID.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Datum Vraćanja";
            // 
            // tbKnjigaID
            // 
            this.tbKnjigaID.Location = new System.Drawing.Point(210, 53);
            this.tbKnjigaID.Name = "tbKnjigaID";
            this.tbKnjigaID.Size = new System.Drawing.Size(116, 20);
            this.tbKnjigaID.TabIndex = 53;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(346, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(752, 271);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // lbpomoc
            // 
            this.lbpomoc.AutoSize = true;
            this.lbpomoc.Location = new System.Drawing.Point(210, 22);
            this.lbpomoc.Name = "lbpomoc";
            this.lbpomoc.Size = new System.Drawing.Size(0, 13);
            this.lbpomoc.TabIndex = 58;
            this.lbpomoc.Visible = false;
            // 
            // btnCheckCitalac
            // 
            this.btnCheckCitalac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCheckCitalac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCitalac.Location = new System.Drawing.Point(346, 400);
            this.btnCheckCitalac.Name = "btnCheckCitalac";
            this.btnCheckCitalac.Size = new System.Drawing.Size(163, 23);
            this.btnCheckCitalac.TabIndex = 59;
            this.btnCheckCitalac.Text = "Lista čitalaca";
            this.btnCheckCitalac.UseVisualStyleBackColor = true;
            this.btnCheckCitalac.Click += new System.EventHandler(this.btnCheckCitalac_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(346, 429);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(752, 272);
            this.dataGridView2.TabIndex = 60;
            this.dataGridView2.Visible = false;
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // btnCisti
            // 
            this.btnCisti.Location = new System.Drawing.Point(20, 228);
            this.btnCisti.Name = "btnCisti";
            this.btnCisti.Size = new System.Drawing.Size(75, 23);
            this.btnCisti.TabIndex = 61;
            this.btnCisti.Text = "Očisti Polja";
            this.btnCisti.UseVisualStyleBackColor = true;
            this.btnCisti.Click += new System.EventHandler(this.btnCisti_Click);
            // 
            // lbKID
            // 
            this.lbKID.AutoSize = true;
            this.lbKID.Location = new System.Drawing.Point(370, 13);
            this.lbKID.Name = "lbKID";
            this.lbKID.Size = new System.Drawing.Size(0, 13);
            this.lbKID.TabIndex = 62;
            this.lbKID.Visible = false;
            // 
            // lbCID
            // 
            this.lbCID.AutoSize = true;
            this.lbCID.Location = new System.Drawing.Point(422, 9);
            this.lbCID.Name = "lbCID";
            this.lbCID.Size = new System.Drawing.Size(0, 13);
            this.lbCID.TabIndex = 63;
            this.lbCID.Visible = false;
            // 
            // lbDV
            // 
            this.lbDV.AutoSize = true;
            this.lbDV.Location = new System.Drawing.Point(548, 13);
            this.lbDV.Name = "lbDV";
            this.lbDV.Size = new System.Drawing.Size(0, 13);
            this.lbDV.TabIndex = 64;
            this.lbDV.Visible = false;
            // 
            // lbDI
            // 
            this.lbDI.AutoSize = true;
            this.lbDI.Location = new System.Drawing.Point(490, 13);
            this.lbDI.Name = "lbDI";
            this.lbDI.Size = new System.Drawing.Size(0, 13);
            this.lbDI.TabIndex = 65;
            this.lbDI.Visible = false;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPretraga.Location = new System.Drawing.Point(820, 400);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(81, 23);
            this.btnPretraga.TabIndex = 68;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Pretraga po odeljenju";
            // 
            // tbOdeljenje
            // 
            this.tbOdeljenje.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbOdeljenje.Location = new System.Drawing.Point(779, 401);
            this.tbOdeljenje.Name = "tbOdeljenje";
            this.tbOdeljenje.Size = new System.Drawing.Size(35, 20);
            this.tbOdeljenje.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NaCitanju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 726);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOdeljenje);
            this.Controls.Add(this.lbDI);
            this.Controls.Add(this.lbDV);
            this.Controls.Add(this.lbCID);
            this.Controls.Add(this.lbKID);
            this.Controls.Add(this.btnCisti);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnCheckCitalac);
            this.Controls.Add(this.lbpomoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtDV);
            this.Controls.Add(this.dtDI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCitalacID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKnjigaID);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NaCitanju";
            this.Text = "Izdavanje";
            this.Load += new System.EventHandler(this.NaCitanju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtDV;
        private System.Windows.Forms.DateTimePicker dtDI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCitalacID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKnjigaID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbpomoc;
        private System.Windows.Forms.Button btnCheckCitalac;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnCisti;
        private System.Windows.Forms.Label lbKID;
        private System.Windows.Forms.Label lbCID;
        private System.Windows.Forms.Label lbDV;
        private System.Windows.Forms.Label lbDI;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOdeljenje;
        private System.Windows.Forms.Button button1;
    }
}