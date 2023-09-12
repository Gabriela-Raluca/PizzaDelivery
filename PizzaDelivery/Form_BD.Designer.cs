namespace PizzaDelivery
{
    partial class Form_BD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BD));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ClientiDataSet = new PizzaDelivery.DB_ClientiDataSet();
            this.clientiTableAdapter = new PizzaDelivery.DB_ClientiDataSetTableAdapters.ClientiTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.înapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.comboBoxBD = new System.Windows.Forms.ComboBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxPren = new System.Windows.Forms.TextBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxVrst = new System.Windows.Forms.TextBox();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.buttonActualizare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClientiDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.varstaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // varstaDataGridViewTextBoxColumn
            // 
            this.varstaDataGridViewTextBoxColumn.DataPropertyName = "Varsta";
            this.varstaDataGridViewTextBoxColumn.HeaderText = "Varsta";
            this.varstaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varstaDataGridViewTextBoxColumn.Name = "varstaDataGridViewTextBoxColumn";
            this.varstaDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.dB_ClientiDataSet;
            // 
            // dB_ClientiDataSet
            // 
            this.dB_ClientiDataSet.DataSetName = "DB_ClientiDataSet";
            this.dB_ClientiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.înapoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // înapoiToolStripMenuItem
            // 
            this.înapoiToolStripMenuItem.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.înapoiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.înapoiToolStripMenuItem.Name = "înapoiToolStripMenuItem";
            this.înapoiToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.înapoiToolStripMenuItem.Text = "Înapoi";
            this.înapoiToolStripMenuItem.Click += new System.EventHandler(this.înapoiToolStripMenuItem_Click);
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.Font = new System.Drawing.Font("Poor Richard", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvare.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSalvare.Location = new System.Drawing.Point(91, 245);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(93, 36);
            this.buttonSalvare.TabIndex = 2;
            this.buttonSalvare.Text = "Salvare";
            this.buttonSalvare.UseVisualStyleBackColor = true;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // comboBoxBD
            // 
            this.comboBoxBD.FormattingEnabled = true;
            this.comboBoxBD.Location = new System.Drawing.Point(219, 245);
            this.comboBoxBD.Name = "comboBoxBD";
            this.comboBoxBD.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBD.TabIndex = 3;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(76, 327);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(125, 22);
            this.textBoxNum.TabIndex = 4;
            // 
            // textBoxPren
            // 
            this.textBoxPren.Location = new System.Drawing.Point(223, 326);
            this.textBoxPren.Name = "textBoxPren";
            this.textBoxPren.Size = new System.Drawing.Size(125, 22);
            this.textBoxPren.TabIndex = 5;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(370, 326);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(125, 22);
            this.textBoxCod.TabIndex = 6;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(664, 327);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(125, 22);
            this.textBoxMail.TabIndex = 7;
            // 
            // textBoxVrst
            // 
            this.textBoxVrst.Location = new System.Drawing.Point(811, 326);
            this.textBoxVrst.Name = "textBoxVrst";
            this.textBoxVrst.Size = new System.Drawing.Size(125, 22);
            this.textBoxVrst.TabIndex = 8;
            // 
            // textBoxSex
            // 
            this.textBoxSex.Location = new System.Drawing.Point(517, 327);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.Size = new System.Drawing.Size(125, 22);
            this.textBoxSex.TabIndex = 11;
            // 
            // buttonActualizare
            // 
            this.buttonActualizare.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizare.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonActualizare.Location = new System.Drawing.Point(400, 381);
            this.buttonActualizare.Name = "buttonActualizare";
            this.buttonActualizare.Size = new System.Drawing.Size(192, 49);
            this.buttonActualizare.TabIndex = 12;
            this.buttonActualizare.Text = "Actualizare";
            this.buttonActualizare.UseVisualStyleBackColor = true;
            this.buttonActualizare.Click += new System.EventHandler(this.buttonActualizare_Click);
            // 
            // Form_BD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaDelivery.Properties.Resources._1__1_;
            this.ClientSize = new System.Drawing.Size(956, 474);
            this.Controls.Add(this.buttonActualizare);
            this.Controls.Add(this.textBoxSex);
            this.Controls.Add(this.textBoxVrst);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.textBoxPren);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.comboBoxBD);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_BD";
            this.Text = "Form_BD";
            this.Load += new System.EventHandler(this.Form_BD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClientiDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_ClientiDataSet dB_ClientiDataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private DB_ClientiDataSetTableAdapters.ClientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem înapoiToolStripMenuItem;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.ComboBox comboBoxBD;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxPren;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxVrst;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.Button buttonActualizare;
    }
}