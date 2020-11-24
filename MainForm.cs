using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Draw();
        }
        ///<summary>
        ///Set the background for pictureBoxOcean
        ///</summary>
        private void Draw()
        {
            Bitmap bg = Bitmap.FromFile(".\\images\\ocean2.jpg") as Bitmap;
            Bitmap begin = Bitmap.FromFile(".\\images\\x.png") as Bitmap;
            Bitmap end = Bitmap.FromFile(".\\images\\x.png") as Bitmap;
            //Pen penRed = new Pen(Color.Red); //d'autres couleurs possibles
            //A faire : Changer les textBox pour des NumericUpDown 
            int beginX = textBoxXi.Text == "" ? 0 : Convert.ToInt32(textBoxXi.Text);
            int beginY = textBoxYi.Text == "" ? 0 : Convert.ToInt32(textBoxYi.Text);
            int endX = textBoxXf.Text == "" ? 0 : Convert.ToInt32(textBoxXf.Text);
            int endY = textBoxYf.Text == "" ? 0 : Convert.ToInt32(textBoxXf.Text);
            using Graphics g = Graphics.FromImage(bg);
            //g.DrawLine(penRed, new Point(beginX, beginY), new Point(endX,endY));
            g.DrawImage(begin, beginX, beginY, 8, 8); //modifier les 4e et 5e parametres pour changer la taille des croix
            g.DrawImage(end, endX, endY, 8, 8);
            pictureBoxOcean.Image = bg;
        }
        ///<summary>
        ///Reset the background for pictureBoxOcean when the coordinates of the departure or arrival points are modified
        ///</summary>
        private void NewCoordinate(object sender, EventArgs e)
        {
            Draw();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Quand l'utilisateur appuie sur le bouton démarrer, le code se lance

            //On récupère les valeurs saisies
            //BONUS : On vérifie d'abord que toutes les valeurs sont saisies //A FAIRE
            Xi = Convert.ToInt32(textBoxXi.Text);
            Yi = Convert.ToInt32(textBoxYi.Text);
            Xf = Convert.ToInt32(textBoxXf.Text);
            Yf = Convert.ToInt32(textBoxYf.Text);
            cas = cmbBxWind.Text[0];
            textBoxResult.Text = "Type de vent choisi : " + cas + "";
            await Task.Delay(20);

            SearchTree g = new SearchTree();

            //On crée le point de départ
            BoatNode N0 = new BoatNode(Xi, Yi);

            //On crée le point d'arrivée
            BoatNode Nf = new BoatNode(Xf, Yf);

            //On lance la recherche du meilleur chemin
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            if (solution.Count == 0)//il n'y a pas de solution
            {
                textBoxResult.Text = "Pas de solution";
            }
            else
            {
                textBoxResult.Text = "Une solution a été trouvée";
                // Petite animation
                Pen penWhite = new Pen(Color.White);
                for (int i = 0; i < solution.Count - 2; i++)
                {
                    Bitmap bg = pictureBoxOcean.Image as Bitmap;
                    Graphics gph = Graphics.FromImage(bg);
                    gph.DrawLine(penWhite, new Point((int)((BoatNode)solution[i]).x, (int)((BoatNode)solution[i]).y), new Point((int)((BoatNode)solution[i + 1]).x, (int)((BoatNode)solution[i + 1]).y));
                    pictureBoxOcean.Image = bg;
                    await Task.Delay(200);
                }
                textBoxResult.Text = "Nb noeuds des ouverts : " + g.CountInOpenList().ToString() + "\nNb noeuds des fermés : " + g.CountInClosedList().ToString();
                double time = 0;
                foreach (GenericNode noeud in solution)
                {
                    time = time + noeud.GetGCost();
                }
                textBoxTime.Text = time.ToString() + "h";
            }

        }
        /// <summary>
        /// Juste un test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click_1(object sender, EventArgs e)
        {
            textBoxXi.Text = "10";
            textBoxYi.Text = "10";
            textBoxXf.Text = "20";
            textBoxYf.Text = "20";
            Draw();
            //Récuperer les coordonnées de chaque noeud enregistré normalement dans solution
            List<GenericNode> listCoordTest = new List<GenericNode>() { new BoatNode(10, 12), new BoatNode(10, 14), new BoatNode(10, 16), new BoatNode(10, 18), new BoatNode(10, 20), new BoatNode(12, 20), new BoatNode(14, 20), new BoatNode(16, 20), new BoatNode(18, 20), new BoatNode(20, 20) };
            Pen penWhite = new Pen(Color.White);
            for (int i = 0; i < listCoordTest.Count - 2; i++)
            {
                Bitmap bg = pictureBoxOcean.Image as Bitmap;
                Graphics g = Graphics.FromImage(bg);
                g.DrawLine(penWhite, new Point((int)((BoatNode)listCoordTest[i]).x, (int)((BoatNode)listCoordTest[i]).y), new Point((int)((BoatNode)listCoordTest[i + 1]).x, (int)((BoatNode)listCoordTest[i + 1]).y));
                pictureBoxOcean.Image = bg;
                await Task.Delay(500);
            }
            textBoxResult.Text = "Vous avez parcouru la distance en X s";
        }
    }
}
