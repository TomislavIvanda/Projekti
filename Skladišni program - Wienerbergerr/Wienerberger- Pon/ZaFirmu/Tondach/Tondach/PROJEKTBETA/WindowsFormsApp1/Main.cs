using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MainNapravi_Click(object sender, EventArgs e)
        {
            new Make().Show();
            this.Hide();
        }

        private void MainIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void MainOdaberi_Click(object sender, EventArgs e)
        {
            new Odaberi().Show();
            this.Hide();
        }

        private void MainTjedna_Click(object sender, EventArgs e)
        {
            new Tjedna().Show();
            this.Hide();
        }
    }
}
