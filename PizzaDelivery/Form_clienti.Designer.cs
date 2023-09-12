namespace PizzaDelivery
{
    partial class Form_clienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_clienti));
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelCNP = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelData_n = new System.Windows.Forms.Label();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.textBoxVarsta = new System.Windows.Forms.TextBox();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.listViewClienti = new System.Windows.Forms.ListView();
            this.NumeC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrenumeC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Varsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdaugaC = new System.Windows.Forms.Button();
            this.buttonAfiseazaC = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.înapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interogareBazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epClienti = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.buttonStergeLista = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNume.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNume.Location = new System.Drawing.Point(48, 69);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(60, 24);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrenume.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPrenume.Location = new System.Drawing.Point(266, 69);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(85, 24);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCNP.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCNP.Location = new System.Drawing.Point(48, 136);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(44, 24);
            this.labelCNP.TabIndex = 2;
            this.labelCNP.Text = "CNP";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSex.ForeColor = System.Drawing.Color.DarkRed;
            this.labelSex.Location = new System.Drawing.Point(266, 134);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(38, 24);
            this.labelSex.TabIndex = 3;
            this.labelSex.Text = "Sex";
            // 
            // labelData_n
            // 
            this.labelData_n.AutoSize = true;
            this.labelData_n.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelData_n.ForeColor = System.Drawing.Color.DarkRed;
            this.labelData_n.Location = new System.Drawing.Point(48, 207);
            this.labelData_n.Name = "labelData_n";
            this.labelData_n.Size = new System.Drawing.Size(56, 24);
            this.labelData_n.TabIndex = 4;
            this.labelData_n.Text = "Email";
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVarsta.ForeColor = System.Drawing.Color.DarkRed;
            this.labelVarsta.Location = new System.Drawing.Point(266, 205);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(62, 24);
            this.labelVarsta.TabIndex = 5;
            this.labelVarsta.Text = "Varsta";
            // 
            // textBoxNume
            // 
            this.textBoxNume.BackColor = System.Drawing.Color.DarkSalmon;
            this.textBoxNume.Location = new System.Drawing.Point(109, 66);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(124, 22);
            this.textBoxNume.TabIndex = 6;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            this.textBoxNume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNume_Validating);
            this.textBoxNume.Validated += new System.EventHandler(this.textBoxNume_Validated);
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.BackColor = System.Drawing.Color.DarkSalmon;
            this.textBoxPrenume.Location = new System.Drawing.Point(350, 66);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(124, 22);
            this.textBoxPrenume.TabIndex = 7;
            this.textBoxPrenume.TextChanged += new System.EventHandler(this.textBoxPrenume_TextChanged);
            this.textBoxPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrenume_Validating);
            this.textBoxPrenume.Validated += new System.EventHandler(this.textBoxPrenume_Validated);
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.BackColor = System.Drawing.Color.DarkSalmon;
            this.textBoxCNP.Location = new System.Drawing.Point(109, 131);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(124, 22);
            this.textBoxCNP.TabIndex = 8;
            this.textBoxCNP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCNP_Validating);
            this.textBoxCNP.Validated += new System.EventHandler(this.textBoxCNP_Validated);
            // 
            // textBoxVarsta
            // 
            this.textBoxVarsta.BackColor = System.Drawing.Color.DarkSalmon;
            this.textBoxVarsta.Location = new System.Drawing.Point(350, 202);
            this.textBoxVarsta.Name = "textBoxVarsta";
            this.textBoxVarsta.Size = new System.Drawing.Size(124, 22);
            this.textBoxVarsta.TabIndex = 9;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.ForeColor = System.Drawing.Color.DarkRed;
            this.radioButtonM.Location = new System.Drawing.Point(320, 130);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(84, 21);
            this.radioButtonM.TabIndex = 10;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Masculin";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.ForeColor = System.Drawing.Color.DarkRed;
            this.radioButtonF.Location = new System.Drawing.Point(320, 157);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(78, 21);
            this.radioButtonF.TabIndex = 11;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "Feminin";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // listViewClienti
            // 
            this.listViewClienti.BackColor = System.Drawing.Color.Moccasin;
            this.listViewClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumeC,
            this.PrenumeC,
            this.CNP,
            this.Sex,
            this.Email,
            this.Varsta});
            this.listViewClienti.FullRowSelect = true;
            this.listViewClienti.GridLines = true;
            this.listViewClienti.HideSelection = false;
            this.listViewClienti.Location = new System.Drawing.Point(510, 47);
            this.listViewClienti.Name = "listViewClienti";
            this.listViewClienti.Size = new System.Drawing.Size(490, 228);
            this.listViewClienti.TabIndex = 13;
            this.listViewClienti.UseCompatibleStateImageBehavior = false;
            this.listViewClienti.View = System.Windows.Forms.View.Details;
            // 
            // NumeC
            // 
            this.NumeC.Text = "Nume";
            this.NumeC.Width = 92;
            // 
            // PrenumeC
            // 
            this.PrenumeC.Text = "Prenume";
            this.PrenumeC.Width = 93;
            // 
            // CNP
            // 
            this.CNP.Text = "CNP";
            this.CNP.Width = 83;
            // 
            // Sex
            // 
            this.Sex.Text = "Sex";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 97;
            // 
            // Varsta
            // 
            this.Varsta.Text = "Varsta";
            // 
            // buttonAdaugaC
            // 
            this.buttonAdaugaC.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonAdaugaC.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaC.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonAdaugaC.Location = new System.Drawing.Point(163, 287);
            this.buttonAdaugaC.Name = "buttonAdaugaC";
            this.buttonAdaugaC.Size = new System.Drawing.Size(154, 69);
            this.buttonAdaugaC.TabIndex = 14;
            this.buttonAdaugaC.Text = "Adaugă înregistrare";
            this.buttonAdaugaC.UseVisualStyleBackColor = false;
            this.buttonAdaugaC.Click += new System.EventHandler(this.buttonAdaugaC_Click);
            // 
            // buttonAfiseazaC
            // 
            this.buttonAfiseazaC.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonAfiseazaC.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfiseazaC.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonAfiseazaC.Location = new System.Drawing.Point(529, 314);
            this.buttonAfiseazaC.Name = "buttonAfiseazaC";
            this.buttonAfiseazaC.Size = new System.Drawing.Size(216, 42);
            this.buttonAfiseazaC.TabIndex = 15;
            this.buttonAfiseazaC.Text = "Afișează înregistrări";
            this.buttonAfiseazaC.UseVisualStyleBackColor = false;
            this.buttonAfiseazaC.Click += new System.EventHandler(this.buttonAfiseazaC_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.înapoiToolStripMenuItem,
            this.imprimareToolStripMenuItem,
            this.interogareBazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 37);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // înapoiToolStripMenuItem
            // 
            this.înapoiToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.înapoiToolStripMenuItem.Name = "înapoiToolStripMenuItem";
            this.înapoiToolStripMenuItem.Size = new System.Drawing.Size(78, 33);
            this.înapoiToolStripMenuItem.Text = "Înapoi";
            this.înapoiToolStripMenuItem.Click += new System.EventHandler(this.înapoiToolStripMenuItem_Click);
            // 
            // imprimareToolStripMenuItem
            // 
            this.imprimareToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            this.imprimareToolStripMenuItem.Size = new System.Drawing.Size(114, 33);
            this.imprimareToolStripMenuItem.Text = "Imprimare";
            this.imprimareToolStripMenuItem.Click += new System.EventHandler(this.imprimareToolStripMenuItem_Click);
            // 
            // interogareBazaDeDateToolStripMenuItem
            // 
            this.interogareBazaDeDateToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.interogareBazaDeDateToolStripMenuItem.Name = "interogareBazaDeDateToolStripMenuItem";
            this.interogareBazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(219, 33);
            this.interogareBazaDeDateToolStripMenuItem.Text = "Interogare baza de date";
            this.interogareBazaDeDateToolStripMenuItem.Click += new System.EventHandler(this.interogareBazaDeDateToolStripMenuItem_Click);
            // 
            // epClienti
            // 
            this.epClienti.ContainerControl = this;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.DarkSalmon;
            this.textBoxEmail.Location = new System.Drawing.Point(109, 202);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(124, 22);
            this.textBoxEmail.TabIndex = 17;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // buttonStergeLista
            // 
            this.buttonStergeLista.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonStergeLista.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergeLista.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonStergeLista.Location = new System.Drawing.Point(767, 314);
            this.buttonStergeLista.Name = "buttonStergeLista";
            this.buttonStergeLista.Size = new System.Drawing.Size(213, 42);
            this.buttonStergeLista.TabIndex = 18;
            this.buttonStergeLista.Text = "Șterge lista";
            this.buttonStergeLista.UseVisualStyleBackColor = false;
            this.buttonStergeLista.Click += new System.EventHandler(this.buttonStergeLista_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(320, 433);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // Form_clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1036, 409);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonStergeLista);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonAfiseazaC);
            this.Controls.Add(this.buttonAdaugaC);
            this.Controls.Add(this.listViewClienti);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.textBoxVarsta);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelVarsta);
            this.Controls.Add(this.labelData_n);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_clienti";
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.Form_clienti_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_clienti_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_clienti_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelData_n;
        private System.Windows.Forms.Label labelVarsta;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.TextBox textBoxVarsta;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.ListView listViewClienti;
        private System.Windows.Forms.ColumnHeader NumeC;
        private System.Windows.Forms.ColumnHeader PrenumeC;
        private System.Windows.Forms.ColumnHeader CNP;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Varsta;
        private System.Windows.Forms.Button buttonAdaugaC;
        private System.Windows.Forms.Button buttonAfiseazaC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem înapoiToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider epClienti;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ToolStripMenuItem imprimareToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Button buttonStergeLista;
        private System.Windows.Forms.ToolStripMenuItem interogareBazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}