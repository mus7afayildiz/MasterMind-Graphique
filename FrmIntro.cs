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

        private void btnDemarrager_Click(object sender, EventArgs e)
        {
            pnlinfo.Controls.Clear();
            Main main = new Main();
            main.MdiParent = this;
            main.FormBorderStyle = FormBorderStyle.None;
            pnlinfo.Controls.Add(main);
            main.Show();
           
        }

        private void FrmIntro_Load(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnlinfo.Controls.Clear();
            Information information = new Information();
            information.MdiParent = this;
            information.FormBorderStyle = FormBorderStyle.None;
            pnlinfo.Controls.Add(information);
            information.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
