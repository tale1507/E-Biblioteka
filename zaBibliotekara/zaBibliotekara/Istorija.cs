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
    public partial class Istorija : Form
    {
        konekcija k = new konekcija();
        public Istorija()
        {

            InitializeComponent();

            string naredba = "SELECT Aktivnost.Aktivnost as Aktivnost,Aktivnost.Vreme as Vreme ,Aktivnost.Datum as Datum ,Logovanje.Ime as ImeBibliotekara,Logovanje.Prezime as PrezimeBibliotekara FROM Aktivnost INNER JOIN Logovanje ON Logovanje.KorisnikID = Aktivnost.KorisnikID ORDER BY  Aktivnost.Datum DESC ,Aktivnost.Vreme DESC;";
            k.View(naredba, dataGridView1);
            

        }

        private void Istorija_Load(object sender, EventArgs e)
        {

        }
    }
}
