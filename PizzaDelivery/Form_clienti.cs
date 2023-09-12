using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class Form_clienti : Form

    {
        string stringConexiune = @"Data Source=(localDB)\MSSQLLocalDB;Initial Catalog=DB_Clienti;Integrated Security=True";
        DataSet dsClienti = new DataSet();  
        string SelectCommand = "Select * from dbo.clienti"; 
        
        private static List<Client> listClienti;
        public Form_clienti()
        {
            InitializeComponent();
            listClienti = new List<Client>();
            IncarcaDate();
        }

        private void textBoxPrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void înapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

       
        private void buttonAdaugaC_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if (textBoxNume.Text == "")
                epClienti.SetError(textBoxNume, "Introduceti un nume!");
            else
            if (textBoxPrenume.Text == "")
                epClienti.SetError(textBoxPrenume, "Introduceti un prenume!");
            else
            if (textBoxCNP.Text == "")
                epClienti.SetError(textBoxCNP, "Introduceti CNP!");
            else
            if (textBoxEmail.Text == "")
                epClienti.SetError(textBoxEmail, "Introduceti email-ul!");

            else
            {
                client.Nume = textBoxNume.Text;
                client.Prenume = textBoxPrenume.Text;

                client.Cnp = textBoxCNP.Text;
                client.Email = textBoxEmail.Text;
                if (radioButtonM.Checked)
                    client.Sex = radioButtonM.Text;
                else
                    client.Sex = radioButtonF.Text;
                
                try
                {
                    if (textBoxVarsta.Text == "")
                        throw new ExceptieVal();
                    else if (textBoxVarsta.Text.All(char.IsDigit)) //validare date introduse sa fie numerice
                    {
                        client.Varsta = Convert.ToInt32(textBoxVarsta.Text);
                        listClienti.Add(client); //adaug in lista de clienti
                        golireForm();
                    }
                    else
                        MessageBox.Show("Format incorect pentru vârsta! Introduceți un număr!");
                }
                catch (ExceptieVal exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }


        }

        private void buttonAfiseazaC_Click(object sender, EventArgs e)
        {
            populareListView();
        }

        //creare functii
        private void golireForm()
        {
            textBoxNume.Clear();
            textBoxPrenume.Clear();
            textBoxCNP.Clear();
            radioButtonM.Checked = false;
            radioButtonF.Checked = false;
            textBoxEmail.Clear();
            textBoxVarsta.Clear();

        }

        private void stergeLista()
        {
            listViewClienti.Items.Clear();
        }

        private void populareListView()
        {
            foreach (Client client in listClienti)
            {
                ListViewItem item = new ListViewItem(client.Nume);
                item.SubItems.Add(client.Prenume);
                item.SubItems.Add(client.Cnp.ToString());
                item.SubItems.Add(client.Sex);
                item.SubItems.Add(client.Email);
                item.SubItems.Add(client.Varsta.ToString());

                listViewClienti.Items.Add(item);
            }
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void textBoxNume_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNume.Text == "")//validare campul sa nu fie nul
            {
                epClienti.SetError((Control)sender, "Câmp gol. Introduceți un nume!");
                e.Cancel = true;
            }
            if (textBoxNume.Text.Any(char.IsDigit))//validare campul sa nu fie numar
            {
                epClienti.SetError((Control)sender, "Introduceti un sir de caractere!");
                e.Cancel = true;
            }
        }

        //validari nume si prenume (camp vid si introducere sir de caractere)
        private void textBoxNume_Validated(object sender, EventArgs e)
        {
            epClienti.Clear();
        }

        private void textBoxPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPrenume.Text == "")
            {
                epClienti.SetError((Control)sender, "Câmp gol. Introduceți un prenume!");
                e.Cancel = true;
            }
            if (textBoxPrenume.Text.Any(char.IsDigit))
            {
                epClienti.SetError((Control)sender, "Introduceti un sir de caractere!");
                e.Cancel = true;
            }
        }

        private void textBoxPrenume_Validated(object sender, EventArgs e)
        {
            epClienti.Clear();
        }

        //validare CNP sa aiba fix 13 cifre

        private void textBoxCNP_Validating(object sender, CancelEventArgs e)
        {
            
            if (textBoxCNP.Text == "")
            {
                epClienti.SetError((Control)sender, "Câmp gol. Introduceți CNP-ul!");
                e.Cancel = true;
            }
            if (textBoxCNP.Text.Length!=13)
            {
                epClienti.SetError((Control)sender, "CNP invalid. Introduceti 13 cifre!");
                e.Cancel = true;
            }
        }

        private void textBoxCNP_Validated(object sender, EventArgs e)
        {
            epClienti.Clear();
        }



        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            /*
            if (textBoxEmail.Text.IndexOf("@") > -1)
            {
               // if (textBoxEmail.Text.IndexOf(".", textBoxEmail.Text.IndexOf("@")) > textBoxEmail.Text.IndexOf("@"))
                               
                e.Cancel = false;
                
            }

            epClienti.SetError((Control)sender, "Email invalid. Introduceti @ !");
            e.Cancel = true;
            */
        }

        private void imprimareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Calibri", 14);
            Brush brush = Brushes.Orange;
            Pen pen = new Pen(brush);
            PageSettings settings = printDocument.DefaultPageSettings;
            var totalW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalH;
                totalH = totalW;
                totalW = temp;
            }

            var cellW = totalW / 4;
            var cellH = 40;

            int x = settings.Margins.Left;
            int y = 100;

            //desenare cap tabel
            graphics.DrawRectangle(pen, x, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 3, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 4, y, cellW, cellH);

            //desenare text coloane
            graphics.DrawString("Nume", font, brush, x, y);
            graphics.DrawString("Prenume", font, brush, x + cellW, y);
            graphics.DrawString("CNP", font, brush, x + cellW * 2, y);
            graphics.DrawString("Email", font, brush, x + cellW * 3, y);
            graphics.DrawString("Sex", font, brush, x + cellW * 4, y);

            y += cellH;
            foreach (Client c in listClienti)
            {
                graphics.DrawRectangle(pen, x, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 3, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 4, y, cellW, cellH);

                //desenare celula
                graphics.DrawString(c.Nume, font, brush, x, y);
                graphics.DrawString(c.Prenume, font, brush, x + cellW, y);
                graphics.DrawString(c.Cnp, font, brush, x + cellW * 2, y);
                graphics.DrawString(c.Email, font, brush, x + cellW * 3, y);
                graphics.DrawString(c.Sex, font, brush, x + cellW * 4, y);

                y += cellH;
            }


        }

        //acces testatura pentru inchidere formular clienti (ACCELERATORI)
        private void Form_clienti_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; 
        }

        private void Form_clienti_MouseDown(object sender, MouseEventArgs e)
        {
            //
        }

        private void Form_clienti_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control== true && e.KeyCode==Keys.B)
            {
                înapoiToolStripMenuItem.PerformClick();
            }

        }

        private void buttonStergeLista_Click(object sender, EventArgs e)
        {
            stergeLista();
        }

        private void interogareBazaDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BD fbd = new Form_BD();
            fbd.ShowDialog();
            this.Show();

        }

        //BD
        
        void IncarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();//deschidem conexiunea
            SqlDataAdapter adaptor = new SqlDataAdapter(SelectCommand, conexiune);
            adaptor.Fill(dsClienti, "Clienti"); //preluam datele din BD si le ducem in DataSet-ul din memorie
            dsClienti.Tables["Clienti"].PrimaryKey = new DataColumn[1] //vector de chei primare
            {
                dsClienti.Tables["Clienti"].Columns["Id"]};
            
            conexiune.Close();//inchidem conexiunea
            
            //NU
            comboBox1.DataSource = dsClienti.Tables["Clienti"];
            comboBox1.DisplayMember = "Nume";
            comboBox1.ValueMember = "Id";

           
            comboBox1.DataSource = dsClienti.Tables["Clienti"];//stie ca trebuie sa aduca in acel control din tabela Clienti
            comboBox1.DisplayMember = "Nume";
            comboBox1.ValueMember = "Id";
        }
    }
}
