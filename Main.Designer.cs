namespace MasterMind_Graphique
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGray = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnMagenta = new System.Windows.Forms.Button();
            this.btnCyan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEssai = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.genererCouleur = new System.Windows.Forms.Button();
            this.btnColor4 = new System.Windows.Forms.Button();
            this.btnColor3 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBien = new System.Windows.Forms.Label();
            this.lblMal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.Color.Gray;
            this.btnGray.Location = new System.Drawing.Point(12, 16);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 0;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.choisirCouleur);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(12, 45);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 23);
            this.btnYellow.TabIndex = 1;
            this.btnYellow.Text = "Jaune";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.choisirCouleur);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(12, 74);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(75, 23);
            this.btnWhite.TabIndex = 2;
            this.btnWhite.Text = "Blanc";
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.choisirCouleur);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(12, 103);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 3;
            this.btnRed.Text = "Rouge";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.choisirCouleur);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlue.Location = new System.Drawing.Point(12, 132);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 4;
            this.btnBlue.Text = "Bleu";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.choisirCouleur);
            // 
            // btnMagenta
            // 
            this.btnMagenta.BackColor = System.Drawing.Color.Magenta;
            this.btnMagenta.Location = new System.Drawing.Point(12, 161);
            this.btnMagenta.Name = "btnMagenta";
            this.btnMagenta.Size = new System.Drawing.Size(75, 23);
            this.btnMagenta.TabIndex = 5;
            this.btnMagenta.Text = "Magenta";
            this.btnMagenta.UseVisualStyleBackColor = false;
            this.btnMagenta.Click += new System.EventHandler(this.choisirCouleur);
            // 
            // btnCyan
            // 
            this.btnCyan.BackColor = System.Drawing.Color.Cyan;
            this.btnCyan.Location = new System.Drawing.Point(12, 190);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(75, 23);
            this.btnCyan.TabIndex = 6;
            this.btnCyan.Text = "Cyan";
            this.btnCyan.UseVisualStyleBackColor = false;
            this.btnCyan.Click += new System.EventHandler(this.choisirCouleur);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pnlEssai);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnCompare);
            this.panel1.Controls.Add(this.genererCouleur);
            this.panel1.Location = new System.Drawing.Point(78, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 526);
            this.panel1.TabIndex = 15;
            // 
            // pnlEssai
            // 
            this.pnlEssai.Location = new System.Drawing.Point(121, 14);
            this.pnlEssai.Name = "pnlEssai";
            this.pnlEssai.Size = new System.Drawing.Size(472, 492);
            this.pnlEssai.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMagenta);
            this.panel4.Controls.Add(this.btnCyan);
            this.panel4.Controls.Add(this.btnBlue);
            this.panel4.Controls.Add(this.btnRed);
            this.panel4.Controls.Add(this.btnWhite);
            this.panel4.Controls.Add(this.btnGray);
            this.panel4.Controls.Add(this.btnYellow);
            this.panel4.Location = new System.Drawing.Point(16, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(99, 231);
            this.panel4.TabIndex = 23;
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.Green;
            this.btnCompare.Location = new System.Drawing.Point(28, 472);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 34);
            this.btnCompare.TabIndex = 21;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // genererCouleur
            // 
            this.genererCouleur.BackColor = System.Drawing.Color.LightSkyBlue;
            this.genererCouleur.Location = new System.Drawing.Point(16, 17);
            this.genererCouleur.Name = "genererCouleur";
            this.genererCouleur.Size = new System.Drawing.Size(99, 54);
            this.genererCouleur.TabIndex = 20;
            this.genererCouleur.Text = "Generer Couleurs";
            this.genererCouleur.UseVisualStyleBackColor = false;
            this.genererCouleur.Click += new System.EventHandler(this.genererCouleur_Click);
            // 
            // btnColor4
            // 
            this.btnColor4.Location = new System.Drawing.Point(243, 4);
            this.btnColor4.Name = "btnColor4";
            this.btnColor4.Size = new System.Drawing.Size(75, 23);
            this.btnColor4.TabIndex = 19;
            this.btnColor4.UseVisualStyleBackColor = true;
            // 
            // btnColor3
            // 
            this.btnColor3.Location = new System.Drawing.Point(162, 4);
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.Size = new System.Drawing.Size(75, 23);
            this.btnColor3.TabIndex = 18;
            this.btnColor3.UseVisualStyleBackColor = true;
            // 
            // btnColor2
            // 
            this.btnColor2.Location = new System.Drawing.Point(81, 4);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(75, 23);
            this.btnColor2.TabIndex = 17;
            this.btnColor2.UseVisualStyleBackColor = true;
            // 
            // btnColor1
            // 
            this.btnColor1.Location = new System.Drawing.Point(0, 4);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(75, 23);
            this.btnColor1.TabIndex = 16;
            this.btnColor1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnColor1);
            this.panel2.Controls.Add(this.btnColor2);
            this.panel2.Controls.Add(this.btnColor3);
            this.panel2.Controls.Add(this.btnColor4);
            this.panel2.Location = new System.Drawing.Point(241, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 38);
            this.panel2.TabIndex = 16;
            // 
            // lblBien
            // 
            this.lblBien.AutoSize = true;
            this.lblBien.Location = new System.Drawing.Point(575, 21);
            this.lblBien.Name = "lblBien";
            this.lblBien.Size = new System.Drawing.Size(27, 13);
            this.lblBien.TabIndex = 17;
            this.lblBien.Text = "bien";
            // 
            // lblMal
            // 
            this.lblMal.AutoSize = true;
            this.lblMal.Location = new System.Drawing.Point(604, 21);
            this.lblMal.Name = "lblMal";
            this.lblMal.Size = new System.Drawing.Size(23, 13);
            this.lblMal.TabIndex = 18;
            this.lblMal.Text = "mal";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.Location = new System.Drawing.Point(96, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 38);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(706, 630);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMal);
            this.Controls.Add(this.lblBien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnMagenta;
        private System.Windows.Forms.Button btnCyan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColor4;
        private System.Windows.Forms.Button btnColor3;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button genererCouleur;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBien;
        private System.Windows.Forms.Label lblMal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlEssai;
    }
}

