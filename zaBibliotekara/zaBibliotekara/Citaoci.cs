using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaBibliotekara
{
    public partial class Citaoci : Form
    {

        konekcija k = new konekcija();
        string univerzalniString = "Select DISTINCT * From Citalac where CitalacID!='0'";
        bool provera = false;
        public string ID_korisnika = null;
        public Citaoci(string id)
        {

            ID_korisnika = id;
            InitializeComponent();
 
        }


        private void btnNazad_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
       
        }

        private void Citaoci_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbID.Text) || String.IsNullOrEmpty(tbIme.Text) || String.IsNullOrEmpty(tbPrezime.Text))
            {
               MessageBox.Show("Morate uneti sva polja");

            }

            else
            {

              

                string naredba = "INSERT INTO Citalac (CitalacID,Ime,Prezime,GodinaUclanjenja,Odeljenje)VALUES('" + tbID.Text + "','" + tbIme.Text + "','" + tbPrezime.Text + "','" + tbGodinaUclanjenja.Text + "','" + tbOdeljenje.Text + "')";
                k.SaveUnos(naredba,out provera);
                if (provera == true)
                {
                    DateTime localDate = DateTime.Now;
                    string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "',  'Dodat Citalac = [ID= " + tbID.Text + ", Ime=" + tbIme.Text + ", Prezime=" + tbPrezime.Text + ", Godina Uclanjenja=" + tbGodinaUclanjenja.Text + ", Odeljenje=" + tbOdeljenje.Text + "]')";
                    k.SaveLog(aktivnostNaredba, out provera);
                }
            }
        }

        private void View_Click(object sender, EventArgs e)
        {

            string naredba = univerzalniString;
            k.View(naredba, dataGridView1);
   
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(lbpomoc.Text))
            {

            }
            else
            {
                
                DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite obrisati izabranog citaoca?", "Provera", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    string naredba = "Delete From Citalac WHERE CitalacID='" + tbID.Text + "'";
                    k.Delete(naredba, univerzalniString, dataGridView1, out provera);
                    if (provera == true)
                    {
                        DateTime localDate = DateTime.Now;
                        string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "',  'Obrisan Citalac = [ID= " + tbID.Text + ", Ime=" + tbIme.Text + ", Prezime=" + tbPrezime.Text + ", Godina Uclanjenja=" + tbGodinaUclanjenja.Text + ", Odeljenje=" + tbOdeljenje.Text + "]')";
                        k.SaveLog(aktivnostNaredba, out provera);

                        if (provera == true)
                        {
                            tbID.Text = "";

                            tbIme.Text = "";
                            tbOdeljenje.Text = "";
                            tbGodinaUclanjenja.Text = "";
                            lbpomoc.Text = "";
                            tbPrezime.Text = "";
                        }
                    }
                }else if (dr==DialogResult.No){ }
                    }

             
        }


        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lbpomoc.Text))
            {

            }
            else
            {
                string naredba = "UPDATE Citalac Set CitalacID='" + tbID.Text + "',Ime='" + tbIme.Text + "',Prezime='" + tbPrezime.Text + "',GodinaUclanjenja='"+tbGodinaUclanjenja.Text+"',Odeljenje='"+tbOdeljenje.Text+ "' WHERE CitalacID='" + lbpomoc.Text + "'";
                k.uPDATE(naredba, univerzalniString, dataGridView1);

                DateTime localDate = DateTime.Now;
                string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "',  'Izvrsena promena nad citaocem [ID= " + lbID.Text + ", Ime=" + lbIme.Text + ", Prezime=" + lbPrezime.Text + ", Godina Uclanjenja=" + lbGU.Text + ", Odeljenje=" + lbOdeljenje.Text + "]  u  [ID= " + tbID.Text + ", Ime=" + tbIme.Text + ", Prezime=" + tbPrezime.Text + ", Godina Uclanjenja=" + tbGodinaUclanjenja.Text + ", Odeljenje=" + tbOdeljenje.Text + "]')";
                k.SaveLog(aktivnostNaredba, out provera);

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lbpomoc.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbIme.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbPrezime.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tbGodinaUclanjenja.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbOdeljenje.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


                lbID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lbIme.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lbPrezime.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lbGU.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
             lbOdeljenje.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnCisti_Click(object sender, EventArgs e)
        {

            tbID.Text = "";

            tbIme.Text = "";
            tbOdeljenje.Text = "";
            tbGodinaUclanjenja.Text = "";
            lbpomoc.Text = "";
            tbPrezime.Text = "";
        }
    }
}
