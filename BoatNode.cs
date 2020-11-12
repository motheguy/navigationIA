using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace projet
{
    class BoatNode : GenericNode
    {
        public double x;
        public double y;

        //Constructeurs
        public BoatNode(int X, int Y) //avec arguments
        {
            x = X;
            y = Y;
        }

        public BoatNode() //sans argument
        {

        }

        public override double CalculeHCost()
        {
            //Permet d'obtenir une estimation heuristique du cout pour atteindre le point final

            throw new NotImplementedException();
        }

        public override bool EndState()
        {
            return (x == MainForm.Xf && y == MainForm.Yf);
        }

        public override double GetArcCost(GenericNode N2) //OK a verifier
        {
            //Permet d'obtenir le cout de l'arc entre 2 noeuds
            BoatNode N2bis = (BoatNode)N2;
            double valGCostN2 = time_estimation(x, y, N2bis.x, N2bis.y); //On calcule le cout
            N2.SetGCost(valGCostN2); //On l'enregistre dans N2
            return valGCostN2;
        }

        public override List<GenericNode> GetListSucc() //OK a verifier
        {
            //on recupere les valeurs des points voisins et on les ajoute a notre liste
            //notre pavage est carre et le point considere possède 8 voisins

            List<GenericNode> successeur = new List<GenericNode>();
            BoatNode b1 = new BoatNode();
            b1.x = x + 1;
            b1.y = y;
            successeur.Add(b1);

            BoatNode b2 = new BoatNode();
            b2.x = x - 1;
            b2.y = y;
            successeur.Add(b2);

            BoatNode b3 = new BoatNode();
            b3.x = x;
            b3.y = y - 1;
            successeur.Add(b3);

            BoatNode b4 = new BoatNode();
            b4.x = x + 1;
            b4.y = y - 1;
            successeur.Add(b4);

            BoatNode b5 = new BoatNode();
            b5.x = x - 1;
            b5.y = y - 1;
            successeur.Add(b5);

            BoatNode b6 = new BoatNode();
            b6.x = x;
            b6.y = y + 1;
            successeur.Add(b6);

            BoatNode b7 = new BoatNode();
            b7.x = x + 1;
            b7.y = y + 1;
            successeur.Add(b7);

            BoatNode b8 = new BoatNode();
            b8.x = x - 1;
            b8.y = y + 1;
            successeur.Add(b8);

            return successeur;

            throw new NotImplementedException();
        }

        public override bool IsEqual(GenericNode N2)
        {
            BoatNode N2bis = (BoatNode)N2;
            return (x == N2bis.x && y == N2bis.y);
        }

        //Code de Salotti
        public char cas = 'a'; // à modifier en ‘b’ ou ‘c’ selon le choix de l’utilisateur // A FAIRE
        public double get_wind_speed(double x, double y) //OK a verifier
        {
            //On distingue plusieurs cas en fonction de la valeur du char cas, saisi par l'utilisateur
            if (cas == 'a')
                return 50;
            else if (cas == 'b')
                if (y > 150)
                    return 50;
                else return 20;
            else if (y > 150)
                return 50;
            else return 20;
        }
        public double get_wind_direction(double x, double y) //OK a verifier
        {
            //On distingue plusieurs cas en fonction de la valeur du char cas, saisi par l'utilisateur
            if (cas == 'a')
                return 30;
            else if (cas == 'b')
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else return 65;
        }
        public double time_estimation(double x1, double y1, double x2, double y2) //OK a verifier
        {
            //Etape 1 : calcul distance

            //On calcule la distance entre les 2 points
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            //cas 1 :
            if (distance > 10) return 1000000; // le point est trop loin, retourne une valeur d'arret

            //cas 2 : 

            //Etape 2 : calcul vitesse et direction du vent et du bateau

            //On calcule la vitesse et la direction du vent
            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);

            //On calcule la vitesse et la direction du bateau
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;

            //Etape 3 : determination de la position du bateau relativement au vent

            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :

            //cas 1 : recalcul d'alpha
            if (alpha > 180) alpha = 360 - alpha;

            //cas 2 : entre vent arrière et largue
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }

            //cas 3 : entre largue et travers
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }

            //cas 4 : entre travers et près jusqu'a 150°
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }

            //cas 5 : alpha sup a 150° et inf a 180°, la vitesse est nulle, le bateau ne peut plus avance
            else
                return 1000000; //envoi valeur d'arret
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

    }
}
