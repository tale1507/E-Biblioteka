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
    public partial class NaCitanju : Form
    {
        string univerzalniString = "SELECT DISTINCT NaCitanju.KnjigaID,NaCitanju.CitalacID,NaCitanju.DatumIznajmljivanja,NaCitanju.DatumVracanja,Citalac.Ime,Citalac.Prezime,Citalac.Odeljenje FROM Citalac INNER JOIN NaCitanju ON NaCitanju.CitalacID = Citalac.CitalacID where KnjigaID!='0'";
        konekcija k = new konekcija();
        private string ID_korisnika=null;

        public NaCitanju(string id)
        {
            ID_korisnika = id;
            InitializeComponent();
         
    
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string naredba = univerzalniString;


        

            k.View(naredba, dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool provera;
            string update = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Dostupna' FROM Knjiga INNER JOIN NaCitanju ON NaCitanju.KnjigaID != Knjiga.KnjigaID UPDATE Knjiga SET Knjiga.Dostupnost = 'Izdata' FROM Knjiga INNER JOIN NaCitanju ON NaCitanju.KnjigaID = Knjiga.KnjigaID";


            string updateRez = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Rezervisana' FROM Knjiga INNER JOIN Rezervacije ON Rezervacije.KnjigaID = Knjiga.KnjigaID";
          
          

        
                    if (string.IsNullOrEmpty(lbpomoc.Text))
                    {

                    }
                    else
                    {
               
                
                DialogResult dr = MessageBox.Show("Da li ste sigurni da želite razdužiti izabranu knjigu?", "Provera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string naredba = "Delete From NaCitanju WHERE KnjigaID='" + tbKnjigaID.Text + "'";
                    k.Delete(naredba, univerzalniString, dataGridView1, out provera);
                    if (provera == true)
                    {

                        DateTime localDate = DateTime.Now;
                        string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Obrisana knjiga iz knjiga koje su na citanju  [KnjigaID=" + tbKnjigaID.Text + ", CitalacID=" + tbCitalacID.Text + ", Datum Iznajmljivanja=" + dtDI.Text + ", Datum Vracanja=" + dtDV.Text + "]')";
                        k.SaveLog(aktivnostNaredba, out provera);
                        tbKnjigaID.Text = "";

                        tbCitalacID.Text = "";
                        dtDI.Text = "";
                        dtDV.Text = "";
                        k.updateDostupnosti(update);
                        k.updateDostupnosti(updateRez);
                    }
                }
                else if (dr == DialogResult.No) { } 
                    
            

        
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lbpomoc.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbKnjigaID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbCitalacID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dtDI.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dtDV.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                lbKID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lbCID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lbDI.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lbDV.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                
            } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool p;
            if (String.IsNullOrEmpty(tbKnjigaID.Text) || String.IsNullOrEmpty(tbCitalacID.Text) || String.IsNullOrEmpty(dtDI.Text) || String.IsNullOrEmpty(dtDV.Text))
            {
                MessageBox.Show("Morate uneti sva polja");

            }

            else
            {

                bool provera;
                string x;


                string pomNareba = "SELECT COUNT(KnjigaID) FROM NaCitanju WHERE KnjigaID='" + tbKnjigaID.Text + "'";
                k.View_p(pomNareba, out x);
                if (x == "1")
                {
                    MessageBox.Show("Ova knjiga je vec Izdata");

                }
                else
                {

                    string naredba = "INSERT INTO NaCitanju (KnjigaID, CitalacID, DatumIznajmljivanja, DatumVracanja)VALUES('" + tbKnjigaID.Text + "', '" + tbCitalacID.Text + "', '" + dtDI.Text + "', '" + dtDV.Text + "')";
                    k.SaveUnos(naredba, out p);

                    if (p == true)
                    {
                        DateTime localDate = DateTime.Now;
                        string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Knjiga izdata na citanje  [KnjigaID=" + tbKnjigaID.Text + ", CitalacID=" + tbCitalacID.Text + ", Datum Iznajmljivanja=" + dtDI.Text + ", Datum Vracanja=" + dtDV.Text + "] ')";
                        k.SaveLog(aktivnostNaredba, out provera);


                        tbKnjigaID.Text = "";

                        tbCitalacID.Text = "";

                    }

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
                bool provera;
                string naredba = "UPDATE NaCitanju Set KnjigaID='" + tbKnjigaID.Text + "', CitalacID='" + tbCitalacID.Text + "', DatumIznajmljivanja='" + dtDI.Text + "',DatumVracanja='" + dtDV.Text + "' WHERE KnjigaID='" + lbpomoc.Text + "'";
                k.uPDATE(naredba, univerzalniString, dataGridView1);

                DateTime localDate = DateTime.Now;
                string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Izvrsena promena izdatom knjigom [KnjigaID=" + lbKID.Text + ", CitalacID=" + lbCID.Text + ", Datum Iznajmljivanja=" + lbDI.Text + ", Datum Vracanja=" + lbDV.Text + "] u [KnjigaID=" + tbKnjigaID.Text + ", CitalacID=" + tbCitalacID.Text + ", Datum Iznajmljivanja=" + dtDI.Text + ", Datum Vracanja=" + dtDV.Text + "]')";
                k.SaveLog(aktivnostNaredba, out provera);


            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckCitalac_Click(object sender, EventArgs e)
        {
            string naredba = "Select DISTINCT * From Citalac where CitalacID!='0'";
            dataGridView2.Visible = true;
            k.View(naredba, dataGridView2);
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            tbCitalacID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnCisti_Click(object sender, EventArgs e)
        {
            tbKnjigaID.Text = "";

            tbCitalacID.Text = "";
        }

        private void NaCitanju_Load(object sender, EventArgs e)
        {
            k.autoCI(tbCitalacID);
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            string naredba = "SELECT * FROM Citalac where Odeljenje='" + tbOdeljenje.Text + "'";
            dataGridView2.Visible = true;
            k.View(naredba, dataGridView2);
            tbOdeljenje.Text = "";
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            string naredba = "SELECT DISTINCT NaCitanju.KnjigaID,NaCitanju.CitalacID,NaCitanju.DatumIznajmljivanja,NaCitanju.DatumVracanja,Citalac.Ime,Citalac.Prezime,Citalac.Odeljenje FROM Citalac INNER JOIN NaCitanju ON NaCitanju.CitalacID = Citalac.CitalacID where KnjigaID!='0' and NaCitanju.CitalacID='" + tbCitalacID.Text+"'";
            k.View(naredba, dataGridView1);
        }
    }
}
