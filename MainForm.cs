using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class MainForm : Form
    {
        static public int Xi;
        static public int Yi;
        static public int Xf;
        static public int Yf;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xi = Convert.ToInt32(textBoxXi.Text);
            Yi = Convert.ToInt32(textBoxYi.Text);
            Xf = Convert.ToInt32(textBoxXf.Text);
            Yf = Convert.ToInt32(textBoxYf.Text);
            SearchTree g = new SearchTree();
            BoatNode N0 = new BoatNode();
            //N0.numero = numinitial;a adapter pour les coordonnées
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            //gerer l'affichage
        }
    }
}
