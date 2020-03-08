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
    public partial class Knjige : Form
    {

        private string ID_korisnika;
        konekcija k = new konekcija();
        string univerzalniString  ="SELECT DISTINCT KnjigaID as KnjigaID,Naziv as Naslov,MestoPolica as MestoPolice,AutorID as AutorID,OblastKnjige as OB,Dostupnost as Dost FROM Knjiga where KnjigaID!='0'";
        bool provera = false;
        public Knjige(string id)
        {
            ID_korisnika = id;
            InitializeComponent();

       
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            k.autoC(tbAutorIP);
            string naredba1 = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Dostupna' FROM Knjiga INNER JOIN NaCitanju ON NaCitanju.KnjigaID != Knjiga.KnjigaID UPDATE Knjiga SET Knjiga.Dostupnost = 'Izdata' FROM Knjiga INNER JOIN NaCitanju ON NaCitanju.KnjigaID = Knjiga.KnjigaID";
            k.updateDostupnosti(naredba1);
            string updateRez = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Rezervisana' FROM Knjiga INNER JOIN Rezervacije ON Rezervacije.KnjigaID = Knjiga.KnjigaID";
            k.updateDostupnosti(updateRez);
        
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
          

            this.Hide();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbID.Text) || String.IsNullOrEmpty(tbNaziv.Text) )
            {
                MessageBox.Show("Polja ID i Naslov moraju biti popunjena");

            }

            else
            {
                
                string naredba = "INSERT INTO Knjiga (KnjigaID,Naziv,MestoPolica,AutorID,OblastKnjige) VALUES('" + tbID.Text + "','" + tbNaziv.Text + "','" + tbPolica.Text + "','" + tbAutorID.Text + "','" + tbOblastKnjige.Text + "')";
                k.SaveUnos(naredba, out provera);
                if (provera == true)
                {
                  
                        DateTime localDate = DateTime.Now;
                        string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Dodata Knjiga [ID=" + tbID.Text + ", Naslov=" + tbNaziv.Text + ", mesto polica=" + tbPolica.Text + ", oblast knjiga=" + tbOblastKnjige.Text + ", autorID=" + tbAutorID.Text + "]')";
                        k.SaveLog(aktivnostNaredba, out provera);
                 
                    tbID.Text = "";

                    tbNaziv.Text = "";

                    tbAutorID.Text = "";
                    tbPolica.Text = "";
                    tbOblastKnjige.Text = "";
                    tbAutorIP.Text = "";

                }
        

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string id =null;
                string ime, prezime;
                string naredba;
                int index = tbAutorIP.Text.IndexOf(" ");
                ime = tbAutorIP.Text.Substring(0, index);
                prezime = tbAutorIP.Text.Substring(index + 1);

                naredba = "SELECT AutorID From Autor where Ime='" + ime + "' AND Prezime='" + prezime + "'";

                k.View_p(naredba,out id);

                tbAutorID.Text = id;
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR " + ex.GetHashCode());
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tbAutorIP.Text == "")
            {

            }
            else
            {

                tbAutorID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {



            k.autoC(tbAutorIP);
            string naredba1 = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Dostupna' FROM Knjiga INNER JOIN NaCitanju ON NaCitanju.KnjigaID != Knjiga.KnjigaID UPDATE Knjiga SET Knjiga.Dostupnost = 'Izdata' FROM Knjiga INNER JOIN NaCitanju ON NaCitanju.KnjigaID = Knjiga.KnjigaID";
            k.updateDostupnosti(naredba1);
            string updateRez = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Rezervisana' FROM Knjiga INNER JOIN Rezervacije ON Rezervacije.KnjigaID = Knjiga.KnjigaID";
            k.updateDostupnosti(updateRez);

            string naredba = "SELECT DISTINCT KnjigaID as KnjigaID,Naziv as Naslov,MestoPolica as MestoPolice,AutorID as AutorID,OblastKnjige as OB,Dostupnost as Dost  FROM Knjiga where KnjigaID!='0'";
            k.View(naredba, dataGridView1);
           
    
        }

    

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbAutorIP.Text == "")
            {

                lbID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lbNaslov.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lbMestoP.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lbOblastK.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                lbAutorID.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                lbpomoc.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbNaziv.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbPolica.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tbOblastKnjige.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tbAutorID.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            else { } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lbpomoc.Text))
            {

            }
            else
            {
                DateTime localDate=DateTime.Now;

               
                DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite obrisati izabranu knjigu","Provera",MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string naredba = "Delete From Knjiga WHERE KnjigaID='" + tbID.Text + "'";
                    k.Delete(naredba, univerzalniString, dataGridView1, out provera);
                    if (provera == true)
                    {
                        string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Obrisana Knjiga = [ID=" + tbID.Text + ", Naslov=" + tbNaziv.Text + ", mesto polica=" + tbPolica.Text + ", oblast knjiga=" + tbOblastKnjige.Text + ", autorID=" + tbAutorID.Text + "]')";

                        k.SaveLog(aktivnostNaredba, out provera);
                        tbID.Text = "";

                        tbNaziv.Text = "";

                        tbAutorID.Text = "";
                        tbPolica.Text = "";
                        tbOblastKnjige.Text = "";
                        string update = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Dostupna' FROM Knjiga INNER JOIN NaCitanju ON NaCitanju.KnjigaID != Knjiga.KnjigaID UPDATE Knjiga SET Knjiga.Dostupnost = 'Izdata' FROM Knjiga INNER JOIN NaCitanju ON NaCitanju.KnjigaID = Knjiga.KnjigaID";

                        k.updateDostupnosti(update);
                        string updateRez = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Rezervisana' FROM Knjiga INNER JOIN Rezervacije ON Rezervacije.KnjigaID = Knjiga.KnjigaID";
                        k.updateDostupnosti(updateRez);

                    }

                    
        
                }
                else if (dr == DialogResult.No)
                { }
         


     }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lbpomoc.Text))
            {

            }
            else
            {

                string naredba = "UPDATE Knjiga Set KnjigaID='" + tbID.Text + "',Naziv='" + tbNaziv.Text + "',MestoPolica='" + tbPolica.Text + "',AutorID='" + tbAutorID.Text + "',OblastKnjige='" + tbOblastKnjige.Text + "' WHERE KnjigaID='" + lbpomoc.Text + "'";
                k.uPDATE(naredba, univerzalniString, dataGridView1);

                DateTime localDate = DateTime.Now;
                string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Izvsena promena nad knjigom  [ID=" + lbID.Text + ", Naslov=" + lbNaslov.Text + ", mesto polica=" + lbMestoP.Text + ", oblast knjiga=" + lbOblastK.Text + ", autorID=" + lbAutorID.Text + "] u [ID=" + tbID.Text + ", Naslov=" + tbNaziv.Text + ", mesto polica=" + tbPolica.Text + ", oblast knjiga=" + tbOblastKnjige.Text + ", autorID=" + tbAutorID.Text + "]')";
                k.SaveLog(aktivnostNaredba, out provera);

            }

        }

        private void btnCisti_Click(object sender, EventArgs e)
        {
            tbID.Text = "";

            tbNaziv.Text = "";

            tbAutorID.Text = "";
            tbPolica.Text = "";
            tbOblastKnjige.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naredba = "SELECT DISTINCT KnjigaID as KnjigaID,Naziv as Naslov,MestoPolica as MestoPolice,AutorID as AutorID,OblastKnjige as OB,Dostupnost as Dost  FROM Knjiga where KnjigaID!='0' and Naziv='"+tbNaziv.Text+"'";
            k.View(naredba, dataGridView1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked = true)
            {

                k.autoCK(tbNaziv);
               
            }
        }
    }
}
