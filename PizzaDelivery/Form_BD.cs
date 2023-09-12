using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class Form_BD : Form
    {
        string stringConexiune = @"Data Source=(localDB)\MSSQLLocalDB;Initial Catalog=DB_Clienti;Integrated Security=True";
        DataSet dsClienti = new DataSet();  
        string SelectCommand = "select * from dbo.clienti"; 

        public Form_BD()
        {
            InitializeComponent();
            IncarcaDate2();
            
            
        }

        private void Form_BD_Load(object sender, EventArgs e)
        {
            
            this.clientiTableAdapter.Fill(this.dB_ClientiDataSet.Clienti);

        }

        private void înapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientiBindingSource.EndEdit();
                this.clientiTableAdapter.Update(this.dB_ClientiDataSet.Clienti);
                MessageBox.Show("Modificarile s-au salvat in baza de date!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
            void IncarcaDate2()
            {
                SqlConnection conexiune = new SqlConnection(stringConexiune);
                conexiune.Open();//deschidem conexiunea
                SqlDataAdapter adaptor = new SqlDataAdapter(SelectCommand, conexiune);
                adaptor.Fill(dsClienti, "Clienti"); 
                dsClienti.Tables["Clienti"].PrimaryKey = new DataColumn[1] //vector de chei primare
                {
                dsClienti.Tables["Clienti"].Columns["Id"]};

                conexiune.Close();//inchidem conexiunea

                //Data binding
                comboBoxBD.DataSource = dsClienti.Tables["Clienti"];                             
                comboBoxBD.DisplayMember = "Nume";
                comboBoxBD.ValueMember = "Id";

                comboBoxBD.DataSource = dsClienti.Tables["Clienti"];//stie ca trebuie sa aduca in acel control din tabela Clienti
                comboBoxBD.DisplayMember = "Nume";
                comboBoxBD.ValueMember = "Id";

            //trimit catre textboxuri informatiile din DB
            textBoxNum.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "Nume");
            textBoxPren.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "Prenume");
            textBoxCod.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "CNP");
            textBoxSex.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "Sex");
            textBoxMail.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "Email");
            textBoxVrst.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "Varsta");
        }

        //iau date din textbox-uri si le transmit in BD
        private void buttonActualizare_Click(object sender, EventArgs e)
        {
            BindingManagerBase leg = BindingContext[dsClienti.Tables["Clienti"]];
            leg.EndCurrentEdit();
            string UpdateCommand = "update dbo.clienti set Nume=@Nume,Prenume=@Prenume, CNP=@CNP, Sex=@Sex, Email=@Email, Varsta=@Varsta where Id=@Id";

            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(SelectCommand, conexiune);
            adaptor.UpdateCommand = conexiune.CreateCommand();
            
            adaptor.UpdateCommand.CommandText = UpdateCommand;
            adaptor.UpdateCommand.Parameters.AddWithValue("@Nume", textBoxNum.Text); 
            adaptor.UpdateCommand.Parameters.AddWithValue("@Prenume", textBoxPren.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@CNP", textBoxCod.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Sex", textBoxSex.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Email", textBoxMail.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Varsta", textBoxVrst.Text);
            int Id = Int32.Parse(comboBoxBD.SelectedValue.ToString());

            adaptor.UpdateCommand.Parameters.AddWithValue("@Id", Id);

            //verific daca exista vreo modificare in textbox
           DataSet dsClientiActualiz = dsClienti.GetChanges(DataRowState.Modified);

            
            if (dsClientiActualiz !=null)
            {
               int i= adaptor.Update(dsClientiActualiz, "Clienti");
                MessageBox.Show("Actualizare cu succes! Numarul liniilor actualizate este: " + i + " linii");
                dsClienti.Tables["Clienti"].AcceptChanges();
            }


            conexiune.Close();


        }
    }
    }

