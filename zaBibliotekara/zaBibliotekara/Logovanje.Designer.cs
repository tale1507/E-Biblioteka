namespace zaBibliotekara
{
    partial class Logovanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logovanje));
            this.btnExt = new System.Windows.Forms.Button();
            this.tbRUsername = new System.Windows.Forms.TextBox();
            this.tbRPass = new System.Windows.Forms.TextBox();
            this.tbRPass2 = new System.Windows.Forms.TextBox();
            this.tbREmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.lbProvera = new System.Windows.Forms.Label();
            this.tbRIme = new System.Windows.Forms.TextBox();
            this.tbRPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExt
            // 
            this.btnExt.Location = new System.Drawing.Point(11, 309);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(75, 23);
            this.btnExt.TabIndex = 41;
            this.btnExt.Text = "Izadji";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // tbRUsername
            // 
            this.tbRUsername.Location = new System.Drawing.Point(93, 48);
            this.tbRUsername.Name = "tbRUsername";
            this.tbRUsername.Size = new System.Drawing.Size(181, 20);
            this.tbRUsername.TabIndex = 34;
            // 
            // tbRPass
            // 
            this.tbRPass.Location = new System.Drawing.Point(93, 144);
            this.tbRPass.Name = "tbRPass";
            this.tbRPass.Size = new System.Drawing.Size(181, 20);
            this.tbRPass.TabIndex = 37;
            this.tbRPass.UseSystemPasswordChar = true;
            // 
            // tbRPass2
            // 
            this.tbRPass2.Location = new System.Drawing.Point(93, 176);
            this.tbRPass2.Name = "tbRPass2";
            this.tbRPass2.Size = new System.Drawing.Size(181, 20);
            this.tbRPass2.TabIndex = 38;
            this.tbRPass2.UseSystemPasswordChar = true;
            // 
            // tbREmail
            // 
            this.tbREmail.Location = new System.Drawing.Point(93, 208);
            this.tbREmail.Name = "tbREmail";
            this.tbREmail.Size = new System.Drawing.Size(181, 20);
            this.tbREmail.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Šifra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Potvrdite šifru:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "E-mail:";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(93, 254);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(84, 23);
            this.btnReg.TabIndex = 40;
            this.btnReg.Text = "Registrujte se ";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lbProvera
            // 
            this.lbProvera.AutoSize = true;
            this.lbProvera.ForeColor = System.Drawing.Color.Red;
            this.lbProvera.Location = new System.Drawing.Point(12, 15);
            this.lbProvera.Name = "lbProvera";
            this.lbProvera.Size = new System.Drawing.Size(0, 13);
            this.lbProvera.TabIndex = 43;
            // 
            // tbRIme
            // 
            this.tbRIme.Location = new System.Drawing.Point(93, 80);
            this.tbRIme.Name = "tbRIme";
            this.tbRIme.Size = new System.Drawing.Size(181, 20);
            this.tbRIme.TabIndex = 35;
            // 
            // tbRPrezime
            // 
            this.tbRPrezime.Location = new System.Drawing.Point(93, 112);
            this.tbRPrezime.Name = "tbRPrezime";
            this.tbRPrezime.Size = new System.Drawing.Size(181, 20);
            this.tbRPrezime.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Ime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Prezime:";
            // 
            // Logovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 344);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRPrezime);
            this.Controls.Add(this.tbRIme);
            this.Controls.Add(this.lbProvera);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbREmail);
            this.Controls.Add(this.tbRPass2);
            this.Controls.Add(this.tbRPass);
            this.Controls.Add(this.tbRUsername);
            this.Controls.Add(this.btnExt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logovanje";
            this.Text = "Registrovanje";
            this.Load += new System.EventHandler(this.Logovanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.TextBox tbRUsername;
        private System.Windows.Forms.TextBox tbRPass;
        private System.Windows.Forms.TextBox tbRPass2;
        private System.Windows.Forms.TextBox tbREmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lbProvera;
        private System.Windows.Forms.TextBox tbRIme;
        private System.Windows.Forms.TextBox tbRPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}