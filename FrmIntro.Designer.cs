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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntro));
            this.btnDemarrager = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.pnlinfo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDemarrager
            // 
            this.btnDemarrager.Location = new System.Drawing.Point(535, 51);
            this.btnDemarrager.Name = "btnDemarrager";
            this.btnDemarrager.Size = new System.Drawing.Size(233, 23);
            this.btnDemarrager.TabIndex = 0;
            this.btnDemarrager.Text = "Demarrer le jeux";
            this.btnDemarrager.UseVisualStyleBackColor = true;
            this.btnDemarrager.Click += new System.EventHandler(this.btnDemarrager_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(217, 51);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(235, 23);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblBienvenue.Location = new System.Drawing.Point(311, 9);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(393, 39);
            this.lblBienvenue.TabIndex = 2;
            this.lblBienvenue.Text = "Bienvenue à MasterMind";
            // 
            // pnlinfo
            // 
            this.pnlinfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlinfo.BackgroundImage")));
            this.pnlinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlinfo.Location = new System.Drawing.Point(0, 80);
            this.pnlinfo.Name = "pnlinfo";
            this.pnlinfo.Size = new System.Drawing.Size(977, 646);
            this.pnlinfo.TabIndex = 4;
            // 
            // FrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 726);
            this.Controls.Add(this.pnlinfo);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnDemarrager);
            this.IsMdiContainer = true;
            this.Name = "FrmIntro";
            this.Text = "Bienvenue";
            this.Load += new System.EventHandler(this.FrmIntro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDemarrager;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlinfo;
    }
}