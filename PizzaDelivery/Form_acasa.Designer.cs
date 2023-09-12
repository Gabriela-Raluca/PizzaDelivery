namespace PizzaDelivery
{
    partial class Form_acasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_acasa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaliiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adreseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.închidețiAplicațiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuStrip1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaToolStripMenuItem,
            this.detaliiToolStripMenuItem,
            this.statisticiToolStripMenuItem,
            this.închidețiAplicațiaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(93, 41);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            this.pizzaToolStripMenuItem.Click += new System.EventHandler(this.pizzaToolStripMenuItem_Click);
            // 
            // detaliiToolStripMenuItem
            // 
            this.detaliiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiiToolStripMenuItem,
            this.adreseToolStripMenuItem});
            this.detaliiToolStripMenuItem.Name = "detaliiToolStripMenuItem";
            this.detaliiToolStripMenuItem.Size = new System.Drawing.Size(106, 41);
            this.detaliiToolStripMenuItem.Text = "Detalii";
            this.detaliiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // clientiiToolStripMenuItem
            // 
            this.clientiiToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon;
            this.clientiiToolStripMenuItem.Name = "clientiiToolStripMenuItem";
            this.clientiiToolStripMenuItem.Size = new System.Drawing.Size(224, 42);
            this.clientiiToolStripMenuItem.Text = "Clienti";
            this.clientiiToolStripMenuItem.Click += new System.EventHandler(this.clientiiToolStripMenuItem_Click);
            // 
            // adreseToolStripMenuItem
            // 
            this.adreseToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon;
            this.adreseToolStripMenuItem.Name = "adreseToolStripMenuItem";
            this.adreseToolStripMenuItem.Size = new System.Drawing.Size(224, 42);
            this.adreseToolStripMenuItem.Text = "Adrese";
            // 
            // statisticiToolStripMenuItem
            // 
            this.statisticiToolStripMenuItem.Name = "statisticiToolStripMenuItem";
            this.statisticiToolStripMenuItem.Size = new System.Drawing.Size(129, 41);
            this.statisticiToolStripMenuItem.Text = "Statistici";
            this.statisticiToolStripMenuItem.Click += new System.EventHandler(this.statisticiToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PizzaDelivery.Properties.Resources.Pizza_Time;
            this.pictureBox1.Location = new System.Drawing.Point(0, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // închidețiAplicațiaToolStripMenuItem
            // 
            this.închidețiAplicațiaToolStripMenuItem.Name = "închidețiAplicațiaToolStripMenuItem";
            this.închidețiAplicațiaToolStripMenuItem.Size = new System.Drawing.Size(226, 41);
            this.închidețiAplicațiaToolStripMenuItem.Text = "Închideti aplicatia";
            this.închidețiAplicațiaToolStripMenuItem.Click += new System.EventHandler(this.închidețiAplicațiaToolStripMenuItem_Click);
            // 
            // Form_acasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 604);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_acasa";
            this.Text = "Acasa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaliiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem clientiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adreseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem închidețiAplicațiaToolStripMenuItem;
    }
}

