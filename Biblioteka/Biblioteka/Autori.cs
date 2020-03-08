using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Autori : Form
    {
        public Autori()
        {
            InitializeComponent();
        }

        private void btnNT_Click(object sender, EventArgs e)
        {
            pBlogo.Visible = false;
            pbSlika.Visible = true;
            pbPozadina.Visible = true;
            pbSlika.Image = Properties.Resources.Nikola_Tasic;
            Ime.Visible = true;
            Prezime.Visible = true;
          //  Omeni.Visible = true;
            lbIme.Text = "Nikola";
            lbPrezime.Text = "Tasic";
          //  lbomeni.Text = "Rodjen sam 15.07.1998 u selu Strojkovce kod Leskovca,\ntu sam zavrsio osnovnu skolu.\nRano sam poceo da se interesujem za programiranje i upisao smer\n-elektrotehnicar informacionih tehnologija\ngde sam nastavio sa sticanjem znanja iz programiranja.\n\nOvo je moj prvi ozbiljni projekat na kom sam radio.";
            lbIme.Visible = true;
            lbPrezime.Visible = true;
         //   lbomeni.Visible = true;

        }

        private void btnMI_Click(object sender, EventArgs e)
        {

            pBlogo.Visible = false;
            pbSlika.Visible = true;
            pbPozadina.Visible = true;
            pbSlika.Image = Properties.Resources.Miroslav_Ilic;
            Ime.Visible = true;
            Prezime.Visible = true;
           // Omeni.Visible = true;
            lbIme.Text = "Miroslav";
            lbPrezime.Text = "Ilic";
           // lbomeni.Text = "";
            lbIme.Visible = true;
            lbPrezime.Visible = true;
           // lbomeni.Visible = true;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {

            pBlogo.Visible = false;
            pbSlika.Visible = true;
            pbPozadina.Visible = true;
            pbSlika.Image = Properties.Resources.Martin_Stamenkovic;
            Ime.Visible = true;
            Prezime.Visible = true;
          //  Omeni.Visible = true;
            lbIme.Text = "Martin";
            lbPrezime.Text = "Stamenkovic";
          //  lbomeni.Text = "";
            lbIme.Visible = true;
            lbPrezime.Visible = true;
        //    lbomeni.Visible = true;
        }

        private void btnDR_Click(object sender, EventArgs e)
        {

            pBlogo.Visible = false;
            pbSlika.Visible = true;
            pbPozadina.Visible = true;
            pbSlika.Image = Properties.Resources.Darko_Ristic;
            Ime.Visible = true;
            Prezime.Visible = true;
            //Omeni.Visible = true;
            lbIme.Text = "Darko";
            lbPrezime.Text = "Ristic";
           // lbomeni.Text = "";
            lbIme.Visible = true;
            lbPrezime.Visible = true;
          //  lbomeni.Visible = true;
        }

        private void btnDD_Click(object sender, EventArgs e)
        {

            pBlogo.Visible = false;
            pbSlika.Visible = true;
            pbPozadina.Visible = true;
            pbSlika.Image = Properties.Resources.Danilo_Drobnjak;
            Ime.Visible = true;
            Prezime.Visible = true;
            //Omeni.Visible = true;
            lbIme.Text = "Danilo";
            lbPrezime.Text = "Drobnjak";
           // lbomeni.Text = "";
            lbIme.Visible = true;
            lbPrezime.Visible = true;
           // lbomeni.Visible = true;
        }

        private void Autori_Load(object sender, EventArgs e)
        {

        }
    }
}
