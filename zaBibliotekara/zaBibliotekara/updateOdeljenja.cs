using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace zaBibliotekara
{
    public partial class updateOdeljenja : Form
    {
        string[] particija = { "D", "E", "H", "G", "C" };

        int i = 0;
        DateTime localDate = DateTime.Now;
        string ID_korisnika;
        konekcija k = new konekcija();
        int Godina;
        string godina = null;
        public updateOdeljenja(string id)

        {
            
            InitializeComponent();

            ID_korisnika = id;
            string  br = "";

          

                string naredba = "SELECT COUNT(Aktivnost) From Aktivnost Where Aktivnost='Odeljenja azurirana'";
             int br1 = 0;

            k.Kasnjenje(naredba, out br1);

            godina = Godina.ToString();
            if (godina != null)
            {
                if (br1 == 1)
                {
                    
                    string naredba1 = " Declare @i date; declare @iObavestenje nvarchar(20); declare @provera INT; set @i = (SELECT Datum from Aktivnost where Aktivnost = 'Odeljenja ažurirana'); SET @provera = (DATEDIFF(day, @i,  GETDATE())); IF(@provera > 270) begin Delete Aktivnost where Aktivnost = 'Odeljenja ažurirana' and Datum = @i; set @iObavestenje = 'true'; select @iObavestenje; end; else begin set @iObavestenje = 'false'; select @iObavestenje; end;";

                    k.logIn1(naredba1, out br);

                   
                    if ("true" == br)
                    {
                        button1.Enabled = true;
                    }
                    else
                    {
                        button1.Enabled = false;
                    }
                }
            }
            else { } 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool provera;
            string naredba = "UPDATE Citalac SET Odeljenje=Odeljenje+10 Where Odeljenje<100";
            k.updateDostupnosti(naredba);
            string naredba1 = "UPDATE Citalac SET Odeljenje=Odeljenje+100 Where Odeljenje>100";
            k.updateDostupnosti(naredba1);

            string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Odeljenja ažurirana')";
            k.SaveLog(aktivnostNaredba, out provera);
            if (provera)
            {
                button1.BackColor = Color.Red;
                button1.Enabled = false;
            }



        }

        private void btnBak_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(tbName.Text))
            {
                bool provera;
               

                string naredba = "BACKUP DATABASE Biblioteka1 TO DISK = N'"+particija[i] +":\\Sacuvana Biblioteka\\" + tbName.Text + ".bak';";

                k.SaveLog(naredba, out provera);
                if (provera == true)
                {
                  lbO.Text="Uspesno sačuvana baza na  - ";
                    tbLokacija.Visible = true;
                    tbLokacija.Text = "" + particija[i] + ":\\Sacuvana Biblioteka\\" + tbName.Text + ".bak";
                    string aktivnostNaredba = "INSERT INTO Aktivnost (KorisnikID,Datum,Vreme,Aktivnost) VALUES('" + ID_korisnika + "','" + localDate.ToString("M/d/yyyy") + "','" + localDate.ToString("HH:mm:ss tt") + "', 'Napravljen bekap baze pod imenom "+tbName.Text+".bak')";
                    k.SaveLog(aktivnostNaredba, out provera);
                }


            }
        }

        private void updateOdeljenja_Load(object sender, EventArgs e)
        {
           
            opet:
            string lokacija = ""+ particija [i]+ ":\\Sacuvana Biblioteka";
            try
            {
                if (Directory.Exists(lokacija))
                {

                }
                else
                {

                    DirectoryInfo di = Directory.CreateDirectory(lokacija);


                }
            }
            catch (Exception ex)
            {
                ++i;
                goto opet;

            }
        }
    }
    
}
