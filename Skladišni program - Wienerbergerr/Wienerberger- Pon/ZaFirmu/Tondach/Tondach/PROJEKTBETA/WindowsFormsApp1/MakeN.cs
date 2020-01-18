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
    public partial class Make : Form

    {
        
     int zastava;
        

        public Make()
        {
            InitializeComponent();
            popuni_combo();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main otvori = new Main();
            otvori.Show();
            this.Close();
        }

        private void popuni_combo()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Pregled().Show();
            this.Hide();
        }

        private void Make_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZavrsnoDataSet1.Dodaci' table. You can move, or remove it, as needed.
            this.dodaciTableAdapter.Fill(this.projektZavrsnoDataSet1.Dodaci);
            // TODO: This line of code loads data into the 'projektZavrsnoDataSet.Vrsta' table. You can move, or remove it, as needed.
            this.vrstaTableAdapter.Fill(this.projektZavrsnoDataSet.Vrsta);

        }

        private void spremi(object sender, EventArgs e)
        {



            var cnn = SQLStatic.GetSqlkonekcija();
            cnn.Open();
            if(textBox1.Text == "" || textBox1.Text =="0") { MessageBox.Show(" Morate upisati kolicinu"); cnn.Close(); }
            else zastava = 1 ;
           if( zastava == 1 ) {
                string zadatak = "insert into Narudzbenica (Vrsta, Dodatak, Kolicina) values ( '" + this.comboBox1.Text + "', '" + this.comboBox2.Text + "'," + this.textBox1.Text + ");";
                SqlCommand napravi = new SqlCommand(zadatak, cnn);
                SqlDataReader citac = napravi.ExecuteReader();

                cnn.Close();

                Pregled otvori = new Pregled();
                otvori.Show();
                this.Close();
            }
           
        }
    }
}
