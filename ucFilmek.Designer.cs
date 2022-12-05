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
      this.cbCim = new System.Windows.Forms.ComboBox();
      this.cbEV = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // cbCim
      // 
      this.cbCim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbCim.FormattingEnabled = true;
      this.cbCim.Location = new System.Drawing.Point(34, 33);
      this.cbCim.Name = "cbCim";
      this.cbCim.Size = new System.Drawing.Size(431, 33);
      this.cbCim.TabIndex = 0;
      // 
      // cbEV
      // 
      this.cbEV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEV.FormattingEnabled = true;
      this.cbEV.Location = new System.Drawing.Point(34, 98);
      this.cbEV.Name = "cbEV";
      this.cbEV.Size = new System.Drawing.Size(431, 33);
      this.cbEV.TabIndex = 1;
      // 
      // ucFilmek
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.cbEV);
      this.Controls.Add(this.cbCim);
      this.Name = "ucFilmek";
      this.Size = new System.Drawing.Size(504, 340);
      this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbCim;
        private ComboBox cbEV;
    }
}
