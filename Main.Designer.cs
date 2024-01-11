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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnGray = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnMagenta = new System.Windows.Forms.Button();
            this.btnCyan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnMontrer = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.pnlEssai = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.genererCouleur = new System.Windows.Forms.Button();
            this.pnlOrdinateur = new System.Windows.Forms.Panel();
            this.lblBien = new System.Windows.Forms.Label();
            this.lblMal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBienPlaces = new System.Windows.Forms.Label();
            this.lblMalPlaces = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlEssai.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btnMontrer);
            this.panel1.Controls.Add(this.pnlResult);
            this.panel1.Controls.Add(this.pnlEssai);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnCompare);
            this.panel1.Controls.Add(this.genererCouleur);
            this.panel1.Location = new System.Drawing.Point(78, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 526);
            this.panel1.TabIndex = 15;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(36, 106);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(58, 17);
            this.checkBox.TabIndex = 30;
            this.checkBox.Text = "unique";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn6.Location = new System.Drawing.Point(79, 73);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(20, 20);
            this.btn6.TabIndex = 29;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn4.Location = new System.Drawing.Point(55, 73);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(20, 20);
            this.btn4.TabIndex = 28;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn2.Location = new System.Drawing.Point(32, 73);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(20, 20);
            this.btn2.TabIndex = 27;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnMontrer
            // 
            this.btnMontrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMontrer.Location = new System.Drawing.Point(28, 425);
            this.btnMontrer.Name = "btnMontrer";
            this.btnMontrer.Size = new System.Drawing.Size(75, 23);
            this.btnMontrer.TabIndex = 26;
            this.btnMontrer.Text = "Montrer";
            this.btnMontrer.UseVisualStyleBackColor = false;
            this.btnMontrer.Click += new System.EventHandler(this.btnMontrer_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Location = new System.Drawing.Point(529, 14);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(179, 492);
            this.pnlResult.TabIndex = 25;
            // 
            // pnlEssai
            // 
            this.pnlEssai.Controls.Add(this.lblInformation);
            this.pnlEssai.Controls.Add(this.button1);
            this.pnlEssai.Location = new System.Drawing.Point(123, 15);
            this.pnlEssai.Name = "pnlEssai";
            this.pnlEssai.Size = new System.Drawing.Size(402, 492);
            this.pnlEssai.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-32, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "unique";
            this.button1.UseVisualStyleBackColor = true;
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
            this.panel4.Location = new System.Drawing.Point(18, 143);
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
            this.btnCompare.Text = "Comparer";
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
            this.genererCouleur.Click += new System.EventHandler(this.GenererCouleur_Click);
            // 
            // pnlOrdinateur
            // 
            this.pnlOrdinateur.Location = new System.Drawing.Point(201, 12);
            this.pnlOrdinateur.Name = "pnlOrdinateur";
            this.pnlOrdinateur.Size = new System.Drawing.Size(400, 38);
            this.pnlOrdinateur.TabIndex = 16;
            // 
            // lblBien
            // 
            this.lblBien.AutoSize = true;
            this.lblBien.Location = new System.Drawing.Point(645, 37);
            this.lblBien.Name = "lblBien";
            this.lblBien.Size = new System.Drawing.Size(0, 13);
            this.lblBien.TabIndex = 17;
            // 
            // lblMal
            // 
            this.lblMal.AutoSize = true;
            this.lblMal.Location = new System.Drawing.Point(720, 37);
            this.lblMal.Name = "lblMal";
            this.lblMal.Size = new System.Drawing.Size(0, 13);
            this.lblMal.TabIndex = 18;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.Location = new System.Drawing.Point(94, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 38);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblBienPlaces
            // 
            this.lblBienPlaces.AutoSize = true;
            this.lblBienPlaces.Location = new System.Drawing.Point(627, 12);
            this.lblBienPlaces.Name = "lblBienPlaces";
            this.lblBienPlaces.Size = new System.Drawing.Size(63, 13);
            this.lblBienPlaces.TabIndex = 20;
            this.lblBienPlaces.Text = "Bien Places";
            // 
            // lblMalPlaces
            // 
            this.lblMalPlaces.AutoSize = true;
            this.lblMalPlaces.Location = new System.Drawing.Point(696, 12);
            this.lblMalPlaces.Name = "lblMalPlaces";
            this.lblMalPlaces.Size = new System.Drawing.Size(59, 13);
            this.lblMalPlaces.TabIndex = 21;
            this.lblMalPlaces.Text = "Mal Places";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblInformation.Location = new System.Drawing.Point(13, 202);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(373, 25);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Il faut choisir le taille pour commencer";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(893, 630);
            this.Controls.Add(this.lblMalPlaces);
            this.Controls.Add(this.lblBienPlaces);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMal);
            this.Controls.Add(this.lblBien);
            this.Controls.Add(this.pnlOrdinateur);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEssai.ResumeLayout(false);
            this.pnlEssai.PerformLayout();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Button genererCouleur;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Panel pnlOrdinateur;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBien;
        private System.Windows.Forms.Label lblMal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlEssai;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Label lblBienPlaces;
        private System.Windows.Forms.Label lblMalPlaces;
        private System.Windows.Forms.Button btnMontrer;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label lblInformation;
    }
}

