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

namespace Tondach
{
    public partial class Ispis : Form
    {
        
        List<Novi> lista = new List<Novi>();
        public Ispis()
        {
            InitializeComponent();
            popuni_combo_skla();
            ispisi();
        }
        private void popuni_combo_skla()
        {
            comboBox1.Items.Add("Sva skladista");
            var cnn = SQLStatic.GetSqlkonekcija();
            cnn.Open();
            string izvadi = "select * from Skladiste;";
            SqlCommand izvadi_cmd = new SqlCommand(izvadi, cnn);
            SqlDataReader citac;
            citac = izvadi_cmd.ExecuteReader();


            while (citac.Read())
            {

                string Snaziv = citac.GetString(0);

                comboBox1.Items.Add(Snaziv);
            }
            
            cnn.Close();
        }
        void ispisi()
        {   if (comboBox1.Text == "Sva skladista" || comboBox1.Text == "")
            {
                lista.Clear();
                listView2.Items.Clear();
                var con = SQLStatic.GetSqlkonekcija();
                con.Open();
                string kom = "SELECT Nazivproizvoda , Kolicina, imesklad, red , polica, minimalna FROM Stanje ";
                SqlCommand sqlCommand = new SqlCommand(kom, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Novi prijenos1 = new Novi();
                    prijenos1.Naziv_proizvoda = (string)reader["Nazivproizvoda"];
                    prijenos1.Ime_Skladista = (string)reader["imesklad"];
                    prijenos1.Red = (string)reader["Red"];
                    int a = (int)reader["Kolicina"];
                    int c = (int)reader["Polica"];
                    int d = (int)reader["Minimalna"];
                    
                    prijenos1.Kolicina_proizvoda = a;
                    prijenos1.Polica = c.ToString();
                    prijenos1.Minimalna = d;

                    lista.Add(prijenos1);

                }

                foreach (var s in lista)
                {
                    string[] red = { s.Naziv_proizvoda, s.Kolicina_proizvoda.ToString(), s.Ime_Skladista, s.Polica, s.Red, s.Minimalna.ToString() };
                    ListViewItem prenosioc1 = new ListViewItem(red);
                    listView2.Items.Add(prenosioc1);

                }
                con.Close();
            }
                else 
            {
                lista.Clear();
                listView2.Items.Clear();
                var con = SQLStatic.GetSqlkonekcija();
                con.Open();
                string kom = "SELECT Nazivproizvoda , Kolicina, imesklad, red , polica FROM Stanje where imesklad = '" + this.comboBox1.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(kom, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Novi prijenos1 = new Novi();
                    prijenos1.Naziv_proizvoda = (string)reader["Nazivproizvoda"];
                    prijenos1.Ime_Skladista = (string)reader["imesklad"];
                    prijenos1.Red = (string)reader["Red"];
                    int a = (int)reader["Kolicina"];
                    int c = (int)reader["Polica"];
              
                    prijenos1.Kolicina_proizvoda = a;
                    prijenos1.Polica = c.ToString();
             

                    lista.Add(prijenos1);

                }

                foreach (var s in lista)
                {
                    string[] red = { s.Naziv_proizvoda, s.Kolicina_proizvoda.ToString(), s.Ime_Skladista, s.Polica, s.Red };
                    ListViewItem prenosioc1 = new ListViewItem(red);
                    listView2.Items.Add(prenosioc1);

                }
                con.Close();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            ispisi();
        }
    }
}


