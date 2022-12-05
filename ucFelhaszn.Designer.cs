namespace VT
{
    partial class ucFelhaszn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.cbFelhasznalok = new System.Windows.Forms.ComboBox();
      this.tbNev = new System.Windows.Forms.TextBox();
      this.tbEmail = new System.Windows.Forms.TextBox();
      this.btUj = new System.Windows.Forms.Button();
      this.btMent = new System.Windows.Forms.Button();
      this.btMegse = new System.Windows.Forms.Button();
      this.btTorol = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cbFelhasznalok
      // 
      this.cbFelhasznalok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbFelhasznalok.FormattingEnabled = true;
      this.cbFelhasznalok.Location = new System.Drawing.Point(23, 27);
      this.cbFelhasznalok.Name = "cbFelhasznalok";
      this.cbFelhasznalok.Size = new System.Drawing.Size(466, 33);
      this.cbFelhasznalok.TabIndex = 0;
      this.cbFelhasznalok.SelectedIndexChanged += new System.EventHandler(this.cbFelhasznalok_SelectedIndexChanged);
      // 
      // tbNev
      // 
      this.tbNev.Location = new System.Drawing.Point(23, 83);
      this.tbNev.Name = "tbNev";
      this.tbNev.Size = new System.Drawing.Size(466, 31);
      this.tbNev.TabIndex = 1;
      // 
      // tbEmail
      // 
      this.tbEmail.Location = new System.Drawing.Point(23, 137);
      this.tbEmail.Name = "tbEmail";
      this.tbEmail.Size = new System.Drawing.Size(466, 31);
      this.tbEmail.TabIndex = 2;
      // 
      // btUj
      // 
      this.btUj.Location = new System.Drawing.Point(23, 327);
      this.btUj.Name = "btUj";
      this.btUj.Size = new System.Drawing.Size(112, 34);
      this.btUj.TabIndex = 3;
      this.btUj.Text = "Uj";
      this.btUj.UseVisualStyleBackColor = true;
      this.btUj.Click += new System.EventHandler(this.btUj_Click);
      // 
      // btMent
      // 
      this.btMent.Location = new System.Drawing.Point(141, 327);
      this.btMent.Name = "btMent";
      this.btMent.Size = new System.Drawing.Size(112, 34);
      this.btMent.TabIndex = 4;
      this.btMent.Text = "Mentes";
      this.btMent.UseVisualStyleBackColor = true;
      this.btMent.Click += new System.EventHandler(this.btMent_Click);
      // 
      // btMegse
      // 
      this.btMegse.Location = new System.Drawing.Point(259, 327);
      this.btMegse.Name = "btMegse";
      this.btMegse.Size = new System.Drawing.Size(112, 34);
      this.btMegse.TabIndex = 5;
      this.btMegse.Text = "Megse";
      this.btMegse.UseVisualStyleBackColor = true;
      this.btMegse.Click += new System.EventHandler(this.btMegse_Click);
      // 
      // btTorol
      // 
      this.btTorol.Location = new System.Drawing.Point(377, 327);
      this.btTorol.Name = "btTorol";
      this.btTorol.Size = new System.Drawing.Size(112, 34);
      this.btTorol.TabIndex = 6;
      this.btTorol.Text = "Torol";
      this.btTorol.UseVisualStyleBackColor = true;
      this.btTorol.Click += new System.EventHandler(this.btTorol_Click);
      // 
      // ucFelhaszn
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btTorol);
      this.Controls.Add(this.btMegse);
      this.Controls.Add(this.btMent);
      this.Controls.Add(this.btUj);
      this.Controls.Add(this.tbEmail);
      this.Controls.Add(this.tbNev);
      this.Controls.Add(this.cbFelhasznalok);
      this.Name = "ucFelhaszn";
      this.Size = new System.Drawing.Size(510, 403);
      this.VisibleChanged += new System.EventHandler(this.ucFelhaszn_VisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private ComboBox cbFelhasznalok;
        private TextBox tbNev;
        private TextBox tbEmail;
        private Button btUj;
        private Button btMent;
        private Button btMegse;
        private Button btTorol;
    }
}
