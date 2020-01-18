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
    public partial class Pregled : Form
    {
        
        int pocetna_cijena = 17; int kolicina;
        public Pregled()
        {
            InitializeComponent();
            prikazi();
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Narudžba uspješno poslana");
        }

        private void natragpregled(object sender, EventArgs e)
        {
            Make otvori = new Make();
            otvori.Show();
            this.Close();
        }
    

        private void prikazi()
        {
            {
                var cnn = SQLStatic.GetSqlkonekcija();
                cnn.Open();



                string zadatak = "SELECT * FROM Narudzbenica WHERE Rednibroj = (SELECT MAX(Rednibroj) FROM Narudzbenica)";

                SqlCommand cmm = new SqlCommand(zadatak, cnn);
                SqlDataReader rd = cmm.ExecuteReader();
                if (rd.Read())
                {
                    textBox3.Text = (rd["Vrsta"].ToString());
                    textBox2.Text = (rd["Dodatak"].ToString());
                    textBox5.Text = (rd["Kolicina"].ToString());
                    kolicina = int.Parse(textBox5.Text);
                    textBox2.Text = (rd["Dodatak"].ToString());
                    textBox4.Text = (pocetna_cijena * kolicina).ToString();

                }
                cnn.Close();
            }


        }
    }
}
