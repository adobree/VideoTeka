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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmekToolStripMenuItem
            // 
            this.filmekToolStripMenuItem.Name = "filmekToolStripMenuItem";
            this.filmekToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.filmekToolStripMenuItem.Text = "Filmek";
            this.filmekToolStripMenuItem.Click += new System.EventHandler(this.filmekToolStripMenuItem_Click);
            // 
            // felhasználókToolStripMenuItem
            // 
            this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
            this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.felhasználókToolStripMenuItem.Text = "Felhasználók";
            this.felhasználókToolStripMenuItem.Click += new System.EventHandler(this.felhasználókToolStripMenuItem_Click);
            // 
            // raktárToolStripMenuItem
            // 
            this.raktárToolStripMenuItem.Name = "raktárToolStripMenuItem";
            this.raktárToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.raktárToolStripMenuItem.Text = "Raktár";
            this.raktárToolStripMenuItem.Click += new System.EventHandler(this.raktárToolStripMenuItem_Click);
            // 
            // kIBEToolStripMenuItem
            // 
            this.kIBEToolStripMenuItem.Name = "kIBEToolStripMenuItem";
            this.kIBEToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.kIBEToolStripMenuItem.Text = "KI/BE";
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 22);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(420, 234);
            this.dgv.TabIndex = 1;
            this.dgv.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}