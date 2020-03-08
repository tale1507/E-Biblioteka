using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.IO;

namespace zaBibliotekara
{
    class konekcija
    {
        public string server = "";
        public SqlConnection cnn;
        public SqlCommand cmd;
        public SqlDataReader dr;
   
  
    




        public konekcija()
        {
            XmlDocument xDoc = new XmlDocument();
            string server = "";
            xDoc.Load("ServerName.xml");
            foreach (XmlNode child in xDoc.ChildNodes)

            {
                server = child.InnerText;

            }
            string konStri = @"Data Source=" + server + ";Initial Catalog=Biblioteka1;Integrated Security=True";
          
            try
            {
           
                cnn = new SqlConnection(konStri);
                cnn.Open();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Konekcija nije uspela error: " + ex.ToString());
                cnn.Close();
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

        public void autoCK(TextBox tx)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("SELECT Naziv FROM Knjiga", cnn);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tx.AutoCompleteCustomSource.Add(dr["Naziv"].ToString() );

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

        public void autoCI(TextBox tx)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("SELECT CitalacID FROM NaCitanju", cnn);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tx.AutoCompleteCustomSource.Add(dr["CitalacID"].ToString());

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
        public void logIn(string Komanda, out string temp)
        {
            
            try
            {
                temp = "";
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);

                temp = SDA.SelectCommand.ExecuteScalar().ToString();
                cnn.Close();

            }
            catch (Exception ex)
            {
                cnn.Close();
                temp = "";
                MessageBox.Show("Greska " + ex.ToString());
            }

        }
        public void logIn1(string Komanda, out string temp)
        {

            try
            {
                temp = "";
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);

                temp = SDA.SelectCommand.ExecuteScalar().ToString();
                cnn.Close();

            }
            catch (Exception ex)
            {
                cnn.Close();
                temp = "";
                MessageBox.Show("Greska " + ex.ToString());
            }

        }
        public void SaveLog(string Komanda, out bool provera)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);
                SDA.SelectCommand.ExecuteNonQuery();

                cnn.Close();
                provera = true;
               
            }
            catch (Exception ex)
            {
                cnn.Close();
                provera = false;
               
            }
        }

        public void SaveUnos(string Komanda, out bool provera)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);
                SDA.SelectCommand.ExecuteNonQuery();


                provera = true;
                MessageBox.Show("Uspesno uneti podaci");
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                provera = false;
                MessageBox.Show("Greska " + ex.ToString());
            }
        }

        public void View(string Komanda, DataGridView datagrid)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);
                DataTable dT = new DataTable();
                SDA.Fill(dT);
                datagrid.DataSource = dT;
              
                cnn.Close();
                
               
            }
            catch (Exception ex)
            {
                cnn.Close();
                MessageBox.Show("Greska " + ex.ToString());
            }
        }

        public void View_p(string Komanda,out string p)
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
        public void uPDATE(string Komanda,string komanda2, DataGridView datagrid)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);

                SDA.SelectCommand.ExecuteNonQuery();
               
                cnn.Close();
                View(komanda2, datagrid);

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
                cnn.Close();
                MessageBox.Show("error " + e.Message); }
        }

        public void Delete(string Komanda, string komanda2, DataGridView datagrid,out bool provera)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);
                SDA.SelectCommand.ExecuteNonQuery();
               
                cnn.Close();
                View(komanda2, datagrid);
                provera = true;
            

            }
            catch (Exception ex)
            {
                cnn.Close();

                MessageBox.Show("Greska " + ex.ToString());
                provera = false;
            }
        }

        public void simpleDelete(string Komanda)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);
                SDA.SelectCommand.ExecuteNonQuery();

                cnn.Close();


            }
            catch (Exception ex)
            {
                cnn.Close();

                MessageBox.Show("Greska " + ex.ToString());

            }
        }
        public void Kasnjenje(string Komanda, out int x)
        {

            try
            {
                cnn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(Komanda, cnn);

               x = (Int32)SDA.SelectCommand.ExecuteScalar();

                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                x =0;
              
            }

        }
    }
}
