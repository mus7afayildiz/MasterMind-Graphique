
///ETML
///Auteur : Mustafa Yildiz
///Date   : 27.10.2023
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
        const int NBR_TAILLE = 4;
        static Random random = new Random();

        int cmptr = 1;
        int btnWidth = 75;
        int btnHeight = 23;
        int margin = 5;
        int startLocationX = 35;
        int startLocationY = 10;

        Color[] couleursParOrdinateur = new Color[NBR_TAILLE];
        Color[] couleursParUtilisateur = new Color[NBR_TAILLE];

        Button[,] b;
        Button[] buttons;
        Button[] buttonsUtilisateur;
        Button[] buttonsBase;
        Button[] buttonsResult;
        Button[,] buttonsTableau;
        Button[,] buttonsTableauResult;

        int compteurBienPlace = 0;
        int compteurMalPlace = 0;
        int compteurColor = 0;
        int compteurCompare = 0;
        public Main()
        {
            InitializeComponent();

            b = new Button[1, 5];

            buttonsTableau = new Button[10, 4];
            /*
            {
            {btn00, btn01, btn02, btn03 },
            {btn10, btn11, btn12, btn13 },
            {btn20, btn21, btn22, btn23 },
            {btn30, btn31, btn32, btn33 },
            {btn40, btn41, btn42, btn43 },
            {btn50, btn51, btn52, btn53 },
            {btn60, btn61, btn62, btn63 },
            {btn70, btn71, btn72, btn73 },
            {btn80, btn81, btn82, btn83 },
            {btn90, btn91, btn92, btn93 },
            };     */

            buttonsTableauResult = new Button[,]
            {
            {rslt00, rslt01, rslt02, rslt03 },
            {rslt10, rslt11, rslt12, rslt13 },
            {rslt20, rslt21, rslt22, rslt23 },
            {rslt30, rslt31, rslt32, rslt33 },
            {rslt40, rslt41, rslt42, rslt43 },
            {rslt50, rslt51, rslt52, rslt53 },
            {rslt60, rslt61, rslt62, rslt63 },
            {rslt70, rslt71, rslt72, rslt73 },
            {rslt80, rslt81, rslt82, rslt83 },
            {rslt90, rslt91, rslt92, rslt93 },
            };

            // Tableau des boutons colorés générés par l'ordinateur.
            buttons = new Button[] { btnColor1, btnColor2, btnColor3, btnColor4 };          

            // Tableau des boutons créés par l'utilisateur.
            buttonsUtilisateur = new Button[4] { btn90, btn91, btn92, btn93 };
            
              
            
            // Tableau composé de boutons de couleurs sélectionnables.
            buttonsBase = new Button[7];
            buttonsBase[0] = btnGray;
            buttonsBase[1] = btnYellow;
            buttonsBase[2] = btnWhite;
            buttonsBase[3] = btnRed;
            buttonsBase[4] = btnBlue;
            buttonsBase[5] = btnMagenta;
            buttonsBase[6] = btnCyan;

            // Un tableau composé de boutons qui montre à l'utilisateur le résultat de la comparaison.
            buttonsResult = new Button[NBR_TAILLE];
            buttonsResult[0] = rslt92;
            buttonsResult[1] = rslt90;
            buttonsResult[2] = rslt91;
            buttonsResult[3] = rslt93;   
        }

        /// <summary>
        /// Generer Les couleurs et aprèe mettre dans les boutons en tableau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genererCouleur_Click(object sender, EventArgs e)
        {    
            for (int i = 0; i < NBR_TAILLE; i++)
            {
                int index = random.Next(buttonsBase.Length);
                buttonsBase[i] = buttonsBase[index];
                buttons[i].BackColor = buttonsBase[i].BackColor;
                couleursParOrdinateur[i] = buttons[i].BackColor;
                genererCouleur.Enabled = false;
            }
            createElements();
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
            createElements();
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
                buttonsTableau[compteurColor, compteurCompare].BackColor = clickedButton.BackColor;
                couleursParUtilisateur[compteurColor] = clickedButton.BackColor;
                //b[compteurCompare, compteurColor].BackColor = clickedButton.BackColor;
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
                        buttonsTableauResult[compteurCompare, j].BackColor = Color.Green;
                    }                
                }
                if (compteurMalPlace != 0)
                {
                    for (int k = compteurMalPlace; k > 0; k--)
                    {
                        buttonsTableauResult[NBR_TAILLE - k, cmptr].BackColor = Color.Yellow; 
                    }
                                     
                }                  
            }
            if (compteurBienPlace == couleursParOrdinateur.Length) 
            {
                MessageBox.Show( $"Vous avez gagné :) Vous avez trouvé nombre d'essai {compteurCompare+1}" );
                Reset();

            }
            if (compteurCompare == 10 & compteurBienPlace != couleursParOrdinateur.Length )
            {
                MessageBox.Show( $"Vous avez perdu Vous avez essai {compteurCompare} fois" );
                Reset();
            }
        }

        /// <summary>
        /// Réinitialise les couleurs des boutons et des compteurs
        /// </summary>
        void Reset()
        {
            for (int i = 0; i < NBR_TAILLE; i++)
            {
                for (int j = 0; j < NBR_TAILLE; j++)
                {
                    buttonsTableau[i, j].BackColor = Color.FromArgb(224, 224, 224);
                    buttonsTableauResult[i, j].BackColor = Color.FromArgb(224, 224, 224);
                    buttons[i].BackColor = Color.FromArgb(224, 224, 224);
                    lblBien.Text = "";
                    lblMal.Text = "";
                    compteurCompare = 0;
                    genererCouleur.Enabled = true;
                }
            }
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
        void createElements()
        {
            
            Label label = new Label();
            label.Location = new Point(startLocationX-20, startLocationY);
            label.Name = "nbrEssai";
            label.Text = Convert.ToString(cmptr);
            label.Size = new Size(20, 20);
            pnlEssai.Controls.Add(label);

           
            for (int i = 0; i < NBR_TAILLE; i++)
            { 
                Button newBtnEssai = new Button();
                newBtnEssai.Size = new Size(pnlEssai.Width/(NBR_TAILLE*2), btnHeight);
                newBtnEssai.Location = new Point(startLocationX + (btnWidth * i), startLocationY);
                newBtnEssai.Name = "btn" + i + 1;
                newBtnEssai.Text = "Couleur" + Convert.ToString(i+1);             
                pnlEssai.Controls.Add(newBtnEssai);

                buttonsTableau[i ,cmptr - 1] = newBtnEssai;
            }
            

            for (int i = 0; i < NBR_TAILLE; i++)
            {  
                Button newBtnResultat = new Button();
                newBtnResultat.Location = new Point(350 +(i*20), startLocationY);
                newBtnResultat.Name = "btnResult" + i + 1;              
                newBtnResultat.Size = new Size(20, 20);
                pnlEssai.Controls.Add(newBtnResultat); 

                buttonsTableauResult[i , cmptr - 1] = newBtnResultat;
            }
            startLocationY += 40;
            cmptr++;
        }


    }
}
