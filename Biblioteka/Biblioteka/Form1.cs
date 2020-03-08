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
using System.Configuration;
using System.Xml;

namespace Biblioteka
{
    public partial class Form1 : Form
    {
        bool gasenje = false;
        bool dupla = true;
        int brojac = 0;
        string vsql=" ";
        string temp1,temp2;
        string id="", naziv="", dostupnost="";
        connection k = new connection();



        public Form1()
        {
            InitializeComponent();

        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x, y;
            int s = dataGridView1.Size.Width;
            WindowState = FormWindowState.Maximized;
            panel1.Location = new Point(
        this.ClientSize.Width / 2 - panel1.Size.Width / 2);
            panel1.Anchor = AnchorStyles.Top;
            int x2;

            x2= panel1.Location.X;
            int procenat = (int)Math.Round((double)(s * 15) /100 );
            panel1.Location = new Point(x2-procenat);
     


            x = this.Height;
            y = this.Width;

            this.MinimumSize = new Size(y, x);
            int x1, y1;
            x1 = this.Location.X;
            y1 = this.Location.Y;
            this.Location = new Point(x1, y1);


            k.autoC(textBox1);
            k.autoKnjiga(textBox2);


            if (cbAutor.Checked == true)
            {
                textBox1.Text = "";
            }
            else if (cbAutor.Checked == false)
            {
                textBox1.Text = "Ime Prezime";
            }

            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            brojac = 0;
            string update = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Dostupna' FROM Knjiga INNER JOIN NaCitanju ON NaCitanju.KnjigaID != Knjiga.KnjigaID UPDATE Knjiga SET Knjiga.Dostupnost = 'Izdata' FROM Knjiga INNER JOIN NaCitanju ON NaCitanju.KnjigaID = Knjiga.KnjigaID";
            
            k.updateDostupnosti(update);
            string updateRez = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Rezervisana' FROM Knjiga INNER JOIN Rezervacije ON Rezervacije.KnjigaID = Knjiga.KnjigaID";
            k.updateDostupnosti(updateRez);
          

            if (textBox1.Enabled == true && textBox1.Text != "")
            {

                string s = textBox1.Text;
                var char1 = s.ToCharArray();
                int duzina = s.Length;
                for (int i = 0; i < duzina; i++)
                {
                    if (char1[i] == ' ') {

                        brojac++;
                    }




                }
                if (brojac >= 1)
                {

                    int index = s.IndexOf(" ");


                    temp1 = s.Substring(0, index);
                    temp2 = s.Substring(index+1);
                    dupla = true;
                }
                else
                {
                 


                    temp1 =textBox1.Text;
                    dupla = false;
                }
            }


            if (textBox1.Enabled == true && textBox2.Enabled == true)
            {
               
                if (dupla == true)
                {
                    vsql = "  select DISTINCT Knjiga.KnjigaID as 'ID', Knjiga.Naziv as 'Naziv Knjige', Autor.Ime as 'Ime Autora', Autor.Prezime as 'Prezime Autora',Knjiga.Dostupnost as 'Dostupna' from Knjiga,Autor where Autor.Ime like  '%" + temp1 + "%' and Autor.Prezime like  '%" + temp2 + "%' and Knjiga.Naziv like '%" + textBox2.Text + "%' and Knjiga.AutorID = Autor.AutorID and KnjigaID!='0'";

                }
                else {
                    vsql = "  select DISTINCT Knjiga.KnjigaID as 'ID', Knjiga.Naziv as 'Naziv Knjige', Autor.Ime as 'Ime Autora', Autor.Prezime as 'Prezime Autora'Knjiga.Dostupnost as 'Dostupna' from Knjiga,Autor where Autor.Ime like  '%" + temp1 + "%' and Knjiga.Naziv like '%" + textBox2.Text + "%' and Knjiga.AutorID = Autor.AutorID and KnjigaID!='0'";
                }
            }
            else if (textBox1.Enabled == true && textBox2.Enabled == false)
            {
                if (dupla == true)
                {
                    vsql = "  select DISTINCT Knjiga.KnjigaID as 'ID', Knjiga.Naziv as 'Naziv Knjige', Autor.Ime as 'Ime Autora', Autor.Prezime as 'Prezime Autora',Knjiga.Dostupnost as 'Dostupna' from Knjiga,Autor where Autor.Ime like  '%" + temp1 + "%' and Autor.Prezime like  '%" + temp2 + "%' and Knjiga.AutorID = Autor.AutorID and KnjigaID!='0'";
                }
                else if (dupla == false) {
                    vsql = "  select DISTINCT Knjiga.KnjigaID as 'ID', Knjiga.Naziv as 'Naziv Knjige', Autor.Ime as 'Ime Autora', Autor.Prezime as 'Prezime Autora',Knjiga.Dostupnost as 'Dostupna' from Knjiga,Autor where Autor.Ime like  '%" + temp1 + "%' and Knjiga.AutorID=Autor.AutorID and KnjigaID!='0'";
                }
            }
            else if (textBox1.Enabled == false && textBox2.Enabled == true)
            {
                vsql = "  select DISTINCT Knjiga.KnjigaID as 'ID', Knjiga.Naziv as 'Naziv Knjige', Autor.Ime as 'Ime Autora', Autor.Prezime as 'Prezime Autora',Knjiga.Dostupnost as 'Dostupna' from Knjiga,Autor where  Knjiga.Naziv like '%" + textBox2.Text + "%' and Knjiga.AutorID = Autor.AutorID and KnjigaID!='0'";

            }
       
            if (vsql != "") {
                k.stampanje(vsql, dataGridView1);
                lbpomoc.Text = "";
            }
       
        }

        private void cbAutor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutor.Checked == true)
            {
               

                int x, y;

               

               x = panel1.Location.X;
                y = panel1.Location.Y;
               
                lbOb.Location = new Point(x+ panel1.Size.Width, y+10);
                lbOb.Text = "Ako znate prezime autora kucajte prezime,\nali ne možete pretraživati 'Prezime Ime',\nveć mora biti 'Ime Prezime'\novo je samo pomoć da se prisetite\npunog imena i prezimena autora";
                lbOb.ForeColor = Color.Blue;

            }
            if (cbAutor.Checked == false)
            {
                lbOb.Text = "";
            }

                if (cbAutor.Checked == true && cbNaslovKnjige.Checked == true)
            {

                textBox1.Text = "";
                textBox1.Enabled = true;
                textBox2.Enabled = true;
               
        

            }
            else if (cbAutor.Checked == true)
            {
                textBox2.Enabled = false;
                textBox1.Text = "";
                textBox1.Enabled = true;
             

                textBox2.Text = "";
            }
            else if (cbNaslovKnjige.Checked == true)
            {
                textBox1.Enabled = false;
                textBox1.Text = "Ime Prezime";
                textBox2.Enabled = true;
             

                textBox1.Text = "";
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "Ime Prezime";
                textBox2.Enabled = false;

                textBox2.Text = "";
            }

        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {

            if (dostupnost == "Izdata")

            {

                lbpomoc.Text = "Ovu knjigu ne možete da rezervišete jer je izdata na čitanje, ali moci ćete kada se vrati na stanju";

            } else if (dostupnost == "Rezervisana")
            {

                lbpomoc.Text = "Ovu knjigu ne možete da rezervišete jer je već rezervisana";
            } else if (dostupnost == "Dostupna")
                
             
            {
                if (tbIDCitaoc.Text != "")
                {


                    lbpomoc.Text = "";
                    string naredba = "INSERT INTO Rezervacije (KnjigaID, Naziv,CitalacID)VALUES('" + id + "','" + naziv + "','" + tbIDCitaoc.Text+ "');";
                    k.SaveRez(naredba);
                    string updateRez = "UPDATE Knjiga SET Knjiga.Dostupnost = 'Rezervisana' FROM Knjiga INNER JOIN Rezervacije ON Rezervacije.KnjigaID = Knjiga.KnjigaID";
                    k.updateDostupnosti(updateRez);



                    button1.PerformClick();
                }
                else
                {
                    lbpomoc.Text = "Morate uneti svoj broj u maticnoj knjizi";


                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.F12 )
            {
                gasenje = true;
                Application.Exit();
            }
            }


        private void Autori_Click(object sender, EventArgs e)
        {
            Autori a = new Autori();
            a.ShowDialog();
        }

        private Point _desiredLocation;
        // assign the _desiredLocation variable with the form location at some
        // point in the code where you know that the form is in the "correct" position


        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location != _desiredLocation)
            {
                this.Location = _desiredLocation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            k.autoC(textBox1);
            k.autoKnjiga(textBox2);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (gasenje == true)
            {
               
            }
            else
            {
                e.Cancel = e.CloseReason == CloseReason.UserClosing;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                naziv = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dostupnost = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void cbNaslovKnjige_CheckedChanged(object sender, EventArgs e)
        {



            if (cbAutor.Checked == true && cbNaslovKnjige.Checked == true)
            {

               
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            


            }
            else if (cbAutor.Checked == true)
            {
                textBox2.Enabled = false;
             
                textBox1.Enabled = true;
            
               
            }
            else if (cbNaslovKnjige.Checked == true)
            {
                textBox1.Enabled = false;
                textBox1.Text = "Ime Prezime";
                textBox2.Enabled = true;
         

               
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "Ime Prezime";
                textBox2.Enabled = false;
    
            }

        }

     
    }
}
