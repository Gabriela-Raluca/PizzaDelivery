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
    public partial class Form_grafic : Form
    {
        public Form_grafic()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //
        }

        private void buttonGrafic_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Varsta"].Points.AddXY("Costache Alina",27);
            this.chart1.Series["Varsta"].Points.AddXY("Marin Andrei", 23);
            this.chart1.Series["Varsta"].Points.AddXY("Popescu Maria", 33);
            this.chart1.Series["Varsta"].Points.AddXY("Stan Cornelia", 35);
            this.chart1.Series["Varsta"].Points.AddXY("Ionescu Robert",20);
            this.chart1.Series["Varsta"].Points.AddXY("Chirita Andra", 56);
        }

        private void înapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
