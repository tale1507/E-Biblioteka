using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using System.Data;

namespace Biblioteka
{
    class connection
    {
       public SqlConnection cnn;
        public SqlCommand cmd;
        public SqlDataReader dr;
        private string konStri = "";
        private string server = "";

        public connection()
        {
            XmlDocument xDoc = new XmlDocument();

            xDoc.Load("ServerName.xml");
            foreach (XmlNode child in xDoc.ChildNodes)

            {
                server = child.InnerText;

            }
            konStri = @"Data Source=" + server + ";Initial Catalog=Biblioteka1;Integrated Security=True";

            try
            {
                cnn = new SqlConnection(konStri);
                cnn.Open();
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                MessageBox.Show("Ne uspla konekcija error: " + ex.ToString());
              
            }
        }
        public void autoC(TextBox tx)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("SELECT Ime,Prezime FROM Autor", cnn);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tx.AutoCompleteCustomSource.Add(dr["Ime"].ToString() + " " + dr["Prezime"].ToString());
                        tx.AutoCompleteCustomSource.Add(dr["Prezime"].ToString() + " " + dr["Ime"].ToString());
                }
                dr.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                MessageBox.Show("error: " + ex.ToString());

            }


        }


        public void View_p(string Komanda, out string p)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);

                p = SDA.SelectCommand.ExecuteScalar().ToString();

                cnn.Close();


            }
            catch (Exception ex)
            {
                cnn.Close();
                p = "error";
                MessageBox.Show("Greska " + ex.ToString());
            }
        }

        public void autoKnjiga(TextBox tx)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("SELECT Naziv FROM Knjiga", cnn);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tx.AutoCompleteCustomSource.Add(dr["Naziv"].ToString());

                }
                dr.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                MessageBox.Show("error: " + ex.ToString());

            }


        }

        public void stampanje(string upit,DataGridView dtgv)

        {
            try
            {
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(upit,cnn);
                DataTable dT = new DataTable();
                SDA.Fill(dT);
                dtgv.DataSource = dT;
                cnn.Close();

            }
            catch(Exception e)

            {
                cnn.Close();
                MessageBox.Show("error "+e.Message); }

        }

        public void SaveRez(string Komanda)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);
                SDA.SelectCommand.ExecuteNonQuery();

                cnn.Close();
                
                MessageBox.Show("Uspesno ste rezervisali knjigu");
            }
            catch (Exception ex)
            {
                cnn.Close();
                MessageBox.Show("Greska " + ex.ToString());
            }
        }

        public void updateDostupnosti(string x)
        {
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(x, cnn); 
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();

            }
            catch (Exception e)

            {
                cnn.Close(); MessageBox.Show("error " + e.Message); }
        }
  
    }
}
