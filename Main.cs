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
        static Random random = new Random();
        Color[] couleurs = { Color.Gray, Color.Yellow, Color.White, Color.Red, Color.Blue, Color.Magenta, Color.Cyan};
       


        Color[] couleursParOrdinateur = new Color[4];
        Color[] couleursParUtilisateur = new Color[4];   

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

            /*
            Button[,] buttonsTableau =
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

        };
            */
            buttonsTableau = new Button[10,4];
            buttonsTableau[0,0] = btn00;
            buttonsTableau[0,1] = btn01;
            buttonsTableau[0,2] = btn02;
            buttonsTableau[0,3] = btn03;
            buttonsTableau[1,0] = btn10;
            buttonsTableau[1,1] = btn11;
            buttonsTableau[1,2] = btn12;
            buttonsTableau[1,3] = btn13;
            buttonsTableau[2,0] = btn20;
            buttonsTableau[2,1] = btn21;
            buttonsTableau[2,2] = btn22;
            buttonsTableau[2,3] = btn23;
            buttonsTableau[3,0] = btn30;
            buttonsTableau[3,1] = btn31;
            buttonsTableau[3,2] = btn32;
            buttonsTableau[3,3] = btn33;
            buttonsTableau[4,0] = btn40;
            buttonsTableau[4,1] = btn41;
            buttonsTableau[4,2] = btn42;
            buttonsTableau[4,3] = btn43;
            buttonsTableau[5,0] = btn50;
            buttonsTableau[5,1] = btn51;
            buttonsTableau[5,2] = btn52;
            buttonsTableau[5,3] = btn53;
            buttonsTableau[6,0] = btn60;
            buttonsTableau[6,1] = btn61;
            buttonsTableau[6,2] = btn62;
            buttonsTableau[6,3] = btn63;
            buttonsTableau[7,0] = btn70;
            buttonsTableau[7,1] = btn71;
            buttonsTableau[7,2] = btn72;
            buttonsTableau[7,3] = btn73;
            buttonsTableau[8,0] = btn80;
            buttonsTableau[8,1] = btn81;
            buttonsTableau[8,2] = btn82;
            buttonsTableau[8,3] = btn83;
            buttonsTableau[9,0] = btn90;
            buttonsTableau[9,1] = btn91;
            buttonsTableau[9,2] = btn92;
            buttonsTableau[9,3] = btn93;

            buttonsTableauResult = new Button[10, 4];
            buttonsTableauResult[0, 0] = rslt00;
            buttonsTableauResult[0, 1] = rslt01;
            buttonsTableauResult[0, 2] = rslt02;
            buttonsTableauResult[0, 3] = rslt03;
            buttonsTableauResult[1, 0] = rslt10;
            buttonsTableauResult[1, 1] = rslt11;
            buttonsTableauResult[1, 2] = rslt12;
            buttonsTableauResult[1, 3] = rslt13;
            buttonsTableauResult[2, 0] = rslt20;
            buttonsTableauResult[2, 1] = rslt21;
            buttonsTableauResult[2, 2] = rslt22;
            buttonsTableauResult[2, 3] = rslt23;
            buttonsTableauResult[3, 0] = rslt30;
            buttonsTableauResult[3, 1] = rslt31;
            buttonsTableauResult[3, 2] = rslt32;
            buttonsTableauResult[3, 3] = rslt33;
            buttonsTableauResult[4, 0] = rslt40;
            buttonsTableauResult[4, 1] = rslt41;
            buttonsTableauResult[4, 2] = rslt42;
            buttonsTableauResult[4, 3] = rslt43;
            buttonsTableauResult[5, 0] = rslt50;
            buttonsTableauResult[5, 1] = rslt51;
            buttonsTableauResult[5, 2] = rslt52;
            buttonsTableauResult[5, 3] = rslt53;
            buttonsTableauResult[6, 0] = rslt60;
            buttonsTableauResult[6, 1] = rslt61;
            buttonsTableauResult[6, 2] = rslt62;
            buttonsTableauResult[6, 3] = rslt63;
            buttonsTableauResult[7, 0] = rslt70;
            buttonsTableauResult[7, 1] = rslt71;
            buttonsTableauResult[7, 2] = rslt72;
            buttonsTableauResult[7, 3] = rslt73;
            buttonsTableauResult[8, 0] = rslt80;
            buttonsTableauResult[8, 1] = rslt81;
            buttonsTableauResult[8, 2] = rslt82;
            buttonsTableauResult[8, 3] = rslt83;
            buttonsTableauResult[9, 0] = rslt90;
            buttonsTableauResult[9, 1] = rslt91;
            buttonsTableauResult[9, 2] = rslt92;
            buttonsTableauResult[9, 3] = rslt93;


            // Tableau des boutons colorés générés par l'ordinateur.
            buttons = new Button[4];
            buttons[0] = btnColor1;
            buttons[1] = btnColor2;
            buttons[2] = btnColor3; 
            buttons[3] = btnColor4;

            // Tableau des boutons créés par l'utilisateur.
            
            buttonsUtilisateur = new Button[4];
            buttonsUtilisateur[0] = btn90;
            buttonsUtilisateur[1] = btn91;
            buttonsUtilisateur[2] = btn92;
            buttonsUtilisateur[3] = btn93;
              

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
            buttonsResult = new Button[4];
            buttonsResult[0] = rslt92;
            buttonsResult[1] = rslt90;
            buttonsResult[2] = rslt91;
            buttonsResult[3] = rslt93;   
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Generer Les couleurs et aprèe mettre dans les boutons en tableau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genererCouleur_Click(object sender, EventArgs e)
        {    
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(buttonsBase.Length);
                buttonsBase[i] = buttonsBase[index];
                buttons[i].BackColor = buttonsBase[i].BackColor;
                couleursParOrdinateur[i] = buttons[i].BackColor;
            }  
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void btn1_Click(object sender, EventArgs e)
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
            compteurCompare++;
            compteurColor = 0;
            compteurBienPlace = 0;
            compteurMalPlace = 0;
            for (int i = 0; i < 4; i++)
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
            if (compteurColor < 4)
            {
                buttonsTableau[compteurCompare, compteurColor].BackColor = clickedButton.BackColor;
                couleursParUtilisateur[compteurColor] = clickedButton.BackColor;
                compteurColor++;
            }
            else
            {
                MessageBox.Show("Fazla girdin degerlendir i tikla");
            }
                

            //buttonsUtilisateur[compteurColor].BackColor = clickedButton.BackColor;
            
        }

        //Les couleurs de l'ordinateur et de l'utilisateur sont comparées par même index.
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

        //Après évaluation, le résultat est affiché sur la console.
        void MontreResultat()
        {
            for (int i = 0; i <= 4; i++)
            {                           
                if (compteurBienPlace >=
                    i)
                {
                    buttonsTableauResult[compteurCompare, i].BackColor = Color.Green;
                    buttonsTableauResult[compteurCompare, i].Text = Convert.ToString(compteurBienPlace);
                } else if (compteurMalPlace > i)
                {
                    buttonsTableauResult[compteurCompare, 4-i].BackColor = Color.Yellow;
                    buttonsTableauResult[compteurCompare, 4-i].Text = Convert.ToString(compteurMalPlace);
                }                  
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {

        }
    }
}
