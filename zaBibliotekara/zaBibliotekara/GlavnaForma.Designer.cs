namespace zaBibliotekara
{
    partial class GlavnaForma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.btnUnosCitaoca = new System.Windows.Forms.Button();
            this.btnUnosKnjige = new System.Windows.Forms.Button();
            this.btnUnosAutora = new System.Windows.Forms.Button();
            this.btnRez = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KnjigaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKnjigaID = new System.Windows.Forms.TextBox();
            this.tbCitalacID = new System.Windows.Forms.TextBox();
            this.gbUnos = new System.Windows.Forms.GroupBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOdeljenje = new System.Windows.Forms.TextBox();
            this.dtDV = new System.Windows.Forms.DateTimePicker();
            this.dtDI = new System.Windows.Forms.DateTimePicker();
            this.btnCheckCitalac = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnIzdati = new System.Windows.Forms.Button();
            this.gbRez = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPretragaRID = new System.Windows.Forms.Button();
            this.tbidRez = new System.Windows.Forms.TextBox();
            this.lbNaslov = new System.Windows.Forms.Label();
            this.lbrezID = new System.Windows.Forms.Label();
            this.lbKID = new System.Windows.Forms.Label();
            this.btnBrisanjeR = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnNaCitanju = new System.Windows.Forms.Button();
            this.btnKasnjenje = new System.Windows.Forms.Button();
            this.btnRefreshKasnjenje = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLog = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbKorisnik = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbObavestenje = new System.Windows.Forms.Label();
            this.gbPrijava = new System.Windows.Forms.GroupBox();
            this.gbDugmad = new System.Windows.Forms.GroupBox();
            this.novaSkolskaGodina = new System.Windows.Forms.Button();
            this.btnIstorija = new System.Windows.Forms.Button();
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbRez.SuspendLayout();
            this.gbKorisnik.SuspendLayout();
            this.gbPrijava.SuspendLayout();
            this.gbDugmad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnosCitaoca
            // 
            this.btnUnosCitaoca.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosCitaoca.Location = new System.Drawing.Point(0, 71);
            this.btnUnosCitaoca.Name = "btnUnosCitaoca";
            this.btnUnosCitaoca.Size = new System.Drawing.Size(111, 31);
            this.btnUnosCitaoca.TabIndex = 0;
            this.btnUnosCitaoca.Text = "Unos čitalaca";
            this.btnUnosCitaoca.UseVisualStyleBackColor = true;
            this.btnUnosCitaoca.Click += new System.EventHandler(this.btnUnosCitaoca_Click);
            // 
            // btnUnosKnjige
            // 
            this.btnUnosKnjige.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosKnjige.Location = new System.Drawing.Point(0, 143);
            this.btnUnosKnjige.Name = "btnUnosKnjige";
            this.btnUnosKnjige.Size = new System.Drawing.Size(111, 31);
            this.btnUnosKnjige.TabIndex = 1;
            this.btnUnosKnjige.Text = "Unos knjige";
            this.btnUnosKnjige.UseVisualStyleBackColor = true;
            this.btnUnosKnjige.Click += new System.EventHandler(this.btnUnosKnjige_Click);
            // 
            // btnUnosAutora
            // 
            this.btnUnosAutora.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosAutora.Location = new System.Drawing.Point(0, 107);
            this.btnUnosAutora.Name = "btnUnosAutora";
            this.btnUnosAutora.Size = new System.Drawing.Size(111, 31);
            this.btnUnosAutora.TabIndex = 2;
            this.btnUnosAutora.Text = "Unos autora";
            this.btnUnosAutora.UseVisualStyleBackColor = true;
            this.btnUnosAutora.Click += new System.EventHandler(this.btnUnosAutora_Click);
            // 
            // btnRez
            // 
            this.btnRez.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRez.Location = new System.Drawing.Point(0, 21);
            this.btnRez.Name = "btnRez";
            this.btnRez.Size = new System.Drawing.Size(111, 43);
            this.btnRez.TabIndex = 3;
            this.btnRez.Text = "Rezervacije";
            this.btnRez.UseVisualStyleBackColor = true;
            this.btnRez.Click += new System.EventHandler(this.btnRez_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KnjigaID,
            this.Column1,
            this.Naslov});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(9, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(391, 463);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // KnjigaID
            // 
            this.KnjigaID.DataPropertyName = "KnjigaID";
            this.KnjigaID.Frozen = true;
            this.KnjigaID.HeaderText = "KnjigaID";
            this.KnjigaID.Name = "KnjigaID";
            this.KnjigaID.ReadOnly = true;
            this.KnjigaID.Width = 70;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CitalacID";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Mat.Br.Čitaoca";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.Frozen = true;
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            this.Naslov.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "KnjigaID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "ČitalacID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum Iznajmljivanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum Vraćanja";
            // 
            // tbKnjigaID
            // 
            this.tbKnjigaID.Location = new System.Drawing.Point(200, 38);
            this.tbKnjigaID.Name = "tbKnjigaID";
            this.tbKnjigaID.Size = new System.Drawing.Size(116, 22);
            this.tbKnjigaID.TabIndex = 11;
            // 
            // tbCitalacID
            // 
            this.tbCitalacID.Location = new System.Drawing.Point(200, 82);
            this.tbCitalacID.Name = "tbCitalacID";
            this.tbCitalacID.Size = new System.Drawing.Size(116, 22);
            this.tbCitalacID.TabIndex = 12;
            // 
            // gbUnos
            // 
            this.gbUnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUnos.BackColor = System.Drawing.SystemColors.Info;
            this.gbUnos.Controls.Add(this.btnPretraga);
            this.gbUnos.Controls.Add(this.label5);
            this.gbUnos.Controls.Add(this.tbOdeljenje);
            this.gbUnos.Controls.Add(this.dtDV);
            this.gbUnos.Controls.Add(this.dtDI);
            this.gbUnos.Controls.Add(this.btnCheckCitalac);
            this.gbUnos.Controls.Add(this.dataGridView2);
            this.gbUnos.Controls.Add(this.btnIzdati);
            this.gbUnos.Controls.Add(this.label1);
            this.gbUnos.Controls.Add(this.label2);
            this.gbUnos.Controls.Add(this.label3);
            this.gbUnos.Controls.Add(this.tbCitalacID);
            this.gbUnos.Controls.Add(this.label4);
            this.gbUnos.Controls.Add(this.tbKnjigaID);
            this.gbUnos.Enabled = false;
            this.gbUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUnos.Location = new System.Drawing.Point(436, 18);
            this.gbUnos.Name = "gbUnos";
            this.gbUnos.Size = new System.Drawing.Size(569, 748);
            this.gbUnos.TabIndex = 15;
            this.gbUnos.TabStop = false;
            this.gbUnos.Text = "Izdavanje";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(479, 301);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(81, 23);
            this.btnPretraga.TabIndex = 22;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pretraga po odeljenju";
            // 
            // tbOdeljenje
            // 
            this.tbOdeljenje.Location = new System.Drawing.Point(438, 302);
            this.tbOdeljenje.Name = "tbOdeljenje";
            this.tbOdeljenje.Size = new System.Drawing.Size(35, 22);
            this.tbOdeljenje.TabIndex = 20;
            // 
            // dtDV
            // 
            this.dtDV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDV.Location = new System.Drawing.Point(200, 170);
            this.dtDV.Name = "dtDV";
            this.dtDV.Size = new System.Drawing.Size(116, 22);
            this.dtDV.TabIndex = 19;
            // 
            // dtDI
            // 
            this.dtDI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDI.Location = new System.Drawing.Point(200, 126);
            this.dtDI.Name = "dtDI";
            this.dtDI.Size = new System.Drawing.Size(116, 22);
            this.dtDI.TabIndex = 18;
            // 
            // btnCheckCitalac
            // 
            this.btnCheckCitalac.Location = new System.Drawing.Point(10, 302);
            this.btnCheckCitalac.Name = "btnCheckCitalac";
            this.btnCheckCitalac.Size = new System.Drawing.Size(159, 23);
            this.btnCheckCitalac.TabIndex = 17;
            this.btnCheckCitalac.Text = "lista čitalaca";
            this.btnCheckCitalac.UseVisualStyleBackColor = true;
            this.btnCheckCitalac.Click += new System.EventHandler(this.btnCheckCitalac_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(8, 331);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(555, 412);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.Visible = false;
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // btnIzdati
            // 
            this.btnIzdati.Location = new System.Drawing.Point(96, 208);
            this.btnIzdati.Name = "btnIzdati";
            this.btnIzdati.Size = new System.Drawing.Size(266, 27);
            this.btnIzdati.TabIndex = 15;
            this.btnIzdati.Text = "Potvrdi izdavanje knjige";
            this.btnIzdati.UseVisualStyleBackColor = true;
            this.btnIzdati.Click += new System.EventHandler(this.btnIzdati_Click);
            // 
            // gbRez
            // 
            this.gbRez.BackColor = System.Drawing.SystemColors.Info;
            this.gbRez.Controls.Add(this.label11);
            this.gbRez.Controls.Add(this.btnPretragaRID);
            this.gbRez.Controls.Add(this.tbidRez);
            this.gbRez.Controls.Add(this.lbNaslov);
            this.gbRez.Controls.Add(this.lbrezID);
            this.gbRez.Controls.Add(this.lbKID);
            this.gbRez.Controls.Add(this.btnBrisanjeR);
            this.gbRez.Controls.Add(this.dataGridView1);
            this.gbRez.Enabled = false;
            this.gbRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRez.Location = new System.Drawing.Point(3, 18);
            this.gbRez.Name = "gbRez";
            this.gbRez.Size = new System.Drawing.Size(427, 523);
            this.gbRez.TabIndex = 16;
            this.gbRez.TabStop = false;
            this.gbRez.Text = "Rezervacije";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Pretraga rezervacije:";
            // 
            // btnPretragaRID
            // 
            this.btnPretragaRID.Location = new System.Drawing.Point(232, 490);
            this.btnPretragaRID.Name = "btnPretragaRID";
            this.btnPretragaRID.Size = new System.Drawing.Size(75, 23);
            this.btnPretragaRID.TabIndex = 12;
            this.btnPretragaRID.Text = "Pretraži";
            this.btnPretragaRID.UseVisualStyleBackColor = true;
            this.btnPretragaRID.Click += new System.EventHandler(this.btnPretragaRID_Click);
            // 
            // tbidRez
            // 
            this.tbidRez.Location = new System.Drawing.Point(145, 490);
            this.tbidRez.Name = "tbidRez";
            this.tbidRez.Size = new System.Drawing.Size(81, 22);
            this.tbidRez.TabIndex = 11;
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.Location = new System.Drawing.Point(40, 208);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(0, 16);
            this.lbNaslov.TabIndex = 10;
            this.lbNaslov.Visible = false;
            // 
            // lbrezID
            // 
            this.lbrezID.AutoSize = true;
            this.lbrezID.Location = new System.Drawing.Point(40, 170);
            this.lbrezID.Name = "lbrezID";
            this.lbrezID.Size = new System.Drawing.Size(0, 16);
            this.lbrezID.TabIndex = 9;
            this.lbrezID.Visible = false;
            // 
            // lbKID
            // 
            this.lbKID.AutoSize = true;
            this.lbKID.Location = new System.Drawing.Point(40, 126);
            this.lbKID.Name = "lbKID";
            this.lbKID.Size = new System.Drawing.Size(0, 16);
            this.lbKID.TabIndex = 8;
            this.lbKID.Visible = false;
            // 
            // btnBrisanjeR
            // 
            this.btnBrisanjeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanjeR.Location = new System.Drawing.Point(313, 490);
            this.btnBrisanjeR.Name = "btnBrisanjeR";
            this.btnBrisanjeR.Size = new System.Drawing.Size(87, 23);
            this.btnBrisanjeR.TabIndex = 7;
            this.btnBrisanjeR.Text = "Obriši ";
            this.btnBrisanjeR.UseVisualStyleBackColor = true;
            this.btnBrisanjeR.Click += new System.EventHandler(this.btnBrisanjeR_Click);
            // 
            // btnNaCitanju
            // 
            this.btnNaCitanju.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaCitanju.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNaCitanju.Location = new System.Drawing.Point(117, 125);
            this.btnNaCitanju.Name = "btnNaCitanju";
            this.btnNaCitanju.Size = new System.Drawing.Size(111, 51);
            this.btnNaCitanju.TabIndex = 17;
            this.btnNaCitanju.Text = "  Izdavanje\r\nknjiga na čitanje";
            this.btnNaCitanju.UseVisualStyleBackColor = true;
            this.btnNaCitanju.Click += new System.EventHandler(this.btnNaCitanju_Click);
            // 
            // btnKasnjenje
            // 
            this.btnKasnjenje.BackColor = System.Drawing.Color.Transparent;
            this.btnKasnjenje.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKasnjenje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKasnjenje.Location = new System.Drawing.Point(250, 145);
            this.btnKasnjenje.Name = "btnKasnjenje";
            this.btnKasnjenje.Size = new System.Drawing.Size(143, 31);
            this.btnKasnjenje.TabIndex = 18;
            this.btnKasnjenje.Text = "Kasnjenje ()";
            this.btnKasnjenje.UseVisualStyleBackColor = false;
            this.btnKasnjenje.Click += new System.EventHandler(this.btnKasnjenje_Click);
            // 
            // btnRefreshKasnjenje
            // 
            this.btnRefreshKasnjenje.BackColor = System.Drawing.Color.White;
            this.btnRefreshKasnjenje.Location = new System.Drawing.Point(234, 165);
            this.btnRefreshKasnjenje.Name = "btnRefreshKasnjenje";
            this.btnRefreshKasnjenje.Size = new System.Drawing.Size(10, 10);
            this.btnRefreshKasnjenje.TabIndex = 19;
            this.btnRefreshKasnjenje.UseVisualStyleBackColor = false;
            this.btnRefreshKasnjenje.Click += new System.EventHandler(this.btnRefreshKasnjenje_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(85, 127);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(122, 23);
            this.btnLog.TabIndex = 35;
            this.btnLog.Text = "Registracija";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Šifra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Korisničko ime:";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(91, 66);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(167, 22);
            this.tbPass.TabIndex = 21;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(91, 35);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(167, 22);
            this.tbUsername.TabIndex = 20;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(57, 98);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(167, 23);
            this.btnLogIn.TabIndex = 34;
            this.btnLogIn.Text = "Prijavite se ";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Prezime:";
            // 
            // gbKorisnik
            // 
            this.gbKorisnik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKorisnik.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gbKorisnik.Controls.Add(this.label10);
            this.gbKorisnik.Controls.Add(this.button1);
            this.gbKorisnik.Controls.Add(this.lbPrezime);
            this.gbKorisnik.Controls.Add(this.lbIme);
            this.gbKorisnik.Controls.Add(this.label8);
            this.gbKorisnik.Controls.Add(this.label9);
            this.gbKorisnik.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKorisnik.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.gbKorisnik.Location = new System.Drawing.Point(1011, 18);
            this.gbKorisnik.Name = "gbKorisnik";
            this.gbKorisnik.Size = new System.Drawing.Size(258, 107);
            this.gbKorisnik.TabIndex = 41;
            this.gbKorisnik.TabStop = false;
            this.gbKorisnik.Text = "Korisnik";
            this.gbKorisnik.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LawnGreen;
            this.label10.Location = new System.Drawing.Point(189, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 37);
            this.label10.TabIndex = 44;
            this.label10.Text = "•";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(57, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Odjavi se";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrezime.Location = new System.Drawing.Point(64, 53);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(0, 16);
            this.lbPrezime.TabIndex = 42;
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIme.Location = new System.Drawing.Point(64, 30);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(0, 16);
            this.lbIme.TabIndex = 41;
            // 
            // lbObavestenje
            // 
            this.lbObavestenje.AutoSize = true;
            this.lbObavestenje.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObavestenje.ForeColor = System.Drawing.Color.Red;
            this.lbObavestenje.Location = new System.Drawing.Point(8, 175);
            this.lbObavestenje.Name = "lbObavestenje";
            this.lbObavestenje.Size = new System.Drawing.Size(0, 16);
            this.lbObavestenje.TabIndex = 42;
            // 
            // gbPrijava
            // 
            this.gbPrijava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPrijava.BackColor = System.Drawing.SystemColors.Info;
            this.gbPrijava.Controls.Add(this.tbPass);
            this.gbPrijava.Controls.Add(this.lbObavestenje);
            this.gbPrijava.Controls.Add(this.btnLog);
            this.gbPrijava.Controls.Add(this.btnLogIn);
            this.gbPrijava.Controls.Add(this.label7);
            this.gbPrijava.Controls.Add(this.tbUsername);
            this.gbPrijava.Controls.Add(this.label6);
            this.gbPrijava.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrijava.Location = new System.Drawing.Point(1011, 18);
            this.gbPrijava.Name = "gbPrijava";
            this.gbPrijava.Size = new System.Drawing.Size(264, 211);
            this.gbPrijava.TabIndex = 43;
            this.gbPrijava.TabStop = false;
            this.gbPrijava.Text = "Prijavljivanje";
            // 
            // gbDugmad
            // 
            this.gbDugmad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDugmad.BackColor = System.Drawing.SystemColors.Info;
            this.gbDugmad.Controls.Add(this.novaSkolskaGodina);
            this.gbDugmad.Controls.Add(this.btnIstorija);
            this.gbDugmad.Controls.Add(this.btnRez);
            this.gbDugmad.Controls.Add(this.btnUnosCitaoca);
            this.gbDugmad.Controls.Add(this.btnRefreshKasnjenje);
            this.gbDugmad.Controls.Add(this.btnUnosKnjige);
            this.gbDugmad.Controls.Add(this.btnKasnjenje);
            this.gbDugmad.Controls.Add(this.btnUnosAutora);
            this.gbDugmad.Controls.Add(this.btnNaCitanju);
            this.gbDugmad.Enabled = false;
            this.gbDugmad.Location = new System.Drawing.Point(3, 547);
            this.gbDugmad.Name = "gbDugmad";
            this.gbDugmad.Size = new System.Drawing.Size(427, 219);
            this.gbDugmad.TabIndex = 44;
            this.gbDugmad.TabStop = false;
            // 
            // novaSkolskaGodina
            // 
            this.novaSkolskaGodina.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novaSkolskaGodina.Location = new System.Drawing.Point(2, 181);
            this.novaSkolskaGodina.Name = "novaSkolskaGodina";
            this.novaSkolskaGodina.Size = new System.Drawing.Size(393, 29);
            this.novaSkolskaGodina.TabIndex = 45;
            this.novaSkolskaGodina.Text = "Ažuriranje odeljenja i čuvanje baze\r\n\r\n";
            this.novaSkolskaGodina.UseVisualStyleBackColor = true;
            this.novaSkolskaGodina.Click += new System.EventHandler(this.novaSkolskaGodina_Click);
            // 
            // btnIstorija
            // 
            this.btnIstorija.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIstorija.Location = new System.Drawing.Point(270, 10);
            this.btnIstorija.Name = "btnIstorija";
            this.btnIstorija.Size = new System.Drawing.Size(123, 31);
            this.btnIstorija.TabIndex = 20;
            this.btnIstorija.Text = "Istorija";
            this.btnIstorija.UseVisualStyleBackColor = true;
            this.btnIstorija.Click += new System.EventHandler(this.btnIstorija_Click);
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataMember = "Rezervacije";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1011, 725);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 41);
            this.button2.TabIndex = 45;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1276, 778);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbDugmad);
            this.Controls.Add(this.gbPrijava);
            this.Controls.Add(this.gbKorisnik);
            this.Controls.Add(this.gbRez);
            this.Controls.Add(this.gbUnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlavnaForma";
            this.Text = "Biblioteka";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GlavnaForma_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbUnos.ResumeLayout(false);
            this.gbUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbRez.ResumeLayout(false);
            this.gbRez.PerformLayout();
            this.gbKorisnik.ResumeLayout(false);
            this.gbKorisnik.PerformLayout();
            this.gbPrijava.ResumeLayout(false);
            this.gbPrijava.PerformLayout();
            this.gbDugmad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnosCitaoca;
        private System.Windows.Forms.Button btnUnosKnjige;
        private System.Windows.Forms.Button btnUnosAutora;
        private System.Windows.Forms.Button btnRez;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKnjigaID;
        private System.Windows.Forms.TextBox tbCitalacID;
        private System.Windows.Forms.GroupBox gbUnos;
        private System.Windows.Forms.GroupBox gbRez;
        private System.Windows.Forms.Button btnIzdati;
        private System.Windows.Forms.Button btnCheckCitalac;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dtDI;
        private System.Windows.Forms.DateTimePicker dtDV;
       
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
    
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBrisanjeR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnNaCitanju;
        private System.Windows.Forms.Button btnKasnjenje;
        private System.Windows.Forms.Button btnRefreshKasnjenje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOdeljenje;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbKorisnik;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbObavestenje;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbPrijava;
        private System.Windows.Forms.GroupBox gbDugmad;
        private System.Windows.Forms.Button btnIstorija;
        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Label lbrezID;
        private System.Windows.Forms.Label lbKID;
        private System.Windows.Forms.TextBox tbidRez;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPretragaRID;
        private System.Windows.Forms.Button novaSkolskaGodina;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnjigaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.Button button2;
    }
}

