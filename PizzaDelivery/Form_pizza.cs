using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class Form_pizza : Form
    {
        string p = null;
        public Form_pizza()
        {
            InitializeComponent();
            Pizza p = new Pizza("Diavolla","Blat,sos,mozzarella,pepperoni",22, "Indisponibila");
            Pizza p2 = new Pizza("Pollo", "Blat,sos,mozzarella,pui, ciuperci,masline", 26, "Indisponibila");
            Pizza p3 = new Pizza("Margherita", "Blat,sos,mozzarellai", 20,"Indisponibila");

            ListViewItem lvi = new ListViewItem(p.denumire); 
            lvi.SubItems.Add(p.ingrediente); 
            lvi.SubItems.Add(p.pret.ToString()+ " lei"); 
            lvi.SubItems.Add(p.poza);

            ListViewItem lvi2 = new ListViewItem(p2.denumire); 
            lvi2.SubItems.Add(p2.ingrediente); 
            lvi2.SubItems.Add(p2.pret.ToString()+ " lei"); 
            lvi2.SubItems.Add(p2.poza);

            ListViewItem lvi3 = new ListViewItem(p3.denumire); 
            lvi3.SubItems.Add(p3.ingrediente); 
            lvi3.SubItems.Add(p3.pret.ToString()+ " lei"); 
            lvi3.SubItems.Add(p3.poza);
            lvi.Tag = p; 
            listView1.Items.Add(lvi); 
            listView1.Items.Add(lvi2);
            listView1.Items.Add(lvi3);

        }


        //drag&drop
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Image = null;
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);
            p = null;
            foreach (string s in fileList)
            {
                listBox1.Items.Add(s);
                p = p + s;
            }

            if (listBox1.Items.ToString() != null)
            {
                pictureBox1.ImageLocation = p;
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void buttonAdaugaPizza_Click(object sender, EventArgs e)
        {
            Pizza p = new Pizza (textBoxDenumire.Text,textBoxIngred.Text, Convert.ToInt32(textBoxPret.Text), listBox1.Text);
            ListViewItem lvi = new ListViewItem(p.denumire);
            lvi.SubItems.Add(p.ingrediente);
            lvi.SubItems.Add(p.pret.ToString()+ " lei");
            lvi.SubItems.Add(p.poza);

            lvi.UseItemStyleForSubItems = false;
            lvi.Tag = p; 
            listView1.Items.Add(lvi);

            textBoxDenumire.Clear();
            textBoxIngred.Clear();
            textBoxPret.Clear();
            
            
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            //
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) //daca avem o inreg selectata
            {
                Pizza p = (Pizza)listView1.SelectedItems[0].Tag; //preiau numele clientului selectat
                // mesaj confirmare stergere inregistrare
                DialogResult rezultat = MessageBox.Show("Doriti sa stergeti din meniu pizza  " + p.denumire + "?", "Confirmati!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rezultat == DialogResult.Yes) 
                    listView1.SelectedItems[0].Remove();
            }
        }

        //salvare in fisier
        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog file = new SaveFileDialog();

            //verificam calea introdusa de utilizator sa fie valida
            file.CheckPathExists = true;
            file.Filter = "Fisier Binar (*.pizza)|*.pizza";
            if (file.ShowDialog() == DialogResult.OK) 
            {
                Stream fb = File.Create(file.FileName); 
                BinaryFormatter serializator = new BinaryFormatter();
                List<Pizza> lista_pizza = listView1.Items.Cast<ListViewItem>().Select(item => (Pizza)item.Tag).ToList(); //preia datele din inregistrari prin Tag
                serializator.Serialize(fb, lista_pizza);
                fb.Close();
            }
        }

        //preluare din fisier
        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
             OpenFileDialog file = new OpenFileDialog();

            file.CheckPathExists = true; //verificare cale valida
            file.CheckFileExists = true; //verificare existenta fisier
            file.Filter = "Fisier Binar (*.pizza)|*.pizza";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.OpenRead(file.FileName);
                BinaryFormatter deserializator = new BinaryFormatter();
                List<Pizza> lista_pizza = (List<Pizza>)deserializator.Deserialize(fb);

                listView1.Items.Clear();

                foreach(Pizza p in lista_pizza)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" ,""});
                    lvi.Tag = p;
                    listView1.Items.Add(lvi);
                }
                UpdateItems();
                fb.Close();
            }
        }

        private void UpdateItems()
        {
            foreach(ListViewItem lvi in listView1.Items)
            {
                Pizza p = (Pizza)lvi.Tag;
                lvi.Text = p.denumire;
                lvi.SubItems[1].Text = p.ingrediente;
                lvi.SubItems[2].Text = p.pret.ToString();
                lvi.SubItems[3].Text = p.poza;
            }
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
