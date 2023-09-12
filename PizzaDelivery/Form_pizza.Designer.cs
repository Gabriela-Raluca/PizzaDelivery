namespace PizzaDelivery
{
    partial class Form_pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_pizza));
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelIngrediente = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelPoza = new System.Windows.Forms.Label();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.textBoxIngred = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Denumire_p = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ingrediente_p = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret_p = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poza_p = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdaugaPizza = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDenumire.Location = new System.Drawing.Point(34, 62);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(92, 24);
            this.labelDenumire.TabIndex = 0;
            this.labelDenumire.Text = "Denumire";
            // 
            // labelIngrediente
            // 
            this.labelIngrediente.AutoSize = true;
            this.labelIngrediente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngrediente.ForeColor = System.Drawing.Color.DarkRed;
            this.labelIngrediente.Location = new System.Drawing.Point(34, 131);
            this.labelIngrediente.Name = "labelIngrediente";
            this.labelIngrediente.Size = new System.Drawing.Size(106, 24);
            this.labelIngrediente.TabIndex = 1;
            this.labelIngrediente.Text = "Ingrediente";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPret.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPret.Location = new System.Drawing.Point(39, 204);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(44, 24);
            this.labelPret.TabIndex = 2;
            this.labelPret.Text = "Pret";
            // 
            // labelPoza
            // 
            this.labelPoza.AutoSize = true;
            this.labelPoza.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoza.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPoza.Location = new System.Drawing.Point(39, 247);
            this.labelPoza.Name = "labelPoza";
            this.labelPoza.Size = new System.Drawing.Size(49, 24);
            this.labelPoza.TabIndex = 3;
            this.labelPoza.Text = "Poza";
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.BackColor = System.Drawing.Color.DarkSalmon;
            this.textBoxDenumire.Location = new System.Drawing.Point(164, 62);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(100, 22);
            this.textBoxDenumire.TabIndex = 4;
            // 
            // textBoxIngred
            // 
            this.textBoxIngred.BackColor = System.Drawing.Color.DarkSalmon;
            this.textBoxIngred.Location = new System.Drawing.Point(164, 114);
            this.textBoxIngred.Multiline = true;
            this.textBoxIngred.Name = "textBoxIngred";
            this.textBoxIngred.Size = new System.Drawing.Size(168, 63);
            this.textBoxIngred.TabIndex = 5;
            // 
            // textBoxPret
            // 
            this.textBoxPret.BackColor = System.Drawing.Color.DarkSalmon;
            this.textBoxPret.Location = new System.Drawing.Point(164, 207);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(100, 22);
            this.textBoxPret.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(164, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 20);
            this.listBox1.TabIndex = 7;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiatiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 28);
            // 
            // copiatiToolStripMenuItem
            // 
            this.copiatiToolStripMenuItem.Name = "copiatiToolStripMenuItem";
            this.copiatiToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.copiatiToolStripMenuItem.Text = "Copiati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(25, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introduceti aici ->";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Moccasin;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Denumire_p,
            this.Ingrediente_p,
            this.Pret_p,
            this.Poza_p});
            this.listView1.ContextMenuStrip = this.contextMenuStrip2;
            this.listView1.ForeColor = System.Drawing.Color.DarkRed;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(356, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 231);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Denumire_p
            // 
            this.Denumire_p.Text = "Denumire";
            this.Denumire_p.Width = 94;
            // 
            // Ingrediente_p
            // 
            this.Ingrediente_p.Text = "Ingrediente";
            this.Ingrediente_p.Width = 258;
            // 
            // Pret_p
            // 
            this.Pret_p.Text = "Pret";
            this.Pret_p.Width = 59;
            // 
            // Poza_p
            // 
            this.Poza_p.Text = "Poza";
            this.Poza_p.Width = 88;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(122, 28);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdaugaPizza
            // 
            this.buttonAdaugaPizza.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonAdaugaPizza.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaPizza.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonAdaugaPizza.Location = new System.Drawing.Point(534, 375);
            this.buttonAdaugaPizza.Name = "buttonAdaugaPizza";
            this.buttonAdaugaPizza.Size = new System.Drawing.Size(154, 67);
            this.buttonAdaugaPizza.TabIndex = 13;
            this.buttonAdaugaPizza.Text = "Adaugati";
            this.buttonAdaugaPizza.UseVisualStyleBackColor = false;
            this.buttonAdaugaPizza.Click += new System.EventHandler(this.buttonAdaugaPizza_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem,
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 37);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(78, 33);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon;
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem});
            this.fisierToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(72, 33);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon;
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon;
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.restaurareToolStripMenuItem.Text = "Restaurare";
            this.restaurareToolStripMenuItem.Click += new System.EventHandler(this.restaurareToolStripMenuItem_Click);
            // 
            // Form_pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(887, 522);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonAdaugaPizza);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxIngred);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.labelPoza);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelIngrediente);
            this.Controls.Add(this.labelDenumire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_pizza";
            this.Text = "Form_pizza";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelIngrediente;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelPoza;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.TextBox textBoxIngred;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Denumire_p;
        private System.Windows.Forms.ColumnHeader Ingrediente_p;
        private System.Windows.Forms.ColumnHeader Pret_p;
        private System.Windows.Forms.ColumnHeader Poza_p;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiatiToolStripMenuItem;
        private System.Windows.Forms.Button buttonAdaugaPizza;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
    }
}