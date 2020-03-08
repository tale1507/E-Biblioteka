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
    public partial class Logovanje : Form
    {
        konekcija k = new konekcija();
        bool p = true;
        public Logovanje()
        {
            InitializeComponent();
        }

     

     

        private void btnReg_Click(object sender, EventArgs e)
        {

            lbProvera.Text = "";
            if (tbRUsername.Text.Trim() != "" && tbRPass.Text.Trim() != "" && tbRPass2.Text.Trim() != "" && tbREmail.Text.Trim() != "" && tbRIme.Text.Trim() != "" && tbRPrezime.Text.Trim() != "")
            {
                #region Id
                int brojac;
                string pom;
                string komanda = "SELECT COUNT(KorisnikID) FROM Logovanje";
                k.View_p(komanda, out pom);
                brojac = Int32.Parse(pom);
                ++brojac;

                #endregion

                int brojac1 = 0;
                string pom1;
                string komanda1 = "SELECT COUNT(Username) FROM Logovanje  where Username='" + tbRUsername.Text + "'";
                k.View_p(komanda1, out pom1);
                brojac1 = Int32.Parse(pom1);

                if (brojac1 == 1)
                {
                    lbProvera.Text = "Ovo korisnicko ime vec postoji molimo vas da promenite ";

                }
                else if (tbRPass.Text == tbRPass2.Text)
                {
                    bool p = false;

                  
                    string naredba = "INSERT INTO Logovanje(KorisnikID,Username,Password,Email,Ime,Prezime) VALUES('" + brojac + "','" + tbRUsername.Text.Trim() + "','" + tbRPass.Text + "','" + tbREmail.Text.Trim() + "','" + tbRIme.Text.Trim() + "','" + tbRPrezime.Text.Trim() + "')";
                    k.SaveLog(naredba, out p);
                    if (p == true)
                    {
                        lbProvera.Text = "Uspesna Registracija ";
                        tbRPass.Text = "";
                        tbRPass2.Text = "";
                        tbRUsername.Text = "";
                        tbREmail.Text = "";
                        tbRIme.Text = "";
                        tbRPrezime.Text = "";
                      
                    }
                    else
                    {
                        opet:
                        string naredba1 = "INSERT INTO Logovanje(KorisnikID,Username,Password,Email,Ime,Prezime) VALUES('" + ++brojac + "','" + tbRUsername.Text.Trim() + "','" + tbRPass.Text + "','" + tbREmail.Text.Trim() + "','" + tbRIme.Text.Trim() + "','" + tbRPrezime.Text.Trim() + "')";//u slucaju da postoji Id stavljamo povecani za 1
                        k.SaveLog(naredba1, out p);
                        if (p == true)
                        {
                            lbProvera.Text = "Uspesna Registracija ";
                            tbRPass.Text = "";
                            tbRPass2.Text = "";
                            tbRUsername.Text = "";
                            tbREmail.Text = "";
                            tbRIme.Text = "";
                            tbRPrezime.Text = "";
                        }
                        else {
                            goto opet;
                        }

                    }
                }
                else if (tbRPass.Text != tbRPass2.Text)

                {
                    lbProvera.Text = "Sifre se ne poklapaju ponovite unos";
                    tbRPass.Text = "";
                    tbRPass2.Text = "";

                }
            }


            else
            {

                lbProvera.Text = "Sva polja moraju biti unesena";
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logovanje_Load(object sender, EventArgs e)
        {

        }
    }
}
    