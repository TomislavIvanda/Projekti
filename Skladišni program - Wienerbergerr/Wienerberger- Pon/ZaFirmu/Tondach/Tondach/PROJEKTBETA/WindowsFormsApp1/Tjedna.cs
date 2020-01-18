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
    public partial class Tjedna : Form
    {
        int zastavaa;
        
        public Tjedna()
        {
            InitializeComponent();
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tjedna_Load(object sender, EventArgs e)
        {

        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void Nastavi_Click(object sender, EventArgs e)
        {
            new Pregled().Show();
            this.Hide();
        }

        private void Nastavi_Tjedna(object sender, EventArgs e)
        {
            var cnn = SQLStatic.GetSqlkonekcija();
            cnn.Open();
       
            if (textBoxx.Text == "" || textBoxx.Text == "0") { MessageBox.Show(" Morate upisati kolicinu"); cnn.Close(); }
            else zastavaa = 1;
            if (zastavaa == 1) {


                string zadatak = "insert into Narudzbenica (Vrsta, Kolicina) values ( 'Americka palacinka sa bananama i preljevom'  , " + this.textBoxx.Text + ");";
                SqlCommand napravi = new SqlCommand(zadatak, cnn);
                SqlDataReader citac = napravi.ExecuteReader();

                cnn.Close();
                PregledTjedna otvori = new PregledTjedna();
                otvori.Show();
                this.Close();
            }
        }
    }
}
