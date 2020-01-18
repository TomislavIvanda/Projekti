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

namespace Main
{
    public partial class Odaberi : Form
    {
        int zastavaaa;
       
        public Odaberi()
        {
            InitializeComponent();
        }



        private void Natrag_Click(object sender, EventArgs e)
        {
            Main otvori = new Main();
            otvori.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZavrsnoDataSet2.Odaberi' table. You can move, or remove it, as needed.
            this.odaberiTableAdapter.Fill(this.projektZavrsnoDataSet2.Odaberi);

        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Nastavi_Click(object sender, EventArgs e)
        {
            var cnn = SQLStatic.GetSqlkonekcija();
            cnn.Open();

            if (textBox8.Text == "" || textBox8.Text == "0") { MessageBox.Show(" Morate upisati kolicinu"); cnn.Close(); }
            else zastavaaa = 1;
            if (zastavaaa == 1)
            {

                string zadatak = "insert into Narudzbenica (Vrsta, Kolicina) values ( '" + this.comboBox4.Text + "', " + this.textBox8.Text + ");";
                SqlCommand napravi = new SqlCommand(zadatak, cnn);
                SqlDataReader citac = napravi.ExecuteReader();

                cnn.Close();
                PregledOdabranih otvori = new PregledOdabranih();
                otvori.Show();
                this.Close();
            }


        }
    }

}
