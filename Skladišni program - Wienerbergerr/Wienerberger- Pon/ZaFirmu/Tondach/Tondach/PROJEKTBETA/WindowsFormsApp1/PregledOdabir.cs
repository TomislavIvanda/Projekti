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
    public partial class PregledOdabranih : Form
    {
       
        int pocetna_cijena = 20; int kolicina;
        public PregledOdabranih()
        {
            InitializeComponent();
            prikazii();
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Narudžba uspješno poslana");
        }

       
    

        private void prikazii()
        {
            {
                var cnn = SQLStatic.GetSqlkonekcija();
                cnn.Open();



                string zadatak = "SELECT * FROM Narudzbenica WHERE Rednibroj = (SELECT MAX(Rednibroj) FROM Narudzbenica)";

                SqlCommand cmm = new SqlCommand(zadatak, cnn);
                SqlDataReader rd = cmm.ExecuteReader();
                if (rd.Read())
                {
                    textBox3OD.Text = (rd["Vrsta"].ToString());
                   
                    textBox5.Text = (rd["Kolicina"].ToString());
                    kolicina = int.Parse(textBox5.Text);
                  
                    textBox4.Text = (pocetna_cijena * kolicina).ToString();

                }
                cnn.Close();
            }


        }

        private void IzlazDodaci(object sender, EventArgs e)
        {
            MessageBox.Show("Narudžba uspješno poslana");
        }

        private void NatragOdabrana(object sender, EventArgs e)
        {
            Odaberi otvori = new Odaberi();
            otvori.Show();
            this.Close();
        }
    }
}
