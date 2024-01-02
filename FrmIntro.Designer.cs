namespace MasterMind_Graphique
{
    partial class FrmIntro
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
            this.btnDemarrager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemarrager
            // 
            this.btnDemarrager.Location = new System.Drawing.Point(470, 335);
            this.btnDemarrager.Name = "btnDemarrager";
            this.btnDemarrager.Size = new System.Drawing.Size(233, 23);
            this.btnDemarrager.TabIndex = 0;
            this.btnDemarrager.Text = "Demarrer le jeux";
            this.btnDemarrager.UseVisualStyleBackColor = true;
            this.btnDemarrager.Click += new System.EventHandler(this.btnDemarrager_Click);
            // 
            // FrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDemarrager);
            this.Name = "FrmIntro";
            this.Text = "Bienvenue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemarrager;
    }
}