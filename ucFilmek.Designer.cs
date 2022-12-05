namespace VT
{
    partial class ucFilmek
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
      this.cbFilmek = new System.Windows.Forms.ComboBox();
      this.btUj = new System.Windows.Forms.Button();
      this.btMent = new System.Windows.Forms.Button();
      this.btMegse = new System.Windows.Forms.Button();
      this.tbCim = new System.Windows.Forms.TextBox();
      this.tbEv = new System.Windows.Forms.TextBox();
      this.btTorles = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cbFilmek
      // 
      this.cbFilmek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbFilmek.FormattingEnabled = true;
      this.cbFilmek.Location = new System.Drawing.Point(34, 35);
      this.cbFilmek.Name = "cbFilmek";
      this.cbFilmek.Size = new System.Drawing.Size(458, 33);
      this.cbFilmek.TabIndex = 0;
      this.cbFilmek.SelectedIndexChanged += new System.EventHandler(this.cbFilmek_SelectedIndexChanged);
      // 
      // btUj
      // 
      this.btUj.Location = new System.Drawing.Point(26, 281);
      this.btUj.Name = "btUj";
      this.btUj.Size = new System.Drawing.Size(112, 34);
      this.btUj.TabIndex = 2;
      this.btUj.Text = "Uj";
      this.btUj.UseVisualStyleBackColor = true;
      this.btUj.Click += new System.EventHandler(this.btUj_Click);
      // 
      // btMent
      // 
      this.btMent.Location = new System.Drawing.Point(144, 281);
      this.btMent.Name = "btMent";
      this.btMent.Size = new System.Drawing.Size(112, 34);
      this.btMent.TabIndex = 3;
      this.btMent.Text = "Mentes";
      this.btMent.UseVisualStyleBackColor = true;
      this.btMent.Click += new System.EventHandler(this.btMent_Click);
      // 
      // btMegse
      // 
      this.btMegse.Location = new System.Drawing.Point(262, 281);
      this.btMegse.Name = "btMegse";
      this.btMegse.Size = new System.Drawing.Size(112, 34);
      this.btMegse.TabIndex = 4;
      this.btMegse.Text = "Megse";
      this.btMegse.UseVisualStyleBackColor = true;
      this.btMegse.Click += new System.EventHandler(this.btMegse_Click);
      // 
      // tbCim
      // 
      this.tbCim.Location = new System.Drawing.Point(34, 100);
      this.tbCim.Name = "tbCim";
      this.tbCim.Size = new System.Drawing.Size(458, 31);
      this.tbCim.TabIndex = 5;
      // 
      // tbEv
      // 
      this.tbEv.Location = new System.Drawing.Point(34, 155);
      this.tbEv.Name = "tbEv";
      this.tbEv.Size = new System.Drawing.Size(458, 31);
      this.tbEv.TabIndex = 6;
      // 
      // btTorles
      // 
      this.btTorles.Location = new System.Drawing.Point(380, 281);
      this.btTorles.Name = "btTorles";
      this.btTorles.Size = new System.Drawing.Size(112, 34);
      this.btTorles.TabIndex = 7;
      this.btTorles.Text = "Torles";
      this.btTorles.UseVisualStyleBackColor = true;
      this.btTorles.Click += new System.EventHandler(this.btTorles_Click);
      // 
      // ucFilmek
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btTorles);
      this.Controls.Add(this.tbEv);
      this.Controls.Add(this.tbCim);
      this.Controls.Add(this.btMegse);
      this.Controls.Add(this.btMent);
      this.Controls.Add(this.btUj);
      this.Controls.Add(this.cbFilmek);
      this.Name = "ucFilmek";
      this.Size = new System.Drawing.Size(519, 352);
      this.VisibleChanged += new System.EventHandler(this.ucFilmek_VisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private ComboBox cbFilmek;
        private Button btUj;
        private Button btMent;
        private Button btMegse;
        private TextBox tbCim;
        private TextBox tbEv;
        private Button btTorles;
    }
}
