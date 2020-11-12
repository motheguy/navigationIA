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
        static public char cas;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Quand l'utilisateur appuie sur le bouton démarrer, le code se lance

            //On récupère les valeurs saisies
            //BONUS : On vérifie d'abord que toutes les valeurs sont saisies //A FAIRE
            Xi = Convert.ToInt32(textBoxXi.Text);
            Yi = Convert.ToInt32(textBoxYi.Text);
            Xf = Convert.ToInt32(textBoxXf.Text);
            Yf = Convert.ToInt32(textBoxYf.Text);

            SearchTree g = new SearchTree();

            //On créé le point de départ
            BoatNode N0 = new BoatNode(Xi, Yi);

            //On créé le point d'arrivée
            BoatNode Nf = new BoatNode(Xf, Yf);

            //On lance la recherche du meilleur chemin
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            //A FAIRE 
            //gerer l'affichage

            /*Code de Salotti :
             * 
             * soient x1,y1 et x2,y2 les deux extrêmités du segment
             * Pen penwhite = new Pen(Color.White); //d'autres couleurs possibles
             * Graphics g = pictureBox1.CreateGraphics();
             * g.DrawLine(penwhite, new Point((int)x1, pictureBox1.Height-(int)y1),
             *                      new Point((int)x2, pictureBox1.Height-(int)y2));
             */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
