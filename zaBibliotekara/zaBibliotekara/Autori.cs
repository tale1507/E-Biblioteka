using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace zaBibliotekara
{
    public partial class Autori : Form
    {
        konekcija k = new konekcija();
        string univerzalniString = "Select DISTINCT * From Autor where AutorID!='0'";
        bool provera = false;
        private string ID_korisnika;


        public Autori(string id)
        {
            ID_korisnika = id; 
            InitializeComponent();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbID.Text) || String.IsNullOrEmpty(tbIme.Text) || String.IsNullOrEmpty(tbPrezime.Text))
            {
                MessageBox.Show("Morate uneti sva polja");

            }

            else
            {
                string naredba = "INSERT INTO Autor (AutorID,Ime,Prezime)VALUES('" + tbID.Text + "','" + tbIme.Text + "','" + tbPrezime.Text + "')";
                k.SaveUnos(naredba, out provera);

                if (provera == true)
                {
                   
                    DateTime localDate = DateTime.Now;
                    string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Dodat Autor = [ID=" + tbID.Text + ", ime=" + tbIme.Text + ", prezime=" + tbPrezime.Text + "] ')";
                    k.SaveLog(aktivnostNaredba, out provera);
                    
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
           
            string naredba = "Select DISTINCT* From Autor  where AutorID!='0'";
            k.View(naredba, dataGridView1);

            tbID.Text = "";

            tbIme.Text = "";

            tbPrezime.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           


            if (string.IsNullOrEmpty(lbpomoc.Text))
            {


            }else {

              


                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranog autora? ", "Provera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string naredba = "Delete From Autor WHERE AutorID='" + tbID.Text + "'";
                    k.Delete(naredba, univerzalniString, dataGridView1, out provera);
                    if (provera == true)
                    {
                        DateTime localDate = DateTime.Now;
                        string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Obrisan Autor = [ID=" + tbID.Text + ", ime=" + tbIme.Text + ", prezime=" + tbPrezime.Text + "] ')";
                        k.SaveLog(aktivnostNaredba, out provera);
                        tbID.Text = "";

                        tbIme.Text = "";

                        tbPrezime.Text = "";
                        

                    }
                }
                else if (dr == DialogResult.No)
                {

                }
            }


     
                        
            
    }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lbpomoc.Text))
            {

            }
            else
            {
                MessageBox.Show(""+lbpomoc.Text);
                string naredba = "UPDATE Autor Set AutorID='" + tbID.Text + "',Ime='" + tbIme.Text + "',Prezime='" + tbPrezime.Text + "' WHERE AutorID='" + lbpomoc.Text + "'";
                k.uPDATE(naredba, univerzalniString, dataGridView1);
                DateTime localDate = DateTime.Now;
               
                string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Izvrsena promena nad autorom [ID=" + lbpomoc.Text + ", Ime=" + lbPomocIme.Text + ", Prezime=" + lbPomocPrezime.Text + "]  u  [ID=" + tbID.Text + ", Ime=" + tbIme.Text + ", Prezime=" + tbPrezime.Text + "]')";
                k.SaveUnos(aktivnostNaredba, out provera);

            }
          
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            lbPomocIme.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            lbPomocPrezime.Text= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            lbpomoc.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbIme.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbPrezime.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Autori_Load(object sender, EventArgs e)
        {
         

        }

        private void btnCisti_Click(object sender, EventArgs e)
        {
            tbID.Text = "";

            tbIme.Text = "";

            tbPrezime.Text = "";
        }

      

   

        private void button1_Click(object sender, EventArgs e)
        {
          
           
        }
    }
}
