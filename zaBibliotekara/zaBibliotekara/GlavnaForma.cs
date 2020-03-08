using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace zaBibliotekara
{
    public partial class GlavnaForma : Form
    {
        DateTime localDate = DateTime.Now;
        int brojac=0;

        konekcija k = new konekcija();
        bool provera;

        int x1, y;
      
        string ID_korisnika;

        string ime, prezime;
      

        public GlavnaForma()
        {

          
            InitializeComponent();

            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            lbrezID.Text = "";
        }

        public string get1()
        {
            return this.ID_korisnika;

        }

        private void btnUnosCitaoca_Click(object sender, EventArgs e)
        {
         

            Citaoci citaoci = new Citaoci(ID_korisnika);
           
                citaoci.ShowDialog();
           
       
         
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
          


            WindowState = FormWindowState.Maximized;
           
      

            string provera1 = "declare @i INT set @i =(select count (AutorID) from Autor where AutorID=0); IF(@i =0) begin Insert into Autor Values(0,'0','0'); end; set @i =(select count (CitalacID) from Citalac where CitalacID=0); IF(@i =0) begin Insert into Citalac  Values('0','0','0',0,0); end; set @i =(select count (KnjigaID) from Knjiga where KnjigaID=0); IF(@i =0) begin Insert into Knjiga  Values(0,'0','0',0,'0','0'); end; set @i =(select count (KnjigaID) from NaCitanju where KnjigaID=0); IF(@i =0) begin Insert into NaCitanju  Values(0,'0','2017-01-01','2250-01-01','0'); end; set @i =(select count (KnjigaID) from Rezervacije where KnjigaID=0); IF(@i =0) begin Insert into Rezervacije  Values(0,'0','0'); end;";

            k.updateDostupnosti(provera1);


            string naredba = "Delete from Aktivnost where DATEDIFF(day, Aktivnost.Datum, '" + localDate.ToString() + "') >= 60 and Aktivnost!='Odeljenja ažurirana'";
           k.simpleDelete(naredba);

            timer1.Start();
        }

        private void btnRez_Click(object sender, EventArgs e)
        {
            string naredba = "SELECT DISTINCT KnjigaID as KnjigaID,Naziv as Naslov,CitalacID as CitalacID  FROM Rezervacije WHERE KnjigaID!=0;";

            k.View(naredba, dataGridView1);
         
          



        }

        private void btnUnosAutora_Click(object sender, EventArgs e)
        {
          
                Autori autori = new Autori(ID_korisnika);
                autori.ShowDialog();

        
         
        }

        private void btnUnosKnjige_Click(object sender, EventArgs e)
        {
          
           

                Knjige knjiga = new Knjige(ID_korisnika);
            
            knjiga.ShowDialog();
            
           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tbKnjigaID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lbrezID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lbKID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lbNaslov.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


            }
            catch (Exception ex)
            {


            }
        }

        private void btnCheckCitalac_Click(object sender, EventArgs e)
        {
            string naredba = "SELECT DISTINCT * FROM Citalac where CitalacID!='0';";
            dataGridView2.Visible = true;
            k.View(naredba, dataGridView2);
            tbOdeljenje.Text = "";
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            tbCitalacID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
        }

      
        private void GlavnaForma_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X+" "+ e.Y);
            
        }

        private void btnIzdati_Click(object sender, EventArgs e)
        {
            bool p,x;
            string naredbaRe = "SELECT DISTINCT KnjigaID as KnjigaID,Naziv as Naslov,CitalacID as CitalacID  FROM Rezervacije WHERE KnjigaID!=0;";
        
            string deleteNaredba = "DELETE FROM Rezervacije WHERE Rezervacije.KnjigaID='" + tbKnjigaID.Text + "' ";
            string naredba = "INSERT INTO NaCitanju (KnjigaID, CitalacID, DatumIznajmljivanja, DatumVracanja)VALUES('" + tbKnjigaID.Text + "', '" + tbCitalacID.Text + "', '" + dtDI.Text + "', '" + dtDV.Text + "')";
            k.SaveUnos(naredba,out p);
            k.Delete(deleteNaredba,naredbaRe,dataGridView1,out x);
            if (p == true)
            {
           
                DateTime localDate = DateTime.Now;
                string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Knjiga izdata na citanje  [KnjigaID=" + tbKnjigaID.Text + ", CitalacID=" + tbCitalacID.Text + ", Datum Iznajmljivanja=" + dtDI.Text + ", Datum Vracanja=" + dtDV.Text + "] ')";
                k.SaveLog(aktivnostNaredba, out provera);
                tbKnjigaID.Text = "";

                tbCitalacID.Text = "";


            }

        }

        private void btnBrisanjeR_Click(object sender, EventArgs e)
        {
            if (tbKnjigaID.Text == "")
            {
            }
            else
            {
                bool p, x;
                DialogResult dr = MessageBox.Show("Da li ste sigurni da želite obrisati izabranu rezervaciju?", "Provera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string naredbaRe = "SELECT DISTINCT KnjigaID as KnjigaID,Naziv as Naslov,CitalacID as CitalacID  FROM Rezervacije WHERE KnjigaID!=0;";
                    string deleteNaredba = "DELETE FROM Rezervacije WHERE Rezervacije.KnjigaID='" + tbKnjigaID.Text + "' ";
                    k.Delete(deleteNaredba, naredbaRe, dataGridView1, out x);

                    if (x == true)
                    {
                        DateTime localDate = DateTime.Now;
                        string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Obrisana Rezervacija  [KnjigaID=" + lbKID.Text + ", Naslov = " + lbNaslov.Text + ", ID_rezervacije = " + lbrezID.Text + "')";
                        k.SaveLog(aktivnostNaredba, out provera);

                        tbKnjigaID.Text = "";

                        tbCitalacID.Text = "";
                        tbidRez.Text = "";


                    }
                }
                else if (dr == DialogResult.No)
                {


                }
            }
        }

        private void btnNaCitanju_Click(object sender, EventArgs e)
        {

            NaCitanju nC = new NaCitanju(ID_korisnika);
            nC.ShowDialog();
        }

        


        private void btnKasnjenje_Click(object sender, EventArgs e)
        {
            PrikazKasnjenja pK = new PrikazKasnjenja();
            
            pK.ShowDialog();
       

        }

        private void btnRefreshKasnjenje_Click(object sender, EventArgs e)
        {

            string naredba = " SELECT COUNT(KnjigaID) FROM NaCitanju Where DATEDIFF(day,NaCitanju.DatumVracanja,'"+ localDate.ToString(("M/d/yyyy")) + "')>0";
            int br = 0;


            k.Kasnjenje(naredba, out br);
            if (br == 0)
            {
                btnKasnjenje.Text = "Kasnjenje ()";
                btnKasnjenje.BackColor = Color.Transparent;
            }
            else if (br > 0 && br <= 20)
            {
                btnKasnjenje.Text = "Kasnjenje ( " + br + " )";
                btnKasnjenje.BackColor = Color.Firebrick;


            }
            else if (br > 20)
            {

                btnKasnjenje.Text = "Kasnjenje ( " + br + " )";
                btnKasnjenje.BackColor = Color.Red;
            }


            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            btnRefreshKasnjenje.PerformClick();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            string naredba = "SELECT * FROM Citalac where Odeljenje='"+tbOdeljenje.Text+"'";
            dataGridView2.Visible = true;
            k.View(naredba, dataGridView2);
            tbOdeljenje.Text = "";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Logovanje lg = new Logovanje();
            lg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Odjavljivanje')";
            k.SaveLog(aktivnostNaredba, out provera);

            gbKorisnik.Visible = false;
            gbPrijava.Visible = true;

        // gbPrijava.Location = new Point(x1,y);
            ID_korisnika = null;
                ime = null;
            prezime = null;
            gbUnos.Enabled = false;
            gbRez.Enabled = false;
            gbDugmad.Enabled = false;

            dataGridView2.Visible= false;
           

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }


        private int   funkcijaPom(string komanda)
        {
            string pom="";
      

            k.View_p(komanda, out pom);
           return Int32.Parse(pom);

        }

        private void btnIstorija_Click(object sender, EventArgs e)
        {
            Istorija istorija = new Istorija();
            istorija.ShowDialog();
        }

        private void btnPretragaRID_Click(object sender, EventArgs e)
        {
            string naredba = "SELECT DISTINCT KnjigaID as KnjigaID,Naziv as Naslov,CitalacID as CitalacID  FROM Rezervacije WHERE CitalacID='" + tbidRez.Text+"' AND KnjigaID!=0;";

            k.View(naredba, dataGridView1);

        }

        private void novaSkolskaGodina_Click(object sender, EventArgs e)
        {
            updateOdeljenja upO = new updateOdeljenja(ID_korisnika);
            upO.ShowDialog();
        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            brojac = 0;
            string komanda = "SELECT COUNT(Username) FROM Logovanje WHERE Username='" + tbUsername.Text.Trim() + "'";
       
            brojac= funkcijaPom(komanda);
            if (brojac == 1)
            {

                brojac = 0;
             
               
                string naredba = " SELECT COUNT(Username) FROM Logovanje WHERE Username = '" + tbUsername.Text.Trim() + "' AND Password = '" + tbPass.Text.Trim() + "'";
                brojac = funkcijaPom(naredba);
              

                if (brojac == 1)
                {
                    string x,pom = "SELECT Password FROM Logovanje WHERE Username = '" + tbUsername.Text.Trim() + "' AND Password = '" + tbPass.Text.Trim() + "' ";
                    k.View_p(pom, out x);
                    if (x == tbPass.Text.Trim())
                    {



                        string naredba1 = "SELECT KorisnikID From Logovanje Where Username='" + tbUsername.Text.Trim() + "' AND Password='" + tbPass.Text.Trim() + "'";
                        k.logIn(naredba1, out ID_korisnika);
                        string naredba2 = "SELECT Ime From Logovanje Where Username='" + tbUsername.Text.Trim() + "' AND Password='" + tbPass.Text.Trim() + "'";
                        k.logIn(naredba2, out ime);
                        string naredba3 = "SELECT Prezime From Logovanje Where Username='" + tbUsername.Text.Trim() + "' AND Password='" + tbPass.Text.Trim() + "'";
                        k.logIn(naredba3, out prezime);

                        #region Skrivanje
                        gbPrijava.Visible = false;

                        gbKorisnik.Visible = true;
                      
              
                        lbIme.Text = ime;
                        lbPrezime.Text = prezime;


                        #endregion
                        lbObavestenje.Text = "";
                        tbPass.Text = "";
                        tbUsername.Text = "";
                        brojac = 0;
                        gbDugmad.Enabled = true;
                        gbRez.Enabled = true;
                        gbUnos.Enabled = true;

                        DateTime localDate = DateTime.Now;
                        string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Prijavljivanje')";
                        k.SaveLog(aktivnostNaredba, out provera);
                    }
                    else
                    {
                        lbObavestenje.Text = "Sifra nije tacna ";
                        tbPass.Text = "";
                    }
                }
                else if (brojac == 0)
                {
                    lbObavestenje.Text = "Sifra nije tacna ";

                    tbPass.Text = "";
                }

            }
            else if(brojac == 0)
            {
                lbObavestenje.Text = "Korisnicko ime ne postoji";
              
            }
        }
    }
}
