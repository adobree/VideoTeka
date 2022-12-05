namespace VT
{
    partial class ucFilm
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
            this.cbFilm = new System.Windows.Forms.ComboBox();
            this.btKölcsönöz = new System.Windows.Forms.Button();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.btVisszahoz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFilm
            // 
            this.cbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilm.FormattingEnabled = true;
            this.cbFilm.Location = new System.Drawing.Point(24, 15);
            this.cbFilm.Name = "cbFilm";
            this.cbFilm.Size = new System.Drawing.Size(341, 23);
            this.cbFilm.TabIndex = 0;
            this.cbFilm.SelectedIndexChanged += new System.EventHandler(this.cbFilm_SelectedIndexChanged);
            // 
            // btKölcsönöz
            // 
            this.btKölcsönöz.Location = new System.Drawing.Point(290, 73);
            this.btKölcsönöz.Name = "btKölcsönöz";
            this.btKölcsönöz.Size = new System.Drawing.Size(75, 23);
            this.btKölcsönöz.TabIndex = 2;
            this.btKölcsönöz.Text = "Kölcsönöz";
            this.btKölcsönöz.UseVisualStyleBackColor = true;
            this.btKölcsönöz.Click += new System.EventHandler(this.btKölcsönöz_Click);
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(24, 44);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(341, 23);
            this.cbUser.TabIndex = 3;
            // 
            // btVisszahoz
            // 
            this.btVisszahoz.Location = new System.Drawing.Point(24, 73);
            this.btVisszahoz.Name = "btVisszahoz";
            this.btVisszahoz.Size = new System.Drawing.Size(75, 23);
            this.btVisszahoz.TabIndex = 4;
            this.btVisszahoz.Text = "Visszahoz";
            this.btVisszahoz.UseVisualStyleBackColor = true;
            this.btVisszahoz.Click += new System.EventHandler(this.btVisszahoz_Click);
            // 
            // ucFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btVisszahoz);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.btKölcsönöz);
            this.Controls.Add(this.cbFilm);
            this.Name = "ucFilm";
            this.Size = new System.Drawing.Size(469, 274);
            this.VisibleChanged += new System.EventHandler(this.ucFilm_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbFilm;
        private Button btKölcsönöz;
        private ComboBox cbUser;
        private Button btVisszahoz;
    }
}
