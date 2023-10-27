namespace SortifyBot_UI.Forms
{
    partial class FormSettings
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
            this.btnChooseS = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnChooseS
            // 
            this.btnChooseS.BackColor = System.Drawing.Color.Indigo;
            this.btnChooseS.FlatAppearance.BorderSize = 0;
            this.btnChooseS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseS.ForeColor = System.Drawing.Color.White;
            this.btnChooseS.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChooseS.IconColor = System.Drawing.Color.Black;
            this.btnChooseS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChooseS.Location = new System.Drawing.Point(70, 65);
            this.btnChooseS.Name = "btnChooseS";
            this.btnChooseS.Size = new System.Drawing.Size(218, 43);
            this.btnChooseS.TabIndex = 26;
            this.btnChooseS.Text = "CHOOSE SIMULATOR";
            this.btnChooseS.UseVisualStyleBackColor = false;
            this.btnChooseS.Click += new System.EventHandler(this.btnChooseS_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1313, 762);
            this.Controls.Add(this.btnChooseS);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnChooseS;
    }
}