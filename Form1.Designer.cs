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
      ((System.ComponentModel.ISupportInitialize)(this.dsVT)).BeginInit();
      this.menuStrip1.SuspendLayout();
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
      this.menuStrip1.Size = new System.Drawing.Size(800, 33);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // filmekToolStripMenuItem
      // 
      this.filmekToolStripMenuItem.Name = "filmekToolStripMenuItem";
      this.filmekToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
      this.filmekToolStripMenuItem.Text = "Filmek";
      // 
      // felhasználókToolStripMenuItem
      // 
      this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
      this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
      this.felhasználókToolStripMenuItem.Text = "Felhasználók";
      // 
      // raktárToolStripMenuItem
      // 
      this.raktárToolStripMenuItem.Name = "raktárToolStripMenuItem";
      this.raktárToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
      this.raktárToolStripMenuItem.Text = "Raktár";
      // 
      // kIBEToolStripMenuItem
      // 
      this.kIBEToolStripMenuItem.Name = "kIBEToolStripMenuItem";
      this.kIBEToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
      this.kIBEToolStripMenuItem.Text = "KI/BE";
      // 
      // mentésToolStripMenuItem
      // 
      this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
      this.mentésToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
      this.mentésToolStripMenuItem.Text = "Mentés";
      // 
      // kilépésToolStripMenuItem
      // 
      this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
      this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
      this.kilépésToolStripMenuItem.Text = "Kilépés";
      this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dsVT)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
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
    }
}