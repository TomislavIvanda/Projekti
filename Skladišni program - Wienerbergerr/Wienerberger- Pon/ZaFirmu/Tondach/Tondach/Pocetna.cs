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
    public partial class Pocetna : Form
    {
        string Naziv;
        int stanje;
        public Pocetna()
        {
            InitializeComponent();
            provjeri();
        }
        List<Novi> lista = new List<Novi>();

        private void provjeri()
        {
            var con = SQLStatic.GetSqlkonekcija();
            con.Open();
            string kom = "SELECT Nazivproizvoda , Kolicina,minimalna, imesklad, red , polica FROM Stanje";
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
                int d = (int)reader["minimalna"];
                prijenos1.Minimalna = d;
               
                prijenos1.Kolicina_proizvoda = a;
             
                prijenos1.Polica = c.ToString();

                lista.Add(prijenos1);

            }

            foreach (var s in lista)
            {
                if (s.Kolicina_proizvoda <= s.Minimalna)
                {
                    string[] red = { s.Naziv_proizvoda, s.Kolicina_proizvoda.ToString(), s.Ime_Skladista, s.Polica, s.Red};

                    label1.Visible = true;
                    listView1.Visible = true;
                    ListViewItem prenosioc1 = new ListViewItem(red);
                    listView1.Items.Add(prenosioc1);
                }

            }
            con.Close();

        }
        private void Izlaz(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PregledStanja(object sender, EventArgs e)
        {
            new Ispis().Show();


        }

        private void Dodaj(object sender, EventArgs e)
        {
            new Dodaj().Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Skladiste open = new Skladiste();
            open.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-I87B01L;Initial Catalog=wienerberger;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("select * from Stanje where Nazivproizvoda = '" + this.txt_naziv.Text + "'", conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;


        }

    }
}
