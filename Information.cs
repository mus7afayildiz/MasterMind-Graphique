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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            TextCreate();
        }

        void TextCreate() {
            RichTextBox textBox = new RichTextBox();
            textBox.Text = "MasterMind - Règles du jeu.\r\n\r\n-L'ordinateur choisit une séquence de couleurs. " +
                "Le nombre de couleurs correspond à la longueur du code. La longueur du code par défaut est de 4." +
                "\r\n\r\n-L'objectif du jeu est de deviner les positions exactes des couleurs dans la séquence de l'ordinateur." +
                "\r\n\r\n-Après avoir rempli une ligne avec vos suppositions et cliqué sur le bouton \"Enter\", " +
                "l'ordinateur répond avec le résultat de votre supposition." +
                "\r\n\r\n-Chaque couleur que vous estimez est correcte si elle correspond à la couleur " +
                "et à la position correctes dans la séquence de codes." +
                "\r\n\r\n-Même si chaque couleur de votre prédiction est la bonne couleur dans la séquence de codes, " +
                "si elle n'est pas dans la bonne position, " +
                "\r\n\r\n elle s'affichera comme étant la mauvaise position." +
                "\r\n\r\n-Vous gagnez le jeu lorsque vous parvenez à deviner toutes les couleurs de la séquence de code " +
                "et qu'elles sont toutes à la bonne position." +
                "\r\n\r\n-Vous perdez le jeu si vous utilisez toutes les tentatives sans deviner la séquence de code de l'ordinateur." +
                "\r\n\r\nComment jouer à ce jeu: Après avoir rempli la ligne en choisissant 4 couleurs sur 7, " +
                "\r\n\r\n vous pouvez modifier votre sélection avant de demander à l'ordinateur de répondre à votre supposition. " +
                "\r\n\r\n Une fois que vous êtes satisfait de votre réponse, cliquez sur le bouton « Entrée » et obtenez la réponse de l'ordinateur." +
                "\r\n\r\nBonne chance !";
            textBox.Font = new Font("Georgia", 7);
            textBox.Location = new Point(80, 150);
            textBox.Height = 1200;
            textBox.Width = 1600;
            Controls.Add(textBox);
        }
        private void Information_Load(object sender, EventArgs e)
        {
           

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmIntro frmIntro = new FrmIntro();
            frmIntro.MdiParent = this;            
            frmIntro.FormBorderStyle = FormBorderStyle.None;
            Controls.Add(frmIntro);
            frmIntro.Show();
        }
    }
}
