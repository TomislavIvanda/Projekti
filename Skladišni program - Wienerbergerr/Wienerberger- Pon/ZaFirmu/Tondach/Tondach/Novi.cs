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
    public partial class Novi : Form
    {
        public string Naziv_proizvoda;
        public int Kolicina_proizvoda;
        public string Ime_Skladista;
        public string Red;
        public int Minimalna;
        public string Polica;
        public Novi()
        {
            InitializeComponent();
            popuni_combo();
        }
        private void popuni_combo()
        {
            var con = SQLStatic.GetSqlkonekcija();
            con.Open();
            string izvadi = "select * from  Skladiste;";
            SqlCommand izvadi_cmd = new SqlCommand(izvadi, con);
            SqlDataReader citac;
            citac = izvadi_cmd.ExecuteReader();


            while (citac.Read())
            {

                string Snaziv = citac.GetString(0);

                comboBox1.Items.Add(Snaziv);
            }
            con.Close();
        }

        private void SpremanjeNoviBaza(object sender, EventArgs e)

        {
            var cnn = SQLStatic.GetSqlkonekcija();
            cnn.Open();
            {


                string zadatak = "insert into Stanje(Nazivproizvoda,Kolicina,minimalna,imesklad, red , polica) values ( '" + this.textbox5.Text + "', " + this.numericUpDown1.Text + ","+this.numericUpDown2.Text+", '" + this.comboBox1.Text + "','" + this.textBox2.Text + "', " + this.textBox4.Text + ");";
                SqlCommand napravi = new SqlCommand(zadatak, cnn);
                SqlDataReader citac = napravi.ExecuteReader();
                cnn.Close();
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textbox5.Text = "";
                numericUpDown1.Text = "";

                MessageBox.Show("Uspjesno ste unjeli proizvod");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Dodaj().Show();
            this.Hide();
        }

        private void Novi_Load(object sender, EventArgs e)
        {

        }
    }
}
