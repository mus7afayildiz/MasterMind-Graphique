/// ETML
/// Auteur : Mustafa Yildiz
/// Date   : jeudi, 23 novembre 2023
/// Description : Dans ce panneau, vous pouvez trouver les codes qui créent le menu pour les informations sur le jeu et la sélection des jeux. 

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
    public partial class FrmIntro : Form
    {
        public int item = 0;
        public FrmIntro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Pour commencer le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemarrager_Click(object sender, EventArgs e)
        {
            /// effacer la panel
            pnlinfo.Controls.Clear();

            /// Créer et associer le objet information dans la même panel
            Main main = new Main();
            main.MdiParent = this;
            main.FormBorderStyle = FormBorderStyle.None;
            pnlinfo.Controls.Add(main);
            main.Show();
        }

        private void FrmIntro_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Pour lire les régles de jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            /// effacer la panel
            pnlinfo.Controls.Clear();

            /// Créer et associer le objet information dans la même panel
            Information information = new Information();
            information.MdiParent = this;
            information.FormBorderStyle = FormBorderStyle.None;
            pnlinfo.Controls.Add(information);
            information.Show();
        }
    }
}
