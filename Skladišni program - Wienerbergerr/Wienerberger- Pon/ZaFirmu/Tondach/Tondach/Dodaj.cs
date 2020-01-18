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
    public partial class Dodaj : Form
    {
        int zastava;
        int kolicina;
        public Dodaj()
        {

            InitializeComponent();
            popuni_combo_artikl();
            popuni_combo_skla();
        }
        private void popuni_combo_skla()
        {
            var cnn = SQLStatic.GetSqlkonekcija();
            cnn.Open();
            string izvadi = "select * from Skladiste;";
            SqlCommand izvadi_cmd = new SqlCommand(izvadi, cnn);
            SqlDataReader citac;
            citac = izvadi_cmd.ExecuteReader();


            while (citac.Read())
            {

                string Snaziv = citac.GetString(0);

                comboBox2.Items.Add(Snaziv);
            }
            cnn.Close();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Spremi(object sender, EventArgs e)
        {

            var cnn = SQLStatic.GetSqlkonekcija();
            cnn.Open();




            string zadatak = "Update Stanje set Kolicina= (Kolicina +  " + numericUpDown1.Text + " - " + numericUpDown2.Text + ")  where Nazivproizvoda = '" + comboBox1.Text + "';";
            SqlCommand napravi = new SqlCommand(zadatak, cnn);
            SqlDataReader citac = napravi.ExecuteReader();

            cnn.Close();
            comboBox1.Text = "";
            comboBox2.Text = "";
            numericUpDown1.Text = "0";
            numericUpDown2.Text = "0";


        }
        private void DodajNoviP(object sender, EventArgs e)
        {
            Novi otvori = new Novi();
            otvori.Show();
            this.Close();
        }

        private void IzlazZ(object sender, EventArgs e)
        {
            Pocetna otvori = new Pocetna();
            otvori.Show();
            this.Close();
        }


        private void DodajStvar(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void popuni_combo_artikl()
        {
            comboBox1.Items.Clear();
            var cnn = SQLStatic.GetSqlkonekcija();
            cnn.Open();
            string izvadi = "select * from Stanje where imesklad = '" + this.comboBox2.Text + "';";
            SqlCommand izvadi_cmd = new SqlCommand(izvadi, cnn);
            SqlDataReader citac;
            citac = izvadi_cmd.ExecuteReader();
            

            while (citac.Read())
            {

                string Snaziv = citac.GetString(1);

                comboBox1.Items.Add(Snaziv);
            }
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pocetna otvori = new Pocetna();
            otvori.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cnn = SQLStatic.GetSqlkonekcija();
            cnn.Open();
            string izvadi1 = "delete  from Stanje where Nazivproizvoda= '" + this.comboBox1.Text + "'  and imesklad = '"+this.comboBox2.Text+"'";
            SqlCommand izvadi_cmd1 = new SqlCommand(izvadi1, cnn);
            SqlDataReader citac1;
            citac1 = izvadi_cmd1.ExecuteReader();

            this.Hide();
            this.Show();
            cnn.Close();
            //comboBox1.Items.Remove(this.comboBox1.Text);
            this.comboBox1.Text = "";
            comboBox1.Items.Clear();
            popuni_combo_artikl();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuni_combo_artikl();
        }
    }
}
