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
    public partial class PrikazKasnjenja : Form
    {
        DateTime localDate = DateTime.Now;
        DateTime localDate1 ;
           konekcija k = new konekcija();

        string strDate;
        public PrikazKasnjenja()
        {
            InitializeComponent();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
         

            string naredba = " SELECT NaCitanju.KnjigaID,Knjiga.Naziv,NaCitanju.DatumIznajmljivanja,NaCitanju.DatumVracanja,Citalac.Ime,Citalac.Prezime,Citalac.Odeljenje  FROM Knjiga INNER Join NaCitanju ON NaCitanju.KnjigaID=Knjiga.KnjigaID INNER JOIN Citalac ON NaCitanju.CitalacID = Citalac.CitalacID and  DATEDIFF(day,NaCitanju.DatumVracanja,'" + localDate.ToString(("M/d/yyyy")) + "')>0";
            k.View(naredba,dataGridView1);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            double x;
            int x1;

            strDate = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            localDate1 = Convert.ToDateTime(strDate);

            TimeSpan t = localDate - localDate1;
            x= t.TotalDays;
            x1 = (Int32)x;
           
            lbObavestenje.Text = "Ovaj citalac kasni sa vracanjem knjige " + x1.ToString() + " dan-a";


        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            string naredba = " SELECT NaCitanju.KnjigaID,Knjiga.Naziv,NaCitanju.DatumIznajmljivanja,NaCitanju.DatumVracanja,Citalac.Ime,Citalac.Prezime,Citalac.Odeljenje  FROM Knjiga INNER Join NaCitanju ON NaCitanju.KnjigaID=Knjiga.KnjigaID INNER JOIN Citalac ON NaCitanju.CitalacID = Citalac.CitalacID and  DATEDIFF(day,NaCitanju.DatumVracanja,'" + localDate.ToString(("M/d/yyyy")) + "')>0 and Citalac.Odeljenje='" + tbOdeljenje.Text+"'";
            dataGridView1.Visible = true;
            k.View(naredba, dataGridView1);
        }

        private void PrikazKasnjenja_Load(object sender, EventArgs e)
        {

        }
    }
}
