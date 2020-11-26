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
            //A faire : Changer les textBox pour des NumericUpDown 
            int beginX = (int)numericUpDownXi.Value;
            int beginY = (int)numericUpDownYi.Value;

            int endX = (int)numericUpDownXf.Value;
            int endY = (int)numericUpDownYf.Value;
            //int beginX = textBoxXi.Text == "" ? 0 : Convert.ToInt32(textBoxXi.Text);
            //int beginY = textBoxYi.Text == "" ? 0 : Convert.ToInt32(textBoxYi.Text);
            //int endX = textBoxXf.Text == "" ? 0 : Convert.ToInt32(textBoxXf.Text);
            //int endY = textBoxYf.Text == "" ? 0 : Convert.ToInt32(textBoxYf.Text);

            beginY = pictureBoxOcean.Height - beginY;
            endY = pictureBoxOcean.Height - endY;

            using Graphics g = Graphics.FromImage(bg);
            Brush yellowBruch = new SolidBrush(Color.Yellow);
            g.FillEllipse(yellowBruch, beginX - 4, beginY - 4, 8, 8);
            g.FillEllipse(yellowBruch, endX - 4, endY - 4, 8, 8);
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
            //BONUS : On vérifie d'abord que toutes les valeurs sont saisies --> Pas besoin on a des valeurs pas défaut ?
            Xi = (int)numericUpDownXi.Value;
            Yi = (int)numericUpDownYi.Value;
            
            Xf = (int)numericUpDownXf.Value;
            Yf = (int)numericUpDownYf.Value;
            if (radioButtonB.Checked)
            {
                cas = radioButtonB.Text[0];
            }
            else if (radioButtonC.Checked)
            {
                cas = radioButtonC.Text[0];
            }
            else
            {
                cas = radioButtonA.Text[0]; // si = a ou non défini
            }
            textBoxResult.Text = "Type de vent choisi : " + cas + "";
            await Task.Delay(20);

            SearchTree g = new SearchTree();

            //On crée le point de départ
            BoatNode N0 = new BoatNode(Xi, Yi);

            //On crée le point d'arrivée
            BoatNode Nf = new BoatNode(Xf, Yf);

            //On lance la recherche du meilleur chemin
            List<GenericNode> solution = new List<GenericNode>(); //initialisation pour pouvoir refaire des calculs dans le programme
            solution = g.RechercheSolutionAEtoile(N0);

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
                    gph.DrawLine(penWhite, new Point((int)((BoatNode)solution[i]).x, pictureBoxOcean.Height - (int)((BoatNode)solution[i]).y), new Point((int)((BoatNode)solution[i + 1]).x, pictureBoxOcean.Height - (int)((BoatNode)solution[i + 1]).y));
                    pictureBoxOcean.Image = bg;
                    await Task.Delay(200);
                }
                //textBoxResult.Text = "Nb noeuds des ouverts : " + g.CountInOpenList().ToString() + "\nNb noeuds des fermés : " + g.CountInClosedList().ToString();
                int somme = g.CountInOpenList() + g.CountInClosedList();
                textBoxNbSolution.Text = solution.Count().ToString();
                textBoxSomme.Text = somme.ToString() + "\nO:"+ g.CountInOpenList().ToString()+"\nF:"+ g.CountInClosedList().ToString();
                double time = 0;

                for (int i = 0; i < solution.Count - 1; i++)
                {
                    BoatNode nodeIni = (BoatNode)solution[i];
                    BoatNode nodeArrival = (BoatNode)solution[i + 1];
                    time += nodeIni.time_estimation(nodeIni.x, nodeIni.y, nodeArrival.x, nodeArrival.y);
                }
                /*
                foreach (GenericNode noeud in solution)
                {
                    time = time + noeud.GetGCost();
                }
                */
                textBoxTime.Text = Math.Round(time,2,MidpointRounding.ToEven).ToString() + "h";
            }

        }
        /// <summary>
        /// Reset the form
        /// </summary>
        private void Reset(object sender, EventArgs e)
        {
            numericUpDownXi.Value = 100;
            numericUpDownYi.Value = 200;
            numericUpDownXf.Value = 200;
            numericUpDownYf.Value = 100;

            textBoxResult.Text = "";
            textBoxTime.Text = "";
            textBoxSomme.Text = "";
            textBoxNbSolution.Text = "";


            Draw();
            //réinitialiser les liste de noeuds
        }

    }
}
