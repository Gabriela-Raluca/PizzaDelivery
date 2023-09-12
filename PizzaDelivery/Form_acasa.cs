using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class Form_acasa : Form
    {
        public Form_acasa()
        {
            InitializeComponent();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //meniu-detalii
        }

        private void clientiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_clienti formc = new Form_clienti();
            formc.ShowDialog();
            this.Show();
        }

        private void statisticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_grafic graf = new Form_grafic();
            graf.ShowDialog();
            this.Show();
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_pizza formp = new Form_pizza();
            formp.ShowDialog();
            this.Show();
        }

        private void închidețiAplicațiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
