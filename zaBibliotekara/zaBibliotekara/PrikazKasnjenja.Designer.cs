namespace zaBibliotekara
{
    partial class PrikazKasnjenja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikazKasnjenja));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnView = new System.Windows.Forms.Button();
            this.lbObavestenje = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOdeljenje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 649);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // BtnView
            // 
            this.BtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.Location = new System.Drawing.Point(13, 13);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 1;
            this.BtnView.Text = "Prikaži";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // lbObavestenje
            // 
            this.lbObavestenje.AutoSize = true;
            this.lbObavestenje.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObavestenje.ForeColor = System.Drawing.Color.Black;
            this.lbObavestenje.Location = new System.Drawing.Point(12, 68);
            this.lbObavestenje.Name = "lbObavestenje";
            this.lbObavestenje.Size = new System.Drawing.Size(346, 23);
            this.lbObavestenje.TabIndex = 2;
            this.lbObavestenje.Text = "Ovaj čtalac kasni sa vraćanjem knjige--dan-a";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.Location = new System.Drawing.Point(671, 65);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(81, 23);
            this.btnPretraga.TabIndex = 25;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Pretraga po odeljenju";
            // 
            // tbOdeljenje
            // 
            this.tbOdeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOdeljenje.Location = new System.Drawing.Point(630, 66);
            this.tbOdeljenje.Name = "tbOdeljenje";
            this.tbOdeljenje.Size = new System.Drawing.Size(35, 22);
            this.tbOdeljenje.TabIndex = 23;
            // 
            // PrikazKasnjenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 755);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOdeljenje);
            this.Controls.Add(this.lbObavestenje);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrikazKasnjenja";
            this.Text = "PrikazKasnjenja";
            this.Load += new System.EventHandler(this.PrikazKasnjenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Label lbObavestenje;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOdeljenje;
    }
}