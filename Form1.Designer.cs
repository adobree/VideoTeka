namespace VT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.dsVT = new VT.dsVT();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.filmekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.felhasználókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.raktárToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.kIBEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dgv = new System.Windows.Forms.DataGridView();
      this.ucKolcsonzes = new VT.ucKolcsonzes();
      this.ucFilmek = new VT.ucFilmek();
      this.ucFelhaszn = new VT.ucFelhaszn();
      ((System.ComponentModel.ISupportInitialize)(this.dsVT)).BeginInit();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // dsVT
      // 
      this.dsVT.DataSetName = "dsVT";
      this.dsVT.Namespace = "http://tempuri.org/dsVT.xsd";
      this.dsVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmekToolStripMenuItem,
            this.felhasználókToolStripMenuItem,
            this.raktárToolStripMenuItem,
            this.kIBEToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1239, 33);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // filmekToolStripMenuItem
      // 
      this.filmekToolStripMenuItem.Name = "filmekToolStripMenuItem";
      this.filmekToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
      this.filmekToolStripMenuItem.Text = "Filmek";
      this.filmekToolStripMenuItem.Click += new System.EventHandler(this.filmekToolStripMenuItem_Click);
      // 
      // felhasználókToolStripMenuItem
      // 
      this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
      this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
      this.felhasználókToolStripMenuItem.Text = "Felhasználók";
      this.felhasználókToolStripMenuItem.Click += new System.EventHandler(this.felhasználókToolStripMenuItem_Click);
      // 
      // raktárToolStripMenuItem
      // 
      this.raktárToolStripMenuItem.Name = "raktárToolStripMenuItem";
      this.raktárToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
      this.raktárToolStripMenuItem.Text = "Raktár";
      this.raktárToolStripMenuItem.Click += new System.EventHandler(this.raktárToolStripMenuItem_Click);
      // 
      // kIBEToolStripMenuItem
      // 
      this.kIBEToolStripMenuItem.Name = "kIBEToolStripMenuItem";
      this.kIBEToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
      this.kIBEToolStripMenuItem.Text = "KI/BE";
      this.kIBEToolStripMenuItem.Click += new System.EventHandler(this.kIBEToolStripMenuItem_Click);
      // 
      // mentésToolStripMenuItem
      // 
      this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
      this.mentésToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
      this.mentésToolStripMenuItem.Text = "Mentés";
      this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
      // 
      // kilépésToolStripMenuItem
      // 
      this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
      this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
      this.kilépésToolStripMenuItem.Text = "Kilépés";
      this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
      // 
      // dgv
      // 
      this.dgv.AllowUserToAddRows = false;
      this.dgv.AllowUserToDeleteRows = false;
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Location = new System.Drawing.Point(17, 37);
      this.dgv.Name = "dgv";
      this.dgv.ReadOnly = true;
      this.dgv.RowHeadersWidth = 62;
      this.dgv.RowTemplate.Height = 33;
      this.dgv.Size = new System.Drawing.Size(688, 583);
      this.dgv.TabIndex = 1;
      this.dgv.Visible = false;
      // 
      // ucKolcsonzes
      // 
      this.ucKolcsonzes.dsVT = null;
      this.ucKolcsonzes.Location = new System.Drawing.Point(17, 37);
      this.ucKolcsonzes.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.ucKolcsonzes.Name = "ucKolcsonzes";
      this.ucKolcsonzes.Size = new System.Drawing.Size(670, 457);
      this.ucKolcsonzes.TabIndex = 2;
      this.ucKolcsonzes.Visible = false;
      this.ucKolcsonzes.Load += new System.EventHandler(this.ucFilm_Load);
      // 
      // ucFilmek
      // 
      this.ucFilmek.dsVT = null;
      this.ucFilmek.Location = new System.Drawing.Point(711, 37);
      this.ucFilmek.Name = "ucFilmek";
      this.ucFilmek.Size = new System.Drawing.Size(778, 528);
      this.ucFilmek.TabIndex = 3;
      this.ucFilmek.Visible = false;
      // 
      // ucFelhaszn
      // 
      this.ucFelhaszn.dsVT = null;
      this.ucFelhaszn.Location = new System.Drawing.Point(712, 36);
      this.ucFelhaszn.Name = "ucFelhaszn";
      this.ucFelhaszn.Size = new System.Drawing.Size(550, 554);
      this.ucFelhaszn.TabIndex = 4;
      this.ucFelhaszn.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1239, 632);
      this.Controls.Add(this.ucFelhaszn);
      this.Controls.Add(this.ucFilmek);
      this.Controls.Add(this.ucKolcsonzes);
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dsVT)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private dsVT dsVT;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filmekToolStripMenuItem;
        private ToolStripMenuItem felhasználókToolStripMenuItem;
        private ToolStripMenuItem raktárToolStripMenuItem;
        private ToolStripMenuItem kIBEToolStripMenuItem;
        private ToolStripMenuItem mentésToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
        private DataGridView dgv;
        private ucKolcsonzes ucKolcsonzes;
        private ucFilmek ucFilmek;
        private ucFelhaszn ucFelhaszn;
    }
}