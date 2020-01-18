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
    public partial class Skladiste : Form
    {
        public Skladiste()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var cnn = SQLStatic.GetSqlkonekcija();
            cnn.Open();
            {


                string zadatak = "insert into Skladiste(ime_sklad,adresa) values ( '" + this.textBox1.Text + "', '" + this.textBox2.Text + "');";
                SqlCommand napravi = new SqlCommand(zadatak, cnn);
                SqlDataReader citac = napravi.ExecuteReader();
                cnn.Close();

                MessageBox.Show("Uspjesno ste unjeli novo skladiste");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna open = new Pocetna();
            open.Show();
        }
    }
}
