
///ETML
///Auteur : Mustafa Yildiz
///Date   : jeudi, 23 novembre 2023
///Description : Vous demandez à l’ordinateur de créer n’importe quel nombre de couleurs aléatoires sur 7 couleurs. 
///Vous essayez de deviner leur ordre.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind_Graphique
{
    public partial class Main : Form
    {
        int taille = 0;
        // taille de couleurs
        const int NBR_TAILLE = 4;

        Random random = new Random();
        
        int btnHeight = 23;      
        int startLocationX = 40;
        int startLocationY = 10;

        // Pour comparer les couleurs et changer le couleurs dans même et different index
        Color[] couleursParOrdinateur = new Color[NBR_TAILLE];
        Color[] couleursParUtilisateur = new Color[NBR_TAILLE];

        // Ce tableau concerne les couleurs que l'ordinateur attribuera au hasard.
        Button[] buttons;

        // Ce tableau est pour les couleurs possibles
        Button[] buttonsBase;

        // Pour mettre les couleurs sélectionnées et placer chaque sélection.
        Button[,] buttonsTableau;

        // Ce tableau doit montrer les résultats sélectionnés.
        Button[,] buttonsTableauResult;

        int compteurBienPlace = 0;
        int compteurMalPlace = 0;

        // Pour contrôler les nombres de créer de boutons
        int cmptr = 1;

        // Pour contrôler les nombres de couleurs de choisir
        int compteurColor = 0;

        // Pour contrôler l'essais
        int compteurCompare = 0;
        public Main()
        {
            InitializeComponent();

        // Un tableau de boutons qui montrent à l'utilisateur les couleurs qu'il a sélectionnées.
            buttonsTableau = new Button[10, NBR_TAILLE];

        // Un tableau composé de boutons qui montre à l'utilisateur le résultat de la comparaison.
            buttonsTableauResult = new Button[10, NBR_TAILLE];        

        // Tableau des boutons colorés générés par l'ordinateur.
            buttons = new Button[NBR_TAILLE];          

        // Tableau composé de boutons de couleurs sélectionnables.
            buttonsBase = new Button[7];
            buttonsBase[0] = btnGray;
            buttonsBase[1] = btnYellow;
            buttonsBase[2] = btnWhite;
            buttonsBase[3] = btnRed;
            buttonsBase[4] = btnBlue;
            buttonsBase[5] = btnMagenta;
            buttonsBase[6] = btnCyan;             
        }

        /// <summary>
        /// Generer Les couleurs et après mettre dans les boutons en tableau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenererCouleur_Click(object sender, EventArgs e)
        {   
            GenererCoulerus();

            if (checkBox.Checked == true)
            {
                int[] randomList = new int[NBR_TAILLE];
                int randomNumber = 0;

                for (int i = 0; i < NBR_TAILLE; i++)
                {
                    randomNumber = random.Next(0, 7);
                    if (!randomList.Contains(randomNumber))
                    {
                        randomList[i] = randomNumber;
                    }
                }

                for (int i = 0; i < NBR_TAILLE; i++)
                {
                    buttons[i].BackColor = buttonsBase[randomList[i]].BackColor;
                    couleursParOrdinateur[i] = buttons[i].BackColor;
                    genererCouleur.Enabled = false;
                }

            }
            else
            {
                for (int i = 0; i < NBR_TAILLE; i++)
                {
                    int index = random.Next(buttonsBase.Length);
                    buttonsBase[i] = buttonsBase[index];
                    buttons[i].BackColor = buttonsBase[i].BackColor;
                    couleursParOrdinateur[i] = buttons[i].BackColor;
                    genererCouleur.Enabled = false;
                }
            }
            CreateElements();
            
        }

        void GenererCoulerus() {
            for (int i = 0; i < NBR_TAILLE; i++)
            {
                Button genererButtons = new Button();
                genererButtons.Size = new Size(pnlOrdinateur.Width/(NBR_TAILLE*2), btnHeight);
                genererButtons.Location = new Point(startLocationX + (genererButtons.Width * i), startLocationY);
                genererButtons.Name = "btnColor" + i;           
                buttons[i] = genererButtons;
                pnlOrdinateur.Controls.Add(genererButtons);
            }  
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Il permet de comparer les couleurs de l'ordinateur et les couleurs de l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompare_Click(object sender, EventArgs e)
        {   
            CompareMemeIndex();
            CompareDifferentIndex();
            MontreResultat();
            CreateElements();
            lblBien.Text = Convert.ToString(compteurBienPlace);
            lblMal.Text = Convert.ToString(compteurMalPlace);
            compteurCompare++;
            compteurColor = 0;
            compteurBienPlace = 0;
            compteurMalPlace = 0;

            for (int i = 0; i < NBR_TAILLE; i++)
            {
                couleursParOrdinateur[i] = buttons[i].BackColor;
            }
        }

        /// <summary>
        /// La sélection de couleurs de l'utilisateur est fournie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void choisirCouleur(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (compteurColor < NBR_TAILLE)
            {
                buttonsTableau[compteurCompare, compteurColor].BackColor = clickedButton.BackColor;
                couleursParUtilisateur[compteurColor] = clickedButton.BackColor;             
                compteurColor++;
            }
            else
            {
                MessageBox.Show("Vous avez saisir trop");
            }  
        }

        /// <summary>
        ///Les couleurs de l'ordinateur et de l'utilisateur sont comparées par même index.
        /// </summary>
        void CompareMemeIndex()
        {
            for (int i = 0; i < couleursParOrdinateur.Length; i++)
            {
                if (couleursParOrdinateur[i] == couleursParUtilisateur[i])
                {
                    couleursParOrdinateur[i] = Color.Chocolate;
                    couleursParUtilisateur[i] = Color.Orange;
                    compteurBienPlace++;
                }
            }
        }

        //Les couleurs de l'ordinateur et de l'utilisateur sont comparées par different index.
        /// <summary>
        ///Les couleurs de l'ordinateur et de l'utilisateur sont comparées par different index.
        /// </summary>
        void CompareDifferentIndex()
        {
            for (int i = 0; i < couleursParOrdinateur.Length; i++)
            {
                for (int j = 0; j < couleursParOrdinateur.Length; j++)
                {
                    if ((i != j) && (couleursParOrdinateur[i] == couleursParUtilisateur[j]))
                    {
                        couleursParOrdinateur[i] = Color.Aqua;
                        couleursParUtilisateur[j] = Color.Azure;
                        compteurMalPlace++;
                        break;
                    }
                }
            }
        }

        /// <summary>
        ///Après évaluation, le résultat est affiché sur la console.
        /// </summary>
        void MontreResultat()
        {
            for (int i = 0; i <= NBR_TAILLE; i++)
            {                           
                if (compteurBienPlace != 0)
                {
                    for (int j = 0; j < compteurBienPlace; j++)
                    {
                        buttonsTableauResult[compteurCompare, j].BackColor = Color.White;
                    }                
                }
                if (compteurMalPlace != 0)
                {
                    for (int k = 0; k < compteurMalPlace; k++)
                    {
                        buttonsTableauResult[compteurCompare, NBR_TAILLE - 1 - k].BackColor = Color.Black; 
                    }
                                     
                }                  
            }
            if (compteurBienPlace == couleursParOrdinateur.Length) 
            {
                pnlOrdinateur.Visible = true;
                MessageBox.Show( $"Vous avez gagné :) Vous avez trouvé nombre d'essai {compteurCompare+1}" );
                Reset();

            }
            if (cmptr == 11 & compteurBienPlace != couleursParOrdinateur.Length )
            {
                pnlOrdinateur.Visible = true;
                MessageBox.Show( $"Vous avez perdu Vous avez essai {compteurCompare+1} fois" );
                Reset();
            }
        }

        /// <summary>
        /// Réinitialise les couleurs des boutons et des compteurs
        /// </summary>
        void Reset()
        {
            for (int i = 0; i < compteurCompare; i++)
            {
                for (int j = 0; j < NBR_TAILLE; j++)
                {                  
                    buttonsTableau[i, j].BackColor = Color.FromArgb(224, 224, 224);
                    buttonsTableauResult[i, j].BackColor = Color.FromArgb(224, 224, 224);
                    buttons[j].BackColor = Color.FromArgb(224, 224, 224);                     
                }
            }
            genererCouleur.Enabled = true;
            compteurCompare = 0;
            cmptr = 1;
            startLocationX = 40;
            startLocationY = 10;
            lblBien.Text = "";
            lblMal.Text = "";
            pnlEssai.Controls.Clear();
            pnlOrdinateur.Controls.Clear();
            pnlResult.Controls.Clear();
        }

        /// <summary>
        /// Il permet la réinitialisation en appelant la fonction reset.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// il permet le creation des boutons pour choisir couleurs et montrer le resultat
        /// </summary>
        void CreateElements()
        {
            
            Label label = new Label();
            label.Location = new Point(startLocationX-20, startLocationY+5);
            label.Name = "nbrEssai";
            label.Text = Convert.ToString(cmptr);
            label.Size = new Size(20, 20);
            pnlEssai.Controls.Add(label);
        
            for (int i = 0; i < NBR_TAILLE; i++)
            { 
                Button newBtnEssai = new Button();
                newBtnEssai.Size = new Size(pnlEssai.Width/(NBR_TAILLE*2), btnHeight);
                newBtnEssai.Location = new Point(startLocationX + (newBtnEssai.Width * i), startLocationY);
                newBtnEssai.Name = "btn" + i + 1;       
                pnlEssai.Controls.Add(newBtnEssai);

                buttonsTableau[cmptr - 1, i] = newBtnEssai;
            }
  
            for (int i = 0; i < NBR_TAILLE; i++)
            {  
                Button newBtnResultat = new Button();              
                newBtnResultat.Location = new Point(10 +(i*20), startLocationY);
                newBtnResultat.Name = "btnResult" + i + 1;              
                newBtnResultat.Size = new Size(20, 20);
                pnlResult.Controls.Add(newBtnResultat); 

                buttonsTableauResult[cmptr - 1, i] = newBtnResultat;
            }
            startLocationY += 40;
            cmptr++;
        }

        private void btnMontrer_Click(object sender, EventArgs e)
        {
            pnlOrdinateur.Visible = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            taille = Convert.ToInt16(btn2.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            taille = Convert.ToInt16(btn4.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            taille = Convert.ToInt16(btn6.Text);
        }

        int DeciderTaille(object sender, EventArgs e) {
            int taille;
            Button btnTaille = (Button)sender;
            taille = Convert.ToInt32(btnTaille.Text);
            return taille;
        }
    }
}
